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


        public ExpertTest(List<Alternative> alternatives)
        {
            InitializeComponent();

            alternativePairs = InitQuestions(alternatives);
            CreatePollPanels();
        }


        private void CreatePollPanels()
        {
            for (int i = 0; i < alternativePairs.Count; i++)
            {
                //Panel panel = new Panel();
                //panel.Location = new Point(10 * i, 10 * i);
                //panel.BorderStyle = panel1.BorderStyle;
                //panel.BackColor = panel1.BackColor;
                //panel.Size = panel1.Size;
                //panel.Visible = true;

                //foreach (Control c in panel1.Controls)
                //{
                //    Control c2 = new Control();
                //    if (c.GetType() == typeof(TextBox))
                //        c2 = new TextBox();
                //    if (c.GetType() == typeof(Label))
                //        c2 = new Label();
                //    if (c.GetType() == typeof(CheckBox))
                //        c2 = new CheckBox();
                //    if (c.GetType() == typeof(DataGridView))
                //        c2 = new DataGridView();
                //    c2.Location = c.Location;
                //    c2.Size = c.Size;
                //    c2.Text = c.Text;
                //    panel.Controls.Add(c2);
                //}

                pollFlowLayoutPanel.Controls.Add(pollFlowLayoutPanel.Controls[0]);
            }
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
                    alternativePairs[0][j] = result.ToList()[i].ToList()[j];
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
    }
}
