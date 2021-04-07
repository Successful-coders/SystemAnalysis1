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
            this.quitButton = new System.Windows.Forms.Button();
            this.problemsGrid = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
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
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Maroon;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quitButton.Location = new System.Drawing.Point(1198, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(121, 39);
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
            this.status,
            this.deleteButton});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.problemsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.problemsGrid.Location = new System.Drawing.Point(12, 65);
            this.problemsGrid.MultiSelect = false;
            this.problemsGrid.Name = "problemsGrid";
            this.problemsGrid.RowHeadersVisible = false;
            this.problemsGrid.RowTemplate.Height = 30;
            this.problemsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.problemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.problemsGrid.Size = new System.Drawing.Size(1307, 663);
            this.problemsGrid.TabIndex = 5;
            this.problemsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.problemsGrid_CellClick);
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
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.Frozen = true;
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 627;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.status.Frozen = true;
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 550;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Frozen = true;
            this.deleteButton.HeaderText = "Удалить";
            this.deleteButton.MinimumWidth = 50;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ReadOnly = true;
            this.deleteButton.Text = "X";
            this.deleteButton.UseColumnTextForButtonValue = true;
            this.deleteButton.Width = 75;
            // 
            // AnalystForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 740);
            this.Controls.Add(this.problemsGrid);
            this.Controls.Add(this.quitButton);
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
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.DataGridView problemsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
    }
}