using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis1
{
    class ExpertFullPairPollPanel : Panel
    {
        private Label indexLabel;
        private Label descriptionLabel;
        private Label alternative0Label;
        private Label alternative1Label;
        private TrackBar trackBar;

        private int questionIndex;
        private bool isAnswered;
        private int lastValue;

        private Color defaultColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        private Color answeredColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
        private Color wrongAnswerColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));


        public delegate void OnAnsweredHandler(int questionIndex, int oldValue, int value);
        private OnAnsweredHandler answeredHandler;


        public ExpertFullPairPollPanel(int index, Alternative[] alternativePair, OnAnsweredHandler answeredHandler, int trackBarMaxValue) : base()
        {
            questionIndex = index;
            this.answeredHandler = answeredHandler;

            BackColor = defaultColor;
            Location = new Point(3, 3);
            Name = "pollPanel";
            Size = new Size(759, 161);
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
            // label2
            // 
            descriptionLabel = new Label();
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(44, 12);
            descriptionLabel.Name = "label2";
            descriptionLabel.Size = new System.Drawing.Size(524, 22);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Какой вариант по Вашему мнению наиболее удачный?";
            // 
            // trackBar1
            // 
            trackBar = new TrackBar();
            trackBar.Location = new System.Drawing.Point(4, 108);
            trackBar.Name = "trackBar";
            trackBar.Size = new System.Drawing.Size(752, 45);
            trackBar.TabIndex = 15;
            trackBar.Maximum = trackBarMaxValue;
            trackBar.Value = trackBar.Maximum / 2;
            trackBar.ValueChanged += trackBar_ValueChanged;
            // 
            // label5
            // 
            alternative0Label = new Label();
            alternative0Label.BackColor = System.Drawing.Color.White;
            alternative0Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            alternative0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            alternative0Label.Location = new System.Drawing.Point(4, 50);
            alternative0Label.Name = "alternative0Label";
            alternative0Label.Size = new System.Drawing.Size(375, 55);
            alternative0Label.TabIndex = 16;
            alternative0Label.Text = alternativePair[0].description;
            alternative0Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            alternative1Label = new Label();
            alternative1Label.BackColor = System.Drawing.Color.White;
            alternative1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            alternative1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            alternative1Label.Location = new System.Drawing.Point(382, 50);
            alternative1Label.Name = "alternative1Label";
            alternative1Label.Size = new System.Drawing.Size(374, 55);
            alternative1Label.TabIndex = 17;
            alternative1Label.Text = alternativePair[1].description;
            alternative1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            Controls.Add(indexLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(alternative0Label);
            Controls.Add(alternative1Label);
            Controls.Add(trackBar);
        }
        public ExpertFullPairPollPanel(int index, Alternative[] alternativePair, OnAnsweredHandler answeredHandler, int trackBarMaxValue, Matrix matrix)
            : this(index, alternativePair, answeredHandler, trackBarMaxValue)
        {
            int value = (int)Math.Round(matrix.values[alternativePair[0].index, alternativePair[1].index] * trackBarMaxValue,
                MidpointRounding.AwayFromZero);
            value = value > trackBarMaxValue ? trackBarMaxValue : value;
            value = value < 0 ? 0 : value;

            trackBar.Value = value;

            BackColor = answeredColor;
            isAnswered = true;
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

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            isAnswered = true;

            BackColor = answeredColor;

            answeredHandler?.Invoke(questionIndex, lastValue, trackBar.Value);

            lastValue = trackBar.Value;
        }
    }
}
