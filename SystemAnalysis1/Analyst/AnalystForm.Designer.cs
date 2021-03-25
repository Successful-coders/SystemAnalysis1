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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.problemsLabel = new System.Windows.Forms.Label();
            this.addProblemButton = new System.Windows.Forms.Button();
            this.removeProblemButton = new System.Windows.Forms.Button();
            this.editProblemButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.problemsGrid = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.problemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // problemsLabel
            // 
            this.problemsLabel.AutoSize = true;
            this.problemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemsLabel.Location = new System.Drawing.Point(13, 33);
            this.problemsLabel.Name = "problemsLabel";
            this.problemsLabel.Size = new System.Drawing.Size(151, 29);
            this.problemsLabel.TabIndex = 0;
            this.problemsLabel.Text = "Проблемы:";
            // 
            // addProblemButton
            // 
            this.addProblemButton.BackColor = System.Drawing.Color.SeaGreen;
            this.addProblemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProblemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProblemButton.Location = new System.Drawing.Point(12, 677);
            this.addProblemButton.Name = "addProblemButton";
            this.addProblemButton.Size = new System.Drawing.Size(417, 51);
            this.addProblemButton.TabIndex = 2;
            this.addProblemButton.Text = "Добавить проблему";
            this.addProblemButton.UseVisualStyleBackColor = false;
            this.addProblemButton.Click += new System.EventHandler(this.addProblemButton_Click);
            // 
            // removeProblemButton
            // 
            this.removeProblemButton.BackColor = System.Drawing.Color.Brown;
            this.removeProblemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProblemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeProblemButton.Location = new System.Drawing.Point(906, 677);
            this.removeProblemButton.Name = "removeProblemButton";
            this.removeProblemButton.Size = new System.Drawing.Size(413, 51);
            this.removeProblemButton.TabIndex = 2;
            this.removeProblemButton.Text = "Удалить проблему";
            this.removeProblemButton.UseVisualStyleBackColor = false;
            this.removeProblemButton.Click += new System.EventHandler(this.removeProblemButton_Click);
            // 
            // editProblemButton
            // 
            this.editProblemButton.BackColor = System.Drawing.Color.SteelBlue;
            this.editProblemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProblemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editProblemButton.Location = new System.Drawing.Point(435, 677);
            this.editProblemButton.Name = "editProblemButton";
            this.editProblemButton.Size = new System.Drawing.Size(465, 51);
            this.editProblemButton.TabIndex = 3;
            this.editProblemButton.Text = "Изменить проблему";
            this.editProblemButton.UseVisualStyleBackColor = false;
            this.editProblemButton.Click += new System.EventHandler(this.editProblemButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Maroon;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quitButton.Location = new System.Drawing.Point(1191, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(128, 47);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Выйти";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // problemsGrid
            // 
            this.problemsGrid.AllowUserToAddRows = false;
            this.problemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.problemsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.problemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.problemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.name,
            this.status});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.problemsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.problemsGrid.Location = new System.Drawing.Point(12, 65);
            this.problemsGrid.Name = "problemsGrid";
            this.problemsGrid.RowHeadersVisible = false;
            this.problemsGrid.RowTemplate.Height = 30;
            this.problemsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.problemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.problemsGrid.Size = new System.Drawing.Size(1307, 597);
            this.problemsGrid.TabIndex = 5;
            this.problemsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.problemsGrid_CellDoubleClick);
            this.problemsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.problemsGrid_KeyDown);
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Index.DividerWidth = 2;
            this.Index.Frozen = true;
            this.Index.HeaderText = "№";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // AnalystForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 740);
            this.Controls.Add(this.problemsGrid);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.editProblemButton);
            this.Controls.Add(this.removeProblemButton);
            this.Controls.Add(this.addProblemButton);
            this.Controls.Add(this.problemsLabel);
            this.Name = "AnalystForm";
            this.Text = "Рабочее пространство аналитика";
            this.Activated += new System.EventHandler(this.AnalystForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.problemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label problemsLabel;
        private System.Windows.Forms.Button addProblemButton;
        private System.Windows.Forms.Button removeProblemButton;
        private System.Windows.Forms.Button editProblemButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.DataGridView problemsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}