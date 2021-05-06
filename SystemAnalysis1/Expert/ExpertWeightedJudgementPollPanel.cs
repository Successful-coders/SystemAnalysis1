using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis1
{
    class ExpertWeightedJudgementPollPanel : Panel
    {
        private Label indexLabel;
        private Label allternativeLabel;
        private Label estimateLabel;
        private NumericUpDown estimateNumeric;

        private int lastEstimate = 0;

        private Color defaultColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        private Color answeredColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));


        public delegate void OnAnsweredHandler(int questionIndex, int value);


        public ExpertWeightedJudgementPollPanel(int index, Alternative alternative, OnAnsweredHandler answeredHandler) : base()
        {
            BackColor = defaultColor;
            Location = new Point(3, 3);
            Name = "pollPanel";
            Size = new Size(759, 125);
            TabIndex = 14;
            // 
            // indexLabel
            // 
            indexLabel = new Label();
            indexLabel.AutoSize = true;
            indexLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            indexLabel.Location = new Point(3, 12);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new Size(25, 24);
            indexLabel.TabIndex = 14;
            indexLabel.Tag = "index";
            indexLabel.Text = index + ".";
            // 
            // allternativeLabel
            // 
            allternativeLabel = new Label();
            allternativeLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            allternativeLabel.Location = new Point(44, 12);
            allternativeLabel.Name = "allternativeLabel";
            allternativeLabel.Size = new Size(553, 51);
            allternativeLabel.TabIndex = 12;
            allternativeLabel.Text = alternative.description;
            // 
            // estimateLabel
            // 
            estimateLabel = new Label();
            estimateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            estimateLabel.Location = new Point(652, 0);
            estimateLabel.Name = "estimateLabel";
            estimateLabel.Size = new Size(107, 34);
            estimateLabel.TabIndex = 19;
            estimateLabel.Text = "Оценка:";
            estimateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // estimateNumeric
            // 
            estimateNumeric = new NumericUpDown();
            estimateNumeric.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            estimateNumeric.Location = new Point(652, 37);
            estimateNumeric.Name = "estimateNumeric";
            estimateNumeric.Size = new Size(104, 26);
            estimateNumeric.TabIndex = 18;
            estimateNumeric.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            estimateNumeric.ValueChanged += (sender, e) => answeredHandler?.Invoke(index, (int)estimateNumeric.Value);
            estimateNumeric.Maximum = ExpertWeightedJudgementTest.pointsRemaining;
            //
            Controls.Add(indexLabel);
            Controls.Add(allternativeLabel);
            Controls.Add(estimateLabel);
            Controls.Add(estimateNumeric);
        }
        public ExpertWeightedJudgementPollPanel(int index, Alternative alternative, OnAnsweredHandler clickedHandler, Matrix matrix)
            : this(index, alternative, clickedHandler)
        {
            int value = (int)Math.Round(matrix.values[0, index] * ExpertWeightedJudgementTest.MAX_POINTS, MidpointRounding.AwayFromZero);
            estimateNumeric.Value = value;

            if (value == 0)
            {
                BackColor = defaultColor;
            }
            else
            {
                BackColor = answeredColor;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int estimateValue = (int)estimateNumeric.Value;

            BackColor = answeredColor;

            ExpertWeightedJudgementTest.pointsRemaining -= (estimateValue - lastEstimate);

            estimateNumeric.Maximum = estimateValue + ExpertWeightedJudgementTest.pointsRemaining;

            lastEstimate = estimateValue;
        }


        public int EstimateMax
        { 
            get
            {
                return (int)estimateNumeric.Maximum;
            }
            set
            {
                estimateNumeric.Maximum = value;
            }
        }
        public int EstimateValue => (int)estimateNumeric.Value;
    }
}
