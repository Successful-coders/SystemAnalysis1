namespace SystemAnalysis1
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.Problem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.or = new System.Windows.Forms.Label();
            this.AnswerFirst = new System.Windows.Forms.Button();
            this.AnswerSecond = new System.Windows.Forms.Button();
            this.AnswerSame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Problem
            // 
            this.Problem.AutoSize = true;
            this.Problem.BackColor = System.Drawing.SystemColors.Info;
            this.Problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Problem.Location = new System.Drawing.Point(150, 9);
            this.Problem.Name = "Problem";
            this.Problem.Size = new System.Drawing.Size(470, 80);
            this.Problem.TabIndex = 5;
            this.Problem.Text = resources.GetString("Problem.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Проблема:";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(648, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 22);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выйти из опроса";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.Location = new System.Drawing.Point(197, 171);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(108, 15);
            this.first.TabIndex = 6;
            this.first.Text = "Первый вариант ";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second.Location = new System.Drawing.Point(197, 235);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(105, 15);
            this.second.TabIndex = 7;
            this.second.Text = "Второй вариант ";
            this.second.Click += new System.EventHandler(this.second_Click);
            // 
            // or
            // 
            this.or.AutoSize = true;
            this.or.Location = new System.Drawing.Point(360, 202);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(25, 13);
            this.or.TabIndex = 8;
            this.or.Text = "или";
            // 
            // AnswerFirst
            // 
            this.AnswerFirst.Location = new System.Drawing.Point(153, 302);
            this.AnswerFirst.Name = "AnswerFirst";
            this.AnswerFirst.Size = new System.Drawing.Size(143, 57);
            this.AnswerFirst.TabIndex = 9;
            this.AnswerFirst.Tag = "1";
            this.AnswerFirst.Text = "Первый вариант";
            this.AnswerFirst.UseVisualStyleBackColor = true;
            this.AnswerFirst.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // AnswerSecond
            // 
            this.AnswerSecond.Location = new System.Drawing.Point(322, 302);
            this.AnswerSecond.Name = "AnswerSecond";
            this.AnswerSecond.Size = new System.Drawing.Size(143, 57);
            this.AnswerSecond.TabIndex = 10;
            this.AnswerSecond.Tag = "2";
            this.AnswerSecond.Text = "Второй вариант";
            this.AnswerSecond.UseVisualStyleBackColor = true;
            this.AnswerSecond.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // AnswerSame
            // 
            this.AnswerSame.Location = new System.Drawing.Point(477, 302);
            this.AnswerSame.Name = "AnswerSame";
            this.AnswerSame.Size = new System.Drawing.Size(143, 57);
            this.AnswerSame.TabIndex = 11;
            this.AnswerSame.Tag = "3";
            this.AnswerSame.Text = "Одинаково";
            this.AnswerSame.UseVisualStyleBackColor = true;
            this.AnswerSame.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(197, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Какой вариант по Вашему мнению наиболее удачный?";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerSame);
            this.Controls.Add(this.AnswerSecond);
            this.Controls.Add(this.AnswerFirst);
            this.Controls.Add(this.or);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Name = "Test";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Problem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label or;
        private System.Windows.Forms.Button AnswerFirst;
        private System.Windows.Forms.Button AnswerSecond;
        private System.Windows.Forms.Button AnswerSame;
        private System.Windows.Forms.Label label2;
    }
}