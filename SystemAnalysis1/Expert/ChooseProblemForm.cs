using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis1
{
    public partial class ChooseProblemForm : Form
    {
        private List<Problem> problems;
        private Expert expert;

        public ChooseProblemForm(Expert expert)
        {
            this.expert = expert;

            InitializeComponent();

            nameLabel.Text = "Эксперт: " + expert.name;

            InitProblems(expert);
        }


        private void InitProblems(Expert expert)
        {
            problemsList.Items.Clear();

            problems = Data.problems.Where(x => x.Experts.Any(y => y == expert) && x.Status == Status.Оценивание).ToList();

            int rowIndex = 0;
            for (int i = 0; i < problems.Count; i++)
            {
                for (int methodIndex = 0; methodIndex < Enum.GetValues(typeof(SolvingMethod)).Length; methodIndex++)
                {
                    problemsList.Items.Add(new ListViewItem(new string[] { (rowIndex + 1).ToString(), problems[i].Name + 
                        " (" + ConvertMethodToString((SolvingMethod)methodIndex) + ")" }));
                    rowIndex++;
                }
            }

            DrawProblemList();
        }

        private void problemsList_DoubleClick(object sender, EventArgs e)
        {
            int solvingMethodCount = Enum.GetValues(typeof(SolvingMethod)).Length;
            int problemIndex = problemsList.SelectedItems[0].Index / solvingMethodCount;
            int methodTypeIndex = problemsList.SelectedItems[0].Index % solvingMethodCount;

            Problem problem = problems[problemIndex];
            Matrix matrix = problem.GetMatrix(expert, methodTypeIndex);
            if (matrix.IsFull)
            {
                MessageBox.Show("Оценка этой проблемы уже была завершена");
                return;
            }

            Hide();


            Form expertTestForm;
            switch ((SolvingMethod)methodTypeIndex)
            {
                case SolvingMethod.PairComparison:
                    {
                        expertTestForm = new ExpertTest(problem.Alternatives, matrix, problem);
                        break;
                    }
                case SolvingMethod.WeightedJudgement:
                    {
                        expertTestForm = new ExpertWeightedJudgementTest(problem.Alternatives, matrix, problem);
                        break;
                    }
                case SolvingMethod.Prefer:
                    {
                        expertTestForm = new ExpertTestPrefer(problem.Alternatives, matrix, problem);
                        break;
                    }
                case SolvingMethod.Rang:
                    {
                        expertTestForm = new ExpertTestRang(problem.Alternatives, matrix, problem);
                        break;
                    }
                case SolvingMethod.FullPairMatching:
                    {
                        expertTestForm = new ExpertFullPairMatchingTest(problem.Alternatives, matrix, problem);
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            expertTestForm.Closed += (s, args) => Show();
            expertTestForm.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DrawProblemList()
        {
            int rowIndex = 0;
            for (int i = 0; i < problems.Count; i++)
            {
                for (int methodIndex = 0; methodIndex < Enum.GetValues(typeof(SolvingMethod)).Length; methodIndex++)
                {
                    if (problems[i].GetMatrix(expert, methodIndex).IsFull)
                    {
                        problemsList.Items[rowIndex].BackColor = Color.MediumSeaGreen;
                        problemsList.Items[rowIndex].SubItems[1].Text = problems[i].Name + " [завершен]";
                    }
                    else
                    {
                        problemsList.Items[rowIndex].BackColor = Color.LightGoldenrodYellow;
                    }

                    rowIndex++;
                }
            }
        }
        private void ChooseProblemForm_Activated(object sender, EventArgs e)
        {
            DrawProblemList();
        }
        private string ConvertMethodToString(SolvingMethod solvingMethod)
        {
            switch (solvingMethod)
            {
                case SolvingMethod.PairComparison:
                    return "Метод парных сравнений";
                case SolvingMethod.WeightedJudgement:
                    return "Метод взвешенных экспертных оценок";
                case SolvingMethod.Prefer:
                    return "Метод предпочтения";
                case SolvingMethod.Rang:
                    return "Метод ранга";
                case SolvingMethod.FullPairMatching:
                    return "Метод полного попарного сопоставления";
                default:
                    return "";
            }
        }
    }
}
