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
    public partial class ExpertTestPrefer : Form
    {
        private List<Alternative> alternatives;
        private Matrix matrix;
        private int[] questionAnswerCounts;


        public ExpertTestPrefer(List<Alternative> alternatives, Matrix matrix)
        {
            this.matrix = matrix;

            InitializeComponent();

            this.alternatives = alternatives;

            questionAnswerCounts = new int[alternatives.Count];
            for (int i = 0; i < alternatives.Count; i++)
            {
                int value = (int)Math.Round(matrix.values[0, i], MidpointRounding.AwayFromZero) - 1;

                if (value >= 0)
                {
                    questionAnswerCounts[value]++;
                }
            }

            completeButton.Visible = questionAnswerCounts.All(x => x == 1);

            CreatePollPanels();
        }


        private void CreatePollPanels()
        {
            pollFlowLayoutPanel.Controls.RemoveAt(0);

            for (int i = 0; i < alternatives.Count; i++)
            {
                ExpertPreferPollPanel panel = new ExpertPreferPollPanel(i, alternatives[i], OnAnswered, alternatives.Count, matrix);
                panel.Location = new Point(10 * i, 10 * i);

                pollFlowLayoutPanel.Controls.Add(panel);
            }
        }
        private void OnAnswered(int questionIndex, int value, int oldValue)
        {
            if (pollFlowLayoutPanel.Controls.Count == 0)
                return;

            matrix.values[0, questionIndex] = value;

            value--;
            oldValue--;
            if (oldValue >= 1)
            {
                questionAnswerCounts[oldValue]--;
            }
            questionAnswerCounts[value]++;

            foreach (var control in pollFlowLayoutPanel.Controls)
            {
                (control as ExpertPreferPollPanel).SetAnswered(true);
            }

            for (int i = 0; i < questionAnswerCounts.Length; i++)
            {
                if (questionAnswerCounts[i] > 1)
                {
                    foreach (var control in pollFlowLayoutPanel.Controls)
                    {
                        (control as ExpertPreferPollPanel).SetAnswered((control as ExpertPreferPollPanel).EstimateValue != i + 1);
                    }
                }
            }

            completeButton.Visible = questionAnswerCounts.All(x => x == 1);
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
