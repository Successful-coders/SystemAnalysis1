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
            this.label1 = new System.Windows.Forms.Label();
            this.problemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.alternativesTab = new System.Windows.Forms.TabPage();
            this.editItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.alternativesListView = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expertsTab = new System.Windows.Forms.TabPage();
            this.expertsListView = new System.Windows.Forms.ListView();
            this.expertNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.alternativesTab.SuspendLayout();
            this.expertsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Описание проблемы:";
            // 
            // problemDescriptionTextBox
            // 
            this.problemDescriptionTextBox.Location = new System.Drawing.Point(16, 34);
            this.problemDescriptionTextBox.Multiline = true;
            this.problemDescriptionTextBox.Name = "problemDescriptionTextBox";
            this.problemDescriptionTextBox.Size = new System.Drawing.Size(772, 82);
            this.problemDescriptionTextBox.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.alternativesTab);
            this.tabControl.Controls.Add(this.expertsTab);
            this.tabControl.Location = new System.Drawing.Point(16, 122);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(772, 301);
            this.tabControl.TabIndex = 2;
            // 
            // alternativesTab
            // 
            this.alternativesTab.Controls.Add(this.editItemButton);
            this.alternativesTab.Controls.Add(this.removeItemButton);
            this.alternativesTab.Controls.Add(this.addItemButton);
            this.alternativesTab.Controls.Add(this.alternativesListView);
            this.alternativesTab.Location = new System.Drawing.Point(4, 22);
            this.alternativesTab.Name = "alternativesTab";
            this.alternativesTab.Padding = new System.Windows.Forms.Padding(3);
            this.alternativesTab.Size = new System.Drawing.Size(764, 275);
            this.alternativesTab.TabIndex = 0;
            this.alternativesTab.Text = "Альтернативы";
            this.alternativesTab.UseVisualStyleBackColor = true;
            // 
            // editItemButton
            // 
            this.editItemButton.BackColor = System.Drawing.Color.SteelBlue;
            this.editItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editItemButton.Location = new System.Drawing.Point(167, 230);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(198, 39);
            this.editItemButton.TabIndex = 6;
            this.editItemButton.Text = "Изменить выделенное";
            this.editItemButton.UseVisualStyleBackColor = false;
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.Brown;
            this.removeItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeItemButton.Location = new System.Drawing.Point(371, 230);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(189, 39);
            this.removeItemButton.TabIndex = 4;
            this.removeItemButton.Text = "Удалить выделенное";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.SeaGreen;
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItemButton.Location = new System.Drawing.Point(7, 230);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(154, 39);
            this.addItemButton.TabIndex = 5;
            this.addItemButton.Text = "Добавить";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // alternativesListView
            // 
            this.alternativesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.description});
            this.alternativesListView.GridLines = true;
            this.alternativesListView.HideSelection = false;
            this.alternativesListView.Location = new System.Drawing.Point(7, 6);
            this.alternativesListView.Name = "alternativesListView";
            this.alternativesListView.Size = new System.Drawing.Size(751, 218);
            this.alternativesListView.TabIndex = 0;
            this.alternativesListView.UseCompatibleStateImageBehavior = false;
            this.alternativesListView.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "№";
            this.number.Width = 37;
            // 
            // description
            // 
            this.description.Text = "Описание";
            this.description.Width = 646;
            // 
            // expertsTab
            // 
            this.expertsTab.Controls.Add(this.expertsListView);
            this.expertsTab.Location = new System.Drawing.Point(4, 22);
            this.expertsTab.Name = "expertsTab";
            this.expertsTab.Padding = new System.Windows.Forms.Padding(3);
            this.expertsTab.Size = new System.Drawing.Size(764, 275);
            this.expertsTab.TabIndex = 1;
            this.expertsTab.Text = "Эксперты";
            this.expertsTab.UseVisualStyleBackColor = true;
            // 
            // expertsListView
            // 
            this.expertsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expertNumber,
            this.name});
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
            this.name.Width = 650;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(186, 436);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(382, 49);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ProblemAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.problemDescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ProblemAnalysisForm";
            this.Text = "Правка проблемы";
            this.tabControl.ResumeLayout(false);
            this.alternativesTab.ResumeLayout(false);
            this.expertsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problemDescriptionTextBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage alternativesTab;
        private System.Windows.Forms.TabPage expertsTab;
        private System.Windows.Forms.ListView alternativesListView;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ListView expertsListView;
        private System.Windows.Forms.ColumnHeader expertNumber;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Button saveButton;
    }
}