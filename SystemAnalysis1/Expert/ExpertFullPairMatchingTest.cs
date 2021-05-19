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
    public partial class ExpertFullPairMatchingTest : Form
    {
        private List<Alternative[]> alternativePairs;
        private Matrix matrix;
        private List<bool> isQuestionAnswereds = new List<bool>();
        private int maxValue;


        public ExpertFullPairMatchingTest(List<Alternative> alternatives, Matrix matrix, Problem problem, int maxValue)
        {
            this.maxValue = maxValue;
            this.matrix = matrix;
            InitializeComponent();

            Problem.Text = problem.Description;

            alternativePairs = InitQuestions(alternatives);

            isQuestionAnswereds = new List<bool>(alternativePairs.Count);
            //TODO: change
            for (int i = 0; i < alternativePairs.Count; i++)
            {
                isQuestionAnswereds.Add(true);
            }

            CreatePollPanels();

            completeButton.Visible = isQuestionAnswereds.All(x => x);
        }


        private void CreatePollPanels()
        {
            pollFlowLayoutPanel.Controls.RemoveAt(0);

            for (int i = 0; i < alternativePairs.Count; i++)
            {
                ExpertFullPairPollPanel panel = new ExpertFullPairPollPanel(i, alternativePairs[i], OnAnswerButtonClicked, maxValue, matrix);
                panel.Location = new Point(10 * i, 10 * i);

                pollFlowLayoutPanel.Controls.Add(panel);
            }
        }
        private void OnAnswerButtonClicked(int questionIndex, int oldValue, int value)
        {
            if (pollFlowLayoutPanel.Controls.Count == 0)
                return;

            //TODO: Fill matrix
            var alternativePair = alternativePairs[questionIndex];
            matrix.values[alternativePair[0].index, alternativePair[1].index] = 1 - ((float)value / (float)maxValue);
            matrix.values[alternativePair[1].index, alternativePair[0].index] = ((float)value / (float)maxValue);

            isQuestionAnswereds[questionIndex] = true;

            completeButton.Visible = isQuestionAnswereds.All(x => x);
        }
        private List<Alternative[]> InitQuestions(List<Alternative> alternatives)
        {
            List<Alternative[]> alternativePairs = new List<Alternative[]>();

            var result = GetPermutations(alternatives, 2);

            for (int i = 0; i < result.Count(); i++)
            {
                alternativePairs.Add(new Alternative[2]);

                for (int j = 0; j < 2; j++)
                {
                    alternativePairs[i][j] = result.ToList()[i].ToList()[j];
                }
            }

            return alternativePairs;
        }
        private IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                        yield return new T[] { item }.Concat(result);
                }

                ++i;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void completeButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите завершить оценку?", "Заверешение оценки", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                matrix.IsFull = true;
                Close();
            }
            else
            {
                
            }
        }
    }
}
