using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis1
{
    class ExpertRangPollPanel : Panel
    {
        private Label indexLabel;
        private Label allternativeLabel;
        private Label estimateLabel;
        private NumericUpDown estimateNumeric;

        private int lastEstimate = 0;
        private int questionIndex;
        private bool isAnswered;

        private Color defaultColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        private Color answeredColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
        private Color wrongAnswerColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));


        public delegate void OnAnsweredHandler(int questionIndex, int oldValue, int value);
        private OnAnsweredHandler answeredHandler;


        public ExpertRangPollPanel(int index, Alternative alternative, OnAnsweredHandler answeredHandler) : base()
        {
            questionIndex = index;
            this.answeredHandler = answeredHandler;

            BackColor = defaultColor;
            Location = new Point(3, 3);
            Name = "pollPanel";
            Size = new Size(759, 125);
            // 
            // indexLabel
            // 
            indexLabel = new Label();
            indexLabel.AutoSize = true;
            indexLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            indexLabel.Location = new Point(10, 14);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new Size(25, 24);
            indexLabel.TabIndex = 16;
            indexLabel.Tag = "index";
            indexLabel.Text = index + ".";
            // 
            // allternativeLabel
            // 
            allternativeLabel = new Label();
            allternativeLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            allternativeLabel.Location = new Point(51, 14);
            allternativeLabel.Name = "allternativeLabel";
            allternativeLabel.Size = new Size(568, 51);
            allternativeLabel.TabIndex = 15;
            allternativeLabel.Text = alternative.description;
            // 
            // estimateLabel
            // 
            estimateLabel = new Label();
            estimateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            estimateLabel.Location = new Point(649, 7);
            estimateLabel.Name = "estimateLabel";
            estimateLabel.Size = new Size(107, 34);
            estimateLabel.TabIndex = 21;
            estimateLabel.Text = "Оценка:";
            estimateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // estimateNumeric
            // 
            estimateNumeric = new NumericUpDown();
            estimateNumeric.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            estimateNumeric.Location = new Point(649, 44);
            estimateNumeric.Maximum = 10;
            estimateNumeric.Minimum = 0;
            estimateNumeric.Name = "estimateNumeric";
            estimateNumeric.Size = new Size(104, 26);
            estimateNumeric.TabIndex = 20;
            estimateNumeric.Value = 0;
            estimateNumeric.ValueChanged += estimateNumeric_ValueChanged;
            //
            Controls.Add(indexLabel);
            Controls.Add(allternativeLabel);
            Controls.Add(estimateLabel);
            Controls.Add(estimateNumeric);
        }
        public ExpertRangPollPanel(int index, Alternative alternative, OnAnsweredHandler clickedHandler, Matrix matrix)
            : this(index, alternative, clickedHandler)
        {
            int value = (int)Math.Round(matrix.values[0, index], MidpointRounding.AwayFromZero);

            if (value < estimateNumeric.Minimum)
            {
                BackColor = defaultColor;
            }
            else
            {
                estimateNumeric.Value = value;

                BackColor = answeredColor;
                isAnswered = true;
            }
        }


        public void SetAnswered(bool isAnswered)
        {
            if (!isAnswered)
            {
                BackColor = wrongAnswerColor;
            }
            else if (this.isAnswered)
            {
                BackColor = answeredColor;
            }
            else
            {
                BackColor = defaultColor;
            }
        }

        private void estimateNumeric_ValueChanged(object sender, EventArgs e)
        {
            isAnswered = true;

            BackColor = answeredColor;

            answeredHandler?.Invoke(questionIndex, (int)estimateNumeric.Value, lastEstimate);

            lastEstimate = (int)estimateNumeric.Value;
        }


        public int EstimateValue => (int)estimateNumeric.Value;
    }
}
