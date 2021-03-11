namespace SystemAnalysis1
{
    partial class AnalystForm
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
            this.problemsLabel = new System.Windows.Forms.Label();
            this.probliemsListView = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addProblemButton = new System.Windows.Forms.Button();
            this.removeProblemButton = new System.Windows.Forms.Button();
            this.editProblemButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // problemsLabel
            // 
            this.problemsLabel.AutoSize = true;
            this.problemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemsLabel.Location = new System.Drawing.Point(13, 33);
            this.problemsLabel.Name = "problemsLabel";
            this.problemsLabel.Size = new System.Drawing.Size(102, 20);
            this.problemsLabel.TabIndex = 0;
            this.problemsLabel.Text = "Проблемы:";
            // 
            // probliemsListView
            // 
            this.probliemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.description,
            this.status});
            this.probliemsListView.FullRowSelect = true;
            this.probliemsListView.GridLines = true;
            this.probliemsListView.HideSelection = false;
            this.probliemsListView.Location = new System.Drawing.Point(13, 57);
            this.probliemsListView.MultiSelect = false;
            this.probliemsListView.Name = "probliemsListView";
            this.probliemsListView.Size = new System.Drawing.Size(775, 356);
            this.probliemsListView.TabIndex = 1;
            this.probliemsListView.UseCompatibleStateImageBehavior = false;
            this.probliemsListView.View = System.Windows.Forms.View.Details;
            this.probliemsListView.DoubleClick += new System.EventHandler(this.probliemsListView_DoubleClick);
            // 
            // number
            // 
            this.number.Text = "№";
            // 
            // description
            // 
            this.description.Text = "Описание";
            this.description.Width = 469;
            // 
            // status
            // 
            this.status.Text = "Статус";
            this.status.Width = 231;
            // 
            // addProblemButton
            // 
            this.addProblemButton.BackColor = System.Drawing.Color.SeaGreen;
            this.addProblemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProblemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProblemButton.Location = new System.Drawing.Point(12, 419);
            this.addProblemButton.Name = "addProblemButton";
            this.addProblemButton.Size = new System.Drawing.Size(154, 39);
            this.addProblemButton.TabIndex = 2;
            this.addProblemButton.Text = "Добавить";
            this.addProblemButton.UseVisualStyleBackColor = false;
            this.addProblemButton.Click += new System.EventHandler(this.addProblemButton_Click);
            // 
            // removeProblemButton
            // 
            this.removeProblemButton.BackColor = System.Drawing.Color.Brown;
            this.removeProblemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProblemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeProblemButton.Location = new System.Drawing.Point(376, 419);
            this.removeProblemButton.Name = "removeProblemButton";
            this.removeProblemButton.Size = new System.Drawing.Size(189, 39);
            this.removeProblemButton.TabIndex = 2;
            this.removeProblemButton.Text = "Удалить выделенное";
            this.removeProblemButton.UseVisualStyleBackColor = false;
            this.removeProblemButton.Click += new System.EventHandler(this.removeProblemButton_Click);
            // 
            // editProblemButton
            // 
            this.editProblemButton.BackColor = System.Drawing.Color.SteelBlue;
            this.editProblemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProblemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editProblemButton.Location = new System.Drawing.Point(172, 419);
            this.editProblemButton.Name = "editProblemButton";
            this.editProblemButton.Size = new System.Drawing.Size(198, 39);
            this.editProblemButton.TabIndex = 3;
            this.editProblemButton.Text = "Изменить выделенное";
            this.editProblemButton.UseVisualStyleBackColor = false;
            this.editProblemButton.Click += new System.EventHandler(this.editProblemButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Firebrick;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quitButton.Location = new System.Drawing.Point(714, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(74, 39);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Выйти";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // AnalystForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.editProblemButton);
            this.Controls.Add(this.removeProblemButton);
            this.Controls.Add(this.addProblemButton);
            this.Controls.Add(this.probliemsListView);
            this.Controls.Add(this.problemsLabel);
            this.Name = "AnalystForm";
            this.Text = "Рабочее пространство аналитика";
            this.Activated += new System.EventHandler(this.AnalystForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label problemsLabel;
        private System.Windows.Forms.ListView probliemsListView;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button addProblemButton;
        private System.Windows.Forms.Button removeProblemButton;
        private System.Windows.Forms.Button editProblemButton;
        private System.Windows.Forms.Button quitButton;
    }
}