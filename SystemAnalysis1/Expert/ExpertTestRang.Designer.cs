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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pollFlowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // 
            // pollFlowLayoutPanel
            // 
            this.pollFlowLayoutPanel.AutoScroll = true;
            this.pollFlowLayoutPanel.Controls.Add(this.panel1);
            this.pollFlowLayoutPanel.Location = new System.Drawing.Point(16, 296);
            this.pollFlowLayoutPanel.Name = "pollFlowLayoutPanel";
            this.pollFlowLayoutPanel.Size = new System.Drawing.Size(787, 448);
            this.pollFlowLayoutPanel.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 44);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(664, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Альтернатива 1";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}