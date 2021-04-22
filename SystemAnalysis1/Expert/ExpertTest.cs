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
    public partial class ExpertTest : Form
    {
        private List<Alternative[]> alternativePairs;
        private Matrix matrix;
        private List<bool> isQuestionAnswereds = new List<bool>();


        public ExpertTest(List<Alternative> alternatives, Matrix matrix)
        {
            this.matrix = matrix;

            InitializeComponent();

            alternativePairs = InitQuestions(alternatives);
            CreatePollPanels();

            isQuestionAnswereds = new List<bool>(alternativePairs.Count);
            for (int i = 0; i < alternativePairs.Count; i++)
            {
                if (Math.Abs(matrix.values[alternativePairs[i][0].index, alternativePairs[i][1].index]) < 0.01d)
                {
                    isQuestionAnswereds.Add(false);
                }
                else
                {
                    isQuestionAnswereds.Add(true);
                }
            }

            completeButton.Visible = isQuestionAnswereds.All(x => x);
        }


        private void CreatePollPanels()
        {
            pollFlowLayoutPanel.Controls.RemoveAt(0);

            for (int i = 0; i < alternativePairs.Count; i++)
            {
                PollPanel panel = new PollPanel(i, alternativePairs[i], OnAnswerButtonClicked, matrix);
                panel.Location = new Point(10 * i, 10 * i);

                pollFlowLayoutPanel.Controls.Add(panel);
            }
        }
        private void OnAnswerButtonClicked(int questionIndex, int[] indexes, int checkedIndicesCount, int checkedAnswerIndex)
        {
            if (pollFlowLayoutPanel.Controls.Count == 0)
                return;

            CheckedListBox checkedListBox = null;
            foreach (var control in pollFlowLayoutPanel.Controls[questionIndex].Controls)
            {
                if (control.GetType() == typeof(CheckedListBox))
                {
                    checkedListBox = control as CheckedListBox;

                    break;
                }
            }

            if (checkedListBox == null)
                return;

            if (checkedIndicesCount == 2)
            {
                matrix.values[indexes[0], indexes[1]] = 0.5d;
                matrix.values[indexes[1], indexes[0]] = 0.5d;
            }
            else if (checkedIndicesCount == 1)
            {
                int primaryIndex = indexes[checkedAnswerIndex];
                int secondaryIndex = checkedAnswerIndex == 0 ? indexes[1] : indexes[0];

                matrix.values[primaryIndex, secondaryIndex] = 1.0d;
                matrix.values[secondaryIndex, primaryIndex] = 0.0d;
            }

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
