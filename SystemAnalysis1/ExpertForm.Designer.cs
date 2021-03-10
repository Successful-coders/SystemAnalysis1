namespace SystemAnalysis1
{
    partial class ExpertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpertForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Problem = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(697, 15);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 25);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Проблема:";
            // 
            // Problem
            // 
            this.Problem.AutoSize = true;
            this.Problem.BackColor = System.Drawing.SystemColors.Info;
            this.Problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Problem.Location = new System.Drawing.Point(139, 9);
            this.Problem.Name = "Problem";
            this.Problem.Size = new System.Drawing.Size(470, 80);
            this.Problem.TabIndex = 2;
            this.Problem.Text = resources.GetString("Problem.Text");
            this.Problem.Click += new System.EventHandler(this.label2_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.BackColor = System.Drawing.SystemColors.Control;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.Location = new System.Drawing.Point(138, 148);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(505, 60);
            this.Question.TabIndex = 3;
            this.Question.Text = "Вам необходимо пройти опрос, где будут представлены \r\nварианты решения данной про" +
    "блемы. \r\nВыберите наиболее удачный вариант решения проблемы.\r\n";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.Window;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(273, 233);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(257, 78);
            this.Start.TabIndex = 4;
            this.Start.Text = "Начать ";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ExpertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Name = "ExpertForm";
            this.Text = "ExpertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Problem;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button Start;
    }
}