using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis1
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }


        private void SingExpertButton_Click(object sender, EventArgs e)
        {
            Hide();
            ExpertSigninForm expertSigninForm = new ExpertSigninForm();
            expertSigninForm.Closed += (s, args) => Show();
            expertSigninForm.Show();
        }
        private void SignAnalystButton_Click(object sender, EventArgs e)
        {
            AnalystForm analystForm = new AnalystForm();
            analystForm.Show();
        }
    }
}
