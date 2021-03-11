namespace SystemAnalysis1
{
    partial class ExpertText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpertText));
            this.Problem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.answerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.answersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Problem
            // 
            this.Problem.BackColor = System.Drawing.SystemColors.Info;
            this.Problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Problem.Location = new System.Drawing.Point(12, 58);
            this.Problem.Name = "Problem";
            this.Problem.Size = new System.Drawing.Size(554, 80);
            this.Problem.TabIndex = 5;
            this.Problem.Text = resources.GetString("Problem.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(227, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Проблема:";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(447, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(119, 32);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выйти из опроса";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.Chocolate;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.answerButton.Location = new System.Drawing.Point(15, 279);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(551, 42);
            this.answerButton.TabIndex = 9;
            this.answerButton.Tag = "1";
            this.answerButton.Text = "Ответить";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Какой вариант по Вашему мнению наиболее удачный?";
            // 
            // answersCheckedListBox
            // 
            this.answersCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answersCheckedListBox.FormattingEnabled = true;
            this.answersCheckedListBox.Items.AddRange(new object[] {
            "Первый вариант",
            "Второй вариант"});
            this.answersCheckedListBox.Location = new System.Drawing.Point(15, 206);
            this.answersCheckedListBox.Name = "answersCheckedListBox";
            this.answersCheckedListBox.Size = new System.Drawing.Size(551, 67);
            this.answersCheckedListBox.TabIndex = 13;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 332);
            this.Controls.Add(this.answersCheckedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Name = "Test";
            this.Text = "Опрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Problem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox answersCheckedListBox;
    }
}