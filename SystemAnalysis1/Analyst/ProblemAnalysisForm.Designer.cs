namespace SystemAnalysis1
{
    partial class ProblemAnalysisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.problemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.alternativesTab = new System.Windows.Forms.TabPage();
            this.expertsTab = new System.Windows.Forms.TabPage();
            this.expertsListView = new System.Windows.Forms.ListView();
            this.expertNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Competence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.alternativesGrid = new System.Windows.Forms.DataGridView();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.additemButton = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.alternativesTab.SuspendLayout();
            this.expertsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alternativesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Описание проблемы:";
            // 
            // problemDescriptionTextBox
            // 
            this.problemDescriptionTextBox.Location = new System.Drawing.Point(12, 68);
            this.problemDescriptionTextBox.Multiline = true;
            this.problemDescriptionTextBox.Name = "problemDescriptionTextBox";
            this.problemDescriptionTextBox.Size = new System.Drawing.Size(1307, 82);
            this.problemDescriptionTextBox.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.alternativesTab);
            this.tabControl.Controls.Add(this.expertsTab);
            this.tabControl.Location = new System.Drawing.Point(12, 178);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1307, 495);
            this.tabControl.TabIndex = 2;
            // 
            // alternativesTab
            // 
            this.alternativesTab.Controls.Add(this.alternativesGrid);
            this.alternativesTab.Controls.Add(this.removeItemButton);
            this.alternativesTab.Controls.Add(this.additemButton);
            this.alternativesTab.Location = new System.Drawing.Point(4, 22);
            this.alternativesTab.Name = "alternativesTab";
            this.alternativesTab.Padding = new System.Windows.Forms.Padding(3);
            this.alternativesTab.Size = new System.Drawing.Size(1299, 469);
            this.alternativesTab.TabIndex = 0;
            this.alternativesTab.Text = "Альтернативы";
            this.alternativesTab.UseVisualStyleBackColor = true;
            // 
            // expertsTab
            // 
            this.expertsTab.Controls.Add(this.expertsListView);
            this.expertsTab.Location = new System.Drawing.Point(4, 22);
            this.expertsTab.Name = "expertsTab";
            this.expertsTab.Padding = new System.Windows.Forms.Padding(3);
            this.expertsTab.Size = new System.Drawing.Size(1299, 469);
            this.expertsTab.TabIndex = 1;
            this.expertsTab.Text = "Эксперты";
            this.expertsTab.UseVisualStyleBackColor = true;
            // 
            // expertsListView
            // 
            this.expertsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expertNumber,
            this.name,
            this.Competence});
            this.expertsListView.FullRowSelect = true;
            this.expertsListView.GridLines = true;
            this.expertsListView.HideSelection = false;
            this.expertsListView.Location = new System.Drawing.Point(7, 7);
            this.expertsListView.Name = "expertsListView";
            this.expertsListView.Size = new System.Drawing.Size(751, 262);
            this.expertsListView.TabIndex = 10;
            this.expertsListView.UseCompatibleStateImageBehavior = false;
            this.expertsListView.View = System.Windows.Forms.View.Details;
            // 
            // expertNumber
            // 
            this.expertNumber.Text = "№";
            this.expertNumber.Width = 34;
            // 
            // name
            // 
            this.name.Text = "Ф.И.О.";
            this.name.Width = 287;
            // 
            // Competence
            // 
            this.Competence.Text = "Компетентность";
            this.Competence.Width = 405;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(12, 679);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(1307, 49);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 31);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // alternativesGrid
            // 
            this.alternativesGrid.AllowUserToAddRows = false;
            this.alternativesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alternativesGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alternativesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alternativesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alternativesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.alternativesGrid.Location = new System.Drawing.Point(7, 6);
            this.alternativesGrid.Name = "alternativesGrid";
            this.alternativesGrid.RowHeadersVisible = false;
            this.alternativesGrid.RowTemplate.Height = 30;
            this.alternativesGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.alternativesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alternativesGrid.Size = new System.Drawing.Size(1286, 406);
            this.alternativesGrid.TabIndex = 10;
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.Brown;
            this.removeItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeItemButton.Location = new System.Drawing.Point(660, 418);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(633, 45);
            this.removeItemButton.TabIndex = 7;
            this.removeItemButton.Text = "Удалить проблему";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // additemButton
            // 
            this.additemButton.BackColor = System.Drawing.Color.SeaGreen;
            this.additemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.additemButton.Location = new System.Drawing.Point(7, 418);
            this.additemButton.Name = "additemButton";
            this.additemButton.Size = new System.Drawing.Size(647, 45);
            this.additemButton.TabIndex = 8;
            this.additemButton.Text = "Добавить альтернативу";
            this.additemButton.UseVisualStyleBackColor = false;
            this.additemButton.Click += new System.EventHandler(this.addItemButton_Click);
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
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // ProblemAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 740);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.problemDescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ProblemAnalysisForm";
            this.Text = "Правка проблемы";
            this.Activated += new System.EventHandler(this.ProblemAnalysisForm_Activated);
            this.tabControl.ResumeLayout(false);
            this.alternativesTab.ResumeLayout(false);
            this.expertsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alternativesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problemDescriptionTextBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage alternativesTab;
        private System.Windows.Forms.TabPage expertsTab;
        private System.Windows.Forms.ListView expertsListView;
        private System.Windows.Forms.ColumnHeader expertNumber;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ColumnHeader Competence;
        private System.Windows.Forms.DataGridView alternativesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button additemButton;
    }
}