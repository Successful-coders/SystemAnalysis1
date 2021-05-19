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
            this.method2LIstView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.method2Label = new System.Windows.Forms.Label();
            this.alternativesListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.preferMethodListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.rangMethodListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.pairComprasionExpertListview = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
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
            this.backButton.Location = new System.Drawing.Point(12, 12);
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
            this.PairComparisonList.Location = new System.Drawing.Point(298, 190);
            this.PairComparisonList.Name = "PairComparisonList";
            this.PairComparisonList.Size = new System.Drawing.Size(352, 436);
            this.PairComparisonList.TabIndex = 24;
            this.PairComparisonList.UseCompatibleStateImageBehavior = false;
            this.PairComparisonList.View = System.Windows.Forms.View.Details;
            this.PairComparisonList.Visible = false;
            // 
            // alternativeIndex
            // 
            this.alternativeIndex.Text = "Ранг";
            this.alternativeIndex.Width = 56;
            // 
            // alternativeDescription
            // 
            this.alternativeDescription.Text = "Альтерантива";
            this.alternativeDescription.Width = 215;
            // 
            // alternativeWeight
            // 
            this.alternativeWeight.Text = "Вес";
            this.alternativeWeight.Width = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Метод парных сравнений";
            // 
            // method2LIstView
            // 
            this.method2LIstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.method2LIstView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.method2LIstView.HideSelection = false;
            this.method2LIstView.Location = new System.Drawing.Point(660, 190);
            this.method2LIstView.Name = "method2LIstView";
            this.method2LIstView.Size = new System.Drawing.Size(352, 436);
            this.method2LIstView.TabIndex = 30;
            this.method2LIstView.UseCompatibleStateImageBehavior = false;
            this.method2LIstView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ранг";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Альтерантива";
            this.columnHeader2.Width = 245;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Вес";
            this.columnHeader3.Width = 70;
            // 
            // method2Label
            // 
            this.method2Label.AutoSize = true;
            this.method2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method2Label.Location = new System.Drawing.Point(656, 167);
            this.method2Label.Name = "method2Label";
            this.method2Label.Size = new System.Drawing.Size(237, 20);
            this.method2Label.TabIndex = 31;
            this.method2Label.Text = "Метод взвешенных оценок";
            // 
            // alternativesListView
            // 
            this.alternativesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.alternativesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alternativesListView.HideSelection = false;
            this.alternativesListView.Location = new System.Drawing.Point(16, 190);
            this.alternativesListView.Name = "alternativesListView";
            this.alternativesListView.Size = new System.Drawing.Size(276, 436);
            this.alternativesListView.TabIndex = 32;
            this.alternativesListView.UseCompatibleStateImageBehavior = false;
            this.alternativesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Альтерантива";
            this.columnHeader5.Width = 242;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Исходные альтернативы";
            // 
            // preferMethodListView
            // 
            this.preferMethodListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.preferMethodListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preferMethodListView.HideSelection = false;
            this.preferMethodListView.Location = new System.Drawing.Point(1018, 190);
            this.preferMethodListView.Name = "preferMethodListView";
            this.preferMethodListView.Size = new System.Drawing.Size(352, 436);
            this.preferMethodListView.TabIndex = 34;
            this.preferMethodListView.UseCompatibleStateImageBehavior = false;
            this.preferMethodListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ранг";
            this.columnHeader6.Width = 32;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Альтерантива";
            this.columnHeader7.Width = 245;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Вес";
            this.columnHeader8.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1014, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Метод предпочтений";
            // 
            // rangMethodListView
            // 
            this.rangMethodListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.rangMethodListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangMethodListView.HideSelection = false;
            this.rangMethodListView.Location = new System.Drawing.Point(1376, 190);
            this.rangMethodListView.Name = "rangMethodListView";
            this.rangMethodListView.Size = new System.Drawing.Size(352, 436);
            this.rangMethodListView.TabIndex = 36;
            this.rangMethodListView.UseCompatibleStateImageBehavior = false;
            this.rangMethodListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ранг";
            this.columnHeader9.Width = 32;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Альтерантива";
            this.columnHeader10.Width = 245;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Вес";
            this.columnHeader11.Width = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1372, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Метод ранга";
            // 
            // pairComprasionExpertListview
            // 
            this.pairComprasionExpertListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.pairComprasionExpertListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pairComprasionExpertListview.HideSelection = false;
            this.pairComprasionExpertListview.Location = new System.Drawing.Point(1747, 190);
            this.pairComprasionExpertListview.Name = "pairComprasionExpertListview";
            this.pairComprasionExpertListview.Size = new System.Drawing.Size(352, 436);
            this.pairComprasionExpertListview.TabIndex = 38;
            this.pairComprasionExpertListview.UseCompatibleStateImageBehavior = false;
            this.pairComprasionExpertListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ранг";
            this.columnHeader12.Width = 32;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Альтерантива";
            this.columnHeader13.Width = 245;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Вес";
            this.columnHeader14.Width = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1752, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Метод попарного сопоставления";
            // 
            // MethodResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1413, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pairComprasionExpertListview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rangMethodListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preferMethodListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alternativesListView);
            this.Controls.Add(this.method2Label);
            this.Controls.Add(this.method2LIstView);
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
        private System.Windows.Forms.ListView method2LIstView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label method2Label;
        private System.Windows.Forms.ListView alternativesListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView preferMethodListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView rangMethodListView;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView pairComprasionExpertListview;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label5;
    }
}