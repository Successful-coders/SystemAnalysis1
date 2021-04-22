using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis1
{
    class PollPanel : Panel
    {
        private Label indexLabel;
        private CheckedListBox answersCheckedListBox;
        private Label questionLabel;

        private Color defaultColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        private Color answeredColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));

        public delegate void OnClickedHandler(int questionIndex, int[] indexes, int checkedIndicesCount, int checkedAnswerIndex);
        public event OnClickedHandler OnAnswerClick;


        public PollPanel(int index, Alternative[] alternativePair, OnClickedHandler clickedHandler) : base()
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
            indexLabel.Name = "label4";
            indexLabel.Size = new Size(25, 24);
            indexLabel.TabIndex = 14;
            indexLabel.Tag = "index";
            indexLabel.Text = (index + 1).ToString() + ".";
            // 
            // answersCheckedListBox
            // 
            answersCheckedListBox = new CheckedListBox();
            answersCheckedListBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            answersCheckedListBox.FormattingEnabled = true;
            answersCheckedListBox.Location = new Point(4, 50);
            answersCheckedListBox.Name = "answersCheckedListBox";
            answersCheckedListBox.Size = new Size(752, 52);
            answersCheckedListBox.TabIndex = 13;
            answersCheckedListBox.CheckOnClick = true;
            answersCheckedListBox.ItemCheck += (sender, e) =>
            {
                BackColor = answeredColor;
                int checkedIndicesCount = answersCheckedListBox.CheckedItems.Count;
                if (e.NewValue == CheckState.Unchecked)
                {
                    checkedIndicesCount--;
                }
                else if (e.NewValue == CheckState.Checked)
                {
                    checkedIndicesCount++;
                }

                clickedHandler?.Invoke(index, new int[] { alternativePair[0].index, alternativePair[1].index }, checkedIndicesCount, e.Index);
            };
            answersCheckedListBox.Items.Clear();
            for (int j = 0; j < alternativePair.Length; j++)
            {
                answersCheckedListBox.Items.Add(alternativePair[j].description);
            }
            // 
            // questionLabel
            // 
            questionLabel = new Label();
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            questionLabel.Location = new Point(44, 12);
            questionLabel.Name = "label2";
            questionLabel.Size = new Size(524, 22);
            questionLabel.TabIndex = 12;
            questionLabel.Text = "Какой вариант по Вашему мнению наиболее удачный?";
            //
            Controls.Add(indexLabel);
            Controls.Add(answersCheckedListBox);
            Controls.Add(questionLabel);
        }
        public PollPanel(int index, Alternative[] alternativePair, OnClickedHandler clickedHandler, Matrix matrix)
            : this(index, alternativePair, clickedHandler)
        {
            BackColor = answeredColor;

            if (Math.Abs(matrix.values[alternativePair[0].index, alternativePair[1].index] - 1.0d) < 0.01)
            {
                answersCheckedListBox.SetItemChecked(0, true);
            }
            else if (Math.Abs(matrix.values[alternativePair[1].index, alternativePair[0].index] - 1.0d) < 0.01)
            {
                answersCheckedListBox.SetItemChecked(1, true);
            }
            else if (Math.Abs(matrix.values[alternativePair[0].index, alternativePair[1].index] - 0.5d) < 0.01
                && Math.Abs(matrix.values[alternativePair[1].index, alternativePair[0].index] - 0.5d) < 0.01)
            {
                answersCheckedListBox.SetItemChecked(0, true);
                answersCheckedListBox.SetItemChecked(1, true);
            }
            else
            {
                BackColor = defaultColor;
            }
        }


        private void answersCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            answersCheckedListBox.ClearSelected();

            bool isListEmpty = answersCheckedListBox.CheckedItems.Count == 1 && e.NewValue == CheckState.Unchecked;
        }
    }
}
