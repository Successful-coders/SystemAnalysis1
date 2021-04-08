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

            for (int i = 0; i < problems.Count; i++)
            {
                problemsList.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), problems[i].Name }));
            }

            DrawProblemList();
        }

        private void problemsList_DoubleClick(object sender, EventArgs e)
        {
            Problem problem = problems[problemsList.SelectedItems[0].Index];
            if (problem.GetMatrix(expert).IsFull)
            {
                MessageBox.Show("Оценка этой проблемы уже была завершена");
                return;
            }

            Hide();
            ExpertTest expertTest = new ExpertTest(problem.Alternatives, problem.GetMatrix(expert));
            expertTest.Closed += (s, args) => Show();
            expertTest.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DrawProblemList()
        {
            for (int i = 0; i < problems.Count; i++)
            {
                if (problems[i].GetMatrix(expert).IsFull)
                {
                    problemsList.Items[i].BackColor = Color.MediumSeaGreen;
                    problemsList.Items[i].SubItems[1].Text = problems[i].Name + " (завершен)";
                }
                else
                {
                    problemsList.Items[i].BackColor = Color.LightGoldenrodYellow;
                }
            }
        }
        private void ChooseProblemForm_Activated(object sender, EventArgs e)
        {
            DrawProblemList();
        }
    }
}
