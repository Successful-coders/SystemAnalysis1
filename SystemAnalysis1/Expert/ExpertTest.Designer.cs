﻿namespace SystemAnalysis1
{
    partial class ExpertTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpertTest));
            this.Problem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.answerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.answersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.pollPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pollFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pollPanel.SuspendLayout();
            this.pollFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Problem
            // 
            this.Problem.BackColor = System.Drawing.SystemColors.Info;
            this.Problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Problem.Location = new System.Drawing.Point(12, 163);
            this.Problem.Name = "Problem";
            this.Problem.Size = new System.Drawing.Size(787, 80);
            this.Problem.TabIndex = 5;
            this.Problem.Text = resources.GetString("Problem.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Проблема:";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Location = new System.Drawing.Point(643, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 32);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выйти из опроса";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.Chocolate;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.answerButton.Location = new System.Drawing.Point(4, 144);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(784, 42);
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
            this.label2.Location = new System.Drawing.Point(76, 19);
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
            this.answersCheckedListBox.Location = new System.Drawing.Point(4, 50);
            this.answersCheckedListBox.Name = "answersCheckedListBox";
            this.answersCheckedListBox.Size = new System.Drawing.Size(784, 88);
            this.answersCheckedListBox.TabIndex = 13;
            // 
            // pollPanel
            // 
            this.pollPanel.Controls.Add(this.answersCheckedListBox);
            this.pollPanel.Controls.Add(this.answerButton);
            this.pollPanel.Controls.Add(this.label2);
            this.pollPanel.Location = new System.Drawing.Point(3, 3);
            this.pollPanel.Name = "pollPanel";
            this.pollPanel.Size = new System.Drawing.Size(759, 209);
            this.pollPanel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(787, 63);
            this.label3.TabIndex = 15;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pollFlowLayoutPanel
            // 
            this.pollFlowLayoutPanel.AutoScroll = true;
            this.pollFlowLayoutPanel.Controls.Add(this.pollPanel);
            this.pollFlowLayoutPanel.Location = new System.Drawing.Point(12, 259);
            this.pollFlowLayoutPanel.Name = "pollFlowLayoutPanel";
            this.pollFlowLayoutPanel.Size = new System.Drawing.Size(787, 530);
            this.pollFlowLayoutPanel.TabIndex = 16;
            // 
            // ExpertTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 801);
            this.Controls.Add(this.pollFlowLayoutPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Name = "ExpertTest";
            this.Text = "Экспертная оценка";
            this.pollPanel.ResumeLayout(false);
            this.pollPanel.PerformLayout();
            this.pollFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Problem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox answersCheckedListBox;
        private System.Windows.Forms.Panel pollPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel pollFlowLayoutPanel;
    }
}