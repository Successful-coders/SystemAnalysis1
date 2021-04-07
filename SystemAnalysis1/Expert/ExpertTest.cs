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
        private PairComparisonMatrix matrix;


        public ExpertTest(List<Alternative> alternatives, PairComparisonMatrix matrix)
        {
            this.matrix = matrix;

            InitializeComponent();

            alternativePairs = InitQuestions(alternatives);
            CreatePollPanels();
        }


        private void CreatePollPanels()
        {
            pollFlowLayoutPanel.Controls.RemoveAt(0);

            for (int i = 0; i < alternativePairs.Count; i++)
            {
                PollPanel panel = new PollPanel(i, alternativePairs[i], OnAnswerButtonClicked);
                panel.Location = new Point(10 * i, 10 * i);

                pollFlowLayoutPanel.Controls.Add(panel);
            }
        }
        private void OnAnswerButtonClicked(int questionIndex, int[] indexes)
        {
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

            if (checkedListBox.CheckedIndices.Count == 2)
            {
                matrix.values[indexes[0], indexes[1]] = 0.5d;
                matrix.values[indexes[1], indexes[0]] = 0.5d;
            }
            else if (checkedListBox.CheckedIndices.Count == 1)
            {
                int checkedAnswerIndex = (int)checkedListBox?.CheckedIndices[0];
                int primaryIndex = indexes[checkedAnswerIndex];
                int secondaryIndex = checkedAnswerIndex == 0 ? indexes[1] : indexes[0];

                matrix.values[primaryIndex, secondaryIndex] = 1.0d;
                matrix.values[secondaryIndex, primaryIndex] = 0.0d;
            }
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
            matrix.IsFull = true;
            Close();
        }
    }
}
