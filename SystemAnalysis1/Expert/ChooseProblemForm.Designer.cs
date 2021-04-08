namespace SystemAnalysis1
{
    partial class ChooseProblemForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.problemsList = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.problemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(776, 27);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Фамилия Имя Отчество";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете проблему для его экспертного анализа:";
            // 
            // problemsList
            // 
            this.problemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.problemName});
            this.problemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemsList.FullRowSelect = true;
            this.problemsList.HideSelection = false;
            this.problemsList.Location = new System.Drawing.Point(13, 95);
            this.problemsList.Name = "problemsList";
            this.problemsList.Size = new System.Drawing.Size(775, 343);
            this.problemsList.TabIndex = 2;
            this.problemsList.UseCompatibleStateImageBehavior = false;
            this.problemsList.View = System.Windows.Forms.View.Details;
            this.problemsList.DoubleClick += new System.EventHandler(this.problemsList_DoubleClick);
            // 
            // index
            // 
            this.index.Text = "№";
            this.index.Width = 34;
            // 
            // problemName
            // 
            this.problemName.Text = "Название проблемы";
            this.problemName.Width = 737;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.backButton.Location = new System.Drawing.Point(649, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 31);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChooseProblemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.problemsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Name = "ChooseProblemForm";
            this.Text = "Выбор проблемы";
            this.Activated += new System.EventHandler(this.ChooseProblemForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView problemsList;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.ColumnHeader problemName;
        private System.Windows.Forms.Button backButton;
    }
}