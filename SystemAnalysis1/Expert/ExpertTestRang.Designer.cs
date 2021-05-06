namespace SystemAnalysis1
{
    partial class ExpertTestRang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpertTestRang));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Problem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.pollFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pollPanel = new System.Windows.Forms.Panel();
            this.estimateLabel = new System.Windows.Forms.Label();
            this.estimateNumeric = new System.Windows.Forms.NumericUpDown();
            this.indexLabel = new System.Windows.Forms.Label();
            this.allternativeLabel = new System.Windows.Forms.Label();
            this.pollFlowLayoutPanel.SuspendLayout();
            this.pollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estimateNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(809, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Цифра 10 присуждается наиболее удачному варианту. Цифра 0 наименее удачному.\r\n";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(787, 63);
            this.label3.TabIndex = 25;
            this.label3.Text = "В данной форме вам необходимо отметить наиболее удачный вариант. Цифра 10 присужд" +
    "ается той альтернативе, которую вы считаете наиболее удачной. Чем больше цифра, " +
    "тем менее предпочтительный вариант.\r\n ";
            // 
            // Problem
            // 
            this.Problem.BackColor = System.Drawing.SystemColors.Info;
            this.Problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Problem.Location = new System.Drawing.Point(23, 162);
            this.Problem.Name = "Problem";
            this.Problem.Size = new System.Drawing.Size(787, 80);
            this.Problem.TabIndex = 24;
            this.Problem.Text = resources.GetString("Problem.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Проблема:";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Location = new System.Drawing.Point(654, 11);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 32);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "Выйти из опроса";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // completeButton
            // 
            this.completeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.completeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.completeButton.Location = new System.Drawing.Point(16, 750);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(787, 48);
            this.completeButton.TabIndex = 29;
            this.completeButton.Text = "Завершить";
            this.completeButton.UseVisualStyleBackColor = false;
            this.completeButton.Visible = false;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // pollFlowLayoutPanel
            // 
            this.pollFlowLayoutPanel.AutoScroll = true;
            this.pollFlowLayoutPanel.Controls.Add(this.pollPanel);
            this.pollFlowLayoutPanel.Location = new System.Drawing.Point(16, 296);
            this.pollFlowLayoutPanel.Name = "pollFlowLayoutPanel";
            this.pollFlowLayoutPanel.Size = new System.Drawing.Size(787, 448);
            this.pollFlowLayoutPanel.TabIndex = 28;
            // 
            // pollPanel
            // 
            this.pollPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.pollPanel.Controls.Add(this.estimateLabel);
            this.pollPanel.Controls.Add(this.estimateNumeric);
            this.pollPanel.Controls.Add(this.indexLabel);
            this.pollPanel.Controls.Add(this.allternativeLabel);
            this.pollPanel.Location = new System.Drawing.Point(3, 3);
            this.pollPanel.Name = "pollPanel";
            this.pollPanel.Size = new System.Drawing.Size(759, 76);
            this.pollPanel.TabIndex = 22;
            this.pollPanel.Visible = false;
            // 
            // estimateLabel
            // 
            this.estimateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimateLabel.Location = new System.Drawing.Point(649, 7);
            this.estimateLabel.Name = "estimateLabel";
            this.estimateLabel.Size = new System.Drawing.Size(107, 34);
            this.estimateLabel.TabIndex = 21;
            this.estimateLabel.Text = "Оценка:";
            this.estimateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // estimateNumeric
            // 
            this.estimateNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimateNumeric.Location = new System.Drawing.Point(649, 44);
            this.estimateNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.estimateNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.estimateNumeric.Name = "estimateNumeric";
            this.estimateNumeric.Size = new System.Drawing.Size(104, 26);
            this.estimateNumeric.TabIndex = 20;
            this.estimateNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexLabel.Location = new System.Drawing.Point(10, 14);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(25, 24);
            this.indexLabel.TabIndex = 16;
            this.indexLabel.Tag = "index";
            this.indexLabel.Text = "1.";
            // 
            // allternativeLabel
            // 
            this.allternativeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allternativeLabel.Location = new System.Drawing.Point(51, 14);
            this.allternativeLabel.Name = "allternativeLabel";
            this.allternativeLabel.Size = new System.Drawing.Size(568, 51);
            this.allternativeLabel.TabIndex = 15;
            this.allternativeLabel.Text = "Альтернатива 1";
            // 
            // ExpertTestRang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 810);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.pollFlowLayoutPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Name = "ExpertTestRang";
            this.Text = "ExpertTestRang";
            this.pollFlowLayoutPanel.ResumeLayout(false);
            this.pollPanel.ResumeLayout(false);
            this.pollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estimateNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Problem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.FlowLayoutPanel pollFlowLayoutPanel;
        private System.Windows.Forms.Panel pollPanel;
        private System.Windows.Forms.Label estimateLabel;
        private System.Windows.Forms.NumericUpDown estimateNumeric;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label allternativeLabel;
    }
}