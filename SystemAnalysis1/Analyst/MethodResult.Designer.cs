namespace SystemAnalysis1
{
    partial class MethodResult
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
            this.problemNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.problemDescriptionLabel = new System.Windows.Forms.Label();
            this.problemNameText = new System.Windows.Forms.Label();
            this.problemDescriptionText = new System.Windows.Forms.Label();
            this.PairComparisonList = new System.Windows.Forms.ListView();
            this.alternativeIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alternativeDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alternativeWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // problemNameLabel
            // 
            this.problemNameLabel.AutoSize = true;
            this.problemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemNameLabel.Location = new System.Drawing.Point(12, 60);
            this.problemNameLabel.Name = "problemNameLabel";
            this.problemNameLabel.Size = new System.Drawing.Size(186, 20);
            this.problemNameLabel.TabIndex = 21;
            this.problemNameLabel.Text = "Название проблемы:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.backButton.Location = new System.Drawing.Point(1398, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 31);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // problemDescriptionLabel
            // 
            this.problemDescriptionLabel.AutoSize = true;
            this.problemDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemDescriptionLabel.Location = new System.Drawing.Point(12, 121);
            this.problemDescriptionLabel.Name = "problemDescriptionLabel";
            this.problemDescriptionLabel.Size = new System.Drawing.Size(186, 20);
            this.problemDescriptionLabel.TabIndex = 18;
            this.problemDescriptionLabel.Text = "Описание проблемы:";
            // 
            // problemNameText
            // 
            this.problemNameText.AutoSize = true;
            this.problemNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemNameText.Location = new System.Drawing.Point(204, 60);
            this.problemNameText.Name = "problemNameText";
            this.problemNameText.Size = new System.Drawing.Size(164, 20);
            this.problemNameText.TabIndex = 22;
            this.problemNameText.Text = "Название проблемы";
            // 
            // problemDescriptionText
            // 
            this.problemDescriptionText.AutoSize = true;
            this.problemDescriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemDescriptionText.Location = new System.Drawing.Point(204, 121);
            this.problemDescriptionText.Name = "problemDescriptionText";
            this.problemDescriptionText.Size = new System.Drawing.Size(164, 20);
            this.problemDescriptionText.TabIndex = 23;
            this.problemDescriptionText.Text = "Описание проблемы";
            // 
            // PairComparisonList
            // 
            this.PairComparisonList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.alternativeIndex,
            this.alternativeDescription,
            this.alternativeWeight});
            this.PairComparisonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PairComparisonList.HideSelection = false;
            this.PairComparisonList.Location = new System.Drawing.Point(36, 190);
            this.PairComparisonList.Name = "PairComparisonList";
            this.PairComparisonList.Size = new System.Drawing.Size(352, 436);
            this.PairComparisonList.TabIndex = 24;
            this.PairComparisonList.UseCompatibleStateImageBehavior = false;
            this.PairComparisonList.View = System.Windows.Forms.View.Details;
            this.PairComparisonList.Visible = false;
            // 
            // alternativeIndex
            // 
            this.alternativeIndex.Text = "№";
            this.alternativeIndex.Width = 32;
            // 
            // alternativeDescription
            // 
            this.alternativeDescription.Text = "Альтерантива";
            this.alternativeDescription.Width = 238;
            // 
            // alternativeWeight
            // 
            this.alternativeWeight.Text = "Вес";
            this.alternativeWeight.Width = 164;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Метод парных сравнений";
            // 
            // MethodResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PairComparisonList);
            this.Controls.Add(this.problemDescriptionText);
            this.Controls.Add(this.problemNameText);
            this.Controls.Add(this.problemNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.problemDescriptionLabel);
            this.Name = "MethodResult";
            this.Text = "Результаты анализа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label problemNameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label problemDescriptionLabel;
        private System.Windows.Forms.Label problemNameText;
        private System.Windows.Forms.Label problemDescriptionText;
        private System.Windows.Forms.ListView PairComparisonList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader alternativeIndex;
        private System.Windows.Forms.ColumnHeader alternativeDescription;
        private System.Windows.Forms.ColumnHeader alternativeWeight;
    }
}