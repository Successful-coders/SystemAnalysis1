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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.problemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.alternativesGrid = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeAlternativeButton = new System.Windows.Forms.Button();
            this.addAlternativeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expertsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeExpertsButton = new System.Windows.Forms.Button();
            this.addExpertButton = new System.Windows.Forms.Button();
            this.problemNameTextBox = new System.Windows.Forms.TextBox();
            this.problemNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alternativesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Описание проблемы:";
            // 
            // problemDescriptionTextBox
            // 
            this.problemDescriptionTextBox.Location = new System.Drawing.Point(12, 160);
            this.problemDescriptionTextBox.Multiline = true;
            this.problemDescriptionTextBox.Name = "problemDescriptionTextBox";
            this.problemDescriptionTextBox.Size = new System.Drawing.Size(1307, 48);
            this.problemDescriptionTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(12, 812);
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
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alternativesGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.alternativesGrid.Location = new System.Drawing.Point(12, 253);
            this.alternativesGrid.MultiSelect = false;
            this.alternativesGrid.Name = "alternativesGrid";
            this.alternativesGrid.RowHeadersVisible = false;
            this.alternativesGrid.RowTemplate.Height = 30;
            this.alternativesGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.alternativesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alternativesGrid.Size = new System.Drawing.Size(1307, 186);
            this.alternativesGrid.TabIndex = 10;
            this.alternativesGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.alternativesGrid_CellEndEdit);
            this.alternativesGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.alternativesGrid_KeyDown);
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
            // 
            // removeAlternativeButton
            // 
            this.removeAlternativeButton.BackColor = System.Drawing.Color.Brown;
            this.removeAlternativeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAlternativeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeAlternativeButton.Location = new System.Drawing.Point(670, 445);
            this.removeAlternativeButton.Name = "removeAlternativeButton";
            this.removeAlternativeButton.Size = new System.Drawing.Size(650, 45);
            this.removeAlternativeButton.TabIndex = 7;
            this.removeAlternativeButton.Text = "Удалить альтернативу";
            this.removeAlternativeButton.UseVisualStyleBackColor = false;
            this.removeAlternativeButton.Click += new System.EventHandler(this.removeAlternativeButton_Click);
            // 
            // addAlternativeButton
            // 
            this.addAlternativeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.addAlternativeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlternativeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addAlternativeButton.Location = new System.Drawing.Point(13, 445);
            this.addAlternativeButton.Name = "addAlternativeButton";
            this.addAlternativeButton.Size = new System.Drawing.Size(647, 45);
            this.addAlternativeButton.TabIndex = 8;
            this.addAlternativeButton.Text = "Добавить альтернативу";
            this.addAlternativeButton.UseVisualStyleBackColor = false;
            this.addAlternativeButton.Click += new System.EventHandler(this.addAlternativeButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1306, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Альтернативы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1307, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Эксперты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expertsGrid
            // 
            this.expertsGrid.AllowUserToAddRows = false;
            this.expertsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expertsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expertsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expertsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.name,
            this.Competence});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expertsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.expertsGrid.Location = new System.Drawing.Point(12, 533);
            this.expertsGrid.MultiSelect = false;
            this.expertsGrid.Name = "expertsGrid";
            this.expertsGrid.RowHeadersVisible = false;
            this.expertsGrid.RowTemplate.Height = 30;
            this.expertsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.expertsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expertsGrid.Size = new System.Drawing.Size(1307, 191);
            this.expertsGrid.TabIndex = 13;
            this.expertsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.expertsGrid_CellEndEdit);
            this.expertsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.expertsGrid_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DividerWidth = 2;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Ф.И.О.";
            this.name.Name = "name";
            // 
            // Competence
            // 
            this.Competence.HeaderText = "Компетентность";
            this.Competence.Name = "Competence";
            // 
            // removeExpertsButton
            // 
            this.removeExpertsButton.BackColor = System.Drawing.Color.Brown;
            this.removeExpertsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeExpertsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeExpertsButton.Location = new System.Drawing.Point(669, 730);
            this.removeExpertsButton.Name = "removeExpertsButton";
            this.removeExpertsButton.Size = new System.Drawing.Size(650, 45);
            this.removeExpertsButton.TabIndex = 14;
            this.removeExpertsButton.Text = "Исключить эксперта";
            this.removeExpertsButton.UseVisualStyleBackColor = false;
            this.removeExpertsButton.Click += new System.EventHandler(this.removeExpertsButton_Click);
            // 
            // addExpertButton
            // 
            this.addExpertButton.BackColor = System.Drawing.Color.SeaGreen;
            this.addExpertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpertButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addExpertButton.Location = new System.Drawing.Point(12, 730);
            this.addExpertButton.Name = "addExpertButton";
            this.addExpertButton.Size = new System.Drawing.Size(647, 45);
            this.addExpertButton.TabIndex = 15;
            this.addExpertButton.Text = "Добавить эксперта";
            this.addExpertButton.UseVisualStyleBackColor = false;
            this.addExpertButton.Click += new System.EventHandler(this.addExpertButton_Click);
            // 
            // problemNameTextBox
            // 
            this.problemNameTextBox.Location = new System.Drawing.Point(12, 86);
            this.problemNameTextBox.Multiline = true;
            this.problemNameTextBox.Name = "problemNameTextBox";
            this.problemNameTextBox.Size = new System.Drawing.Size(1307, 48);
            this.problemNameTextBox.TabIndex = 17;
            // 
            // problemNameLabel
            // 
            this.problemNameLabel.AutoSize = true;
            this.problemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemNameLabel.Location = new System.Drawing.Point(12, 63);
            this.problemNameLabel.Name = "problemNameLabel";
            this.problemNameLabel.Size = new System.Drawing.Size(181, 20);
            this.problemNameLabel.TabIndex = 16;
            this.problemNameLabel.Text = "Название проблемы";
            // 
            // ProblemAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 872);
            this.Controls.Add(this.problemNameTextBox);
            this.Controls.Add(this.problemNameLabel);
            this.Controls.Add(this.removeExpertsButton);
            this.Controls.Add(this.addExpertButton);
            this.Controls.Add(this.expertsGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alternativesGrid);
            this.Controls.Add(this.removeAlternativeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addAlternativeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.problemDescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ProblemAnalysisForm";
            this.Text = "Правка проблемы";
            this.Activated += new System.EventHandler(this.ProblemAnalysisForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.alternativesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problemDescriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView alternativesGrid;
        private System.Windows.Forms.Button removeAlternativeButton;
        private System.Windows.Forms.Button addAlternativeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView expertsGrid;
        private System.Windows.Forms.Button removeExpertsButton;
        private System.Windows.Forms.Button addExpertButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competence;
        private System.Windows.Forms.TextBox problemNameTextBox;
        private System.Windows.Forms.Label problemNameLabel;
    }
}