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


        public ExpertTest(List<Alternative> alternatives)
        {
            InitializeComponent();

            matrix = new PairComparisonMatrix(alternatives.Count);
            matrixDisplay.Text = matrix.ToString();

            alternativePairs = InitQuestions(alternatives);
            CreatePollPanels();
        }


        private void CreatePollPanels()
        {
            for (int i = 0; i < alternativePairs.Count; i++)
            {
                Panel panel = new Panel();
                panel.Location = new Point(10 * i, 10 * i);
                panel.BorderStyle = pollPanel.BorderStyle;
                panel.BackColor = pollPanel.BackColor;
                panel.Size = pollPanel.Size;
                panel.Visible = true;

                foreach (Control control in pollPanel.Controls)
                {
                    Control newControl = new Control();
                    if (control.GetType() == typeof(TextBox))
                    {
                        newControl = new TextBox();
                        newControl.Text = control.Text;
                    }
                    else if (control.GetType() == typeof(Label) && control.Tag?.ToString() == "index")
                    {
                        newControl = new Label();
                        newControl.Text = (i + 1).ToString() + ".";
                    }
                    else if (control.GetType() == typeof(Label))
                    {
                        newControl = new Label();
                        newControl.Text = control.Text;
                    }
                    else if (control.GetType() == typeof(Button))
                    {
                        newControl = new AnswerButton(i, new int[] { alternativePairs[i][0].index, alternativePairs[i][1].index });
                        newControl.BackColor = control.BackColor;
                        newControl.ForeColor = control.ForeColor;
                        newControl.Text = control.Text;

                        (newControl as AnswerButton).OnAnswerClick += OnAnswerButtonClicked;
                    }
                    else if(control.GetType() == typeof(CheckedListBox))
                    {
                        newControl = new CheckedListBox();
                        (newControl as CheckedListBox).Items.Clear();

                        for (int j = 0; j < alternativePairs[i].Length; j++)
                        {
                            (newControl as CheckedListBox).Items.Add(alternativePairs[i][j].description);
                        }
                    }

                    newControl.Location = control.Location;
                    newControl.Size = control.Size;
                    newControl.Font = control.Font;

                    panel.Controls.Add(newControl);
                }

                pollFlowLayoutPanel.Controls.Add(panel);
            }

            pollFlowLayoutPanel.Controls.RemoveAt(0);
            var controls = pollFlowLayoutPanel.Controls;
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

            matrixDisplay.Text = matrix.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
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
        private void CheckAnswer(object sender, EventArgs e)
        {
            //var senderObject = (Button)sender;
            //int buttonTag = Convert.ToInt32(senderObject.Tag);

            //if (questionNumber != totalQuestion)
            //{
            //    //method.Z[]
            //    questionNumber++;
            //    AskQuestion(questionNumber);
            //}
            //if(questionNumber == totalQuestion)
            //{
            //    MessageBox.Show("Спасибо за пройденный опрос!");
            //    ExpertForm expert = new ExpertForm();
            //    expert.Closed += (s, args) => Show();
            //    expert.Show();
            //    Hide();
            //}
        }
        private void ShowQuestion(Alternative alternative0, Alternative alternative1)
        {

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

        private void answersCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            answerButton.Enabled = answersCheckedListBox.CheckedItems.Count != 0;


        }
    }
}
