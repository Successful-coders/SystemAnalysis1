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
    public partial class ExpertWeightedJudgementTest : Form
    {
        public const int MAX_POINTS = 100;


        private List<Alternative> alternatives;
        private Matrix matrix;
        private List<bool> isQuestionAnswereds = new List<bool>();
        
        public static int pointsRemaining = MAX_POINTS;


        public ExpertWeightedJudgementTest(List<Alternative> alternatives, Matrix matrix, Problem problem)
        {
            this.matrix = matrix;
            InitializeComponent();

            Problem.Text = problem.Description;

            this.alternatives = alternatives;
            CreatePollPanels();

            isQuestionAnswereds = new List<bool>(alternatives.Count);
            int pointsSum = 0;
            for (int i = 0; i < alternatives.Count; i++)
            {
                int value = (int)Math.Round(matrix.values[0, i] * MAX_POINTS, MidpointRounding.AwayFromZero);
                pointsSum += value;

                isQuestionAnswereds.Add(value != 0);
            }

            pointsRemaining = MAX_POINTS - pointsSum;

            completeButton.Visible = pointsSum == MAX_POINTS;
        }


        private void CreatePollPanels()
        {
            pollFlowLayoutPanel.Controls.RemoveAt(0);

            for (int i = 0; i < alternatives.Count; i++)
            {
                ExpertWeightedJudgementPollPanel panel = new ExpertWeightedJudgementPollPanel(i, alternatives[i], OnAnswered);
                panel.Location = new Point(10 * i, 10 * i);

                pollFlowLayoutPanel.Controls.Add(panel);
            }
        }
        private void OnAnswered(int questionIndex, int value)
        {
            if (pollFlowLayoutPanel.Controls.Count == 0)
                return;

            matrix.values[0, questionIndex] = (float)value / (float)MAX_POINTS;
            isQuestionAnswereds[questionIndex] = true;

            pointsCount.Text = pointsRemaining.ToString();

            foreach (ExpertWeightedJudgementPollPanel panel in pollFlowLayoutPanel.Controls)
            {
                panel.EstimateMax = panel.EstimateValue + pointsRemaining;
            }

            completeButton.Visible = pointsRemaining == 0;
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
