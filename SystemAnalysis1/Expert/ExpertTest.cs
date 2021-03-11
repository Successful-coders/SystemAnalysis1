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
    public partial class ExpertText : Form
    {
        private List<Alternative[]> alternativePairs;


        public ExpertText(List<Alternative> alternatives)
        {
            InitializeComponent();

            alternativePairs = InitQuestions(alternatives);
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
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
