namespace SystemAnalysis1
{
    partial class SignInForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SignInAsLabel = new System.Windows.Forms.Label();
            this.SignExpertButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SignAnalystButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(800, 57);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Приложение для работы с оцениванием проблемы";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInAsLabel
            // 
            this.SignInAsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SignInAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInAsLabel.Location = new System.Drawing.Point(0, 57);
            this.SignInAsLabel.Name = "SignInAsLabel";
            this.SignInAsLabel.Size = new System.Drawing.Size(800, 116);
            this.SignInAsLabel.TabIndex = 1;
            this.SignInAsLabel.Text = "Войти как:";
            this.SignInAsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SignExpertButton
            // 
            this.SignExpertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignExpertButton.ForeColor = System.Drawing.Color.Brown;
            this.SignExpertButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SignExpertButton.ImageIndex = 1;
            this.SignExpertButton.ImageList = this.imageList;
            this.SignExpertButton.Location = new System.Drawing.Point(180, 187);
            this.SignExpertButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.SignExpertButton.Name = "SignExpertButton";
            this.SignExpertButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.SignExpertButton.Size = new System.Drawing.Size(154, 156);
            this.SignExpertButton.TabIndex = 2;
            this.SignExpertButton.Text = "Эксперт";
            this.SignExpertButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SignExpertButton.UseVisualStyleBackColor = true;
            this.SignExpertButton.Click += new System.EventHandler(this.SignExpertButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ProfilePicture-01.png");
            this.imageList.Images.SetKeyName(1, "ProfilePicture-01.png");
            // 
            // SignAnalystButton
            // 
            this.SignAnalystButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignAnalystButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.SignAnalystButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SignAnalystButton.ImageIndex = 1;
            this.SignAnalystButton.ImageList = this.imageList;
            this.SignAnalystButton.Location = new System.Drawing.Point(450, 187);
            this.SignAnalystButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.SignAnalystButton.Name = "SignAnalystButton";
            this.SignAnalystButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.SignAnalystButton.Size = new System.Drawing.Size(154, 156);
            this.SignAnalystButton.TabIndex = 3;
            this.SignAnalystButton.Text = "Аналитик";
            this.SignAnalystButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SignAnalystButton.UseVisualStyleBackColor = true;
            this.SignAnalystButton.Click += new System.EventHandler(this.SignAnalystButton_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignAnalystButton);
            this.Controls.Add(this.SignExpertButton);
            this.Controls.Add(this.SignInAsLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "SignInForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SignInAsLabel;
        private System.Windows.Forms.Button SignExpertButton;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button SignAnalystButton;
    }
}

