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


        private void SignExpertButton_Click(object sender, EventArgs e)
        {
            ExpertLogIn expertLogIn = new ExpertLogIn();
            expertLogIn.OnReterned += Show;
            expertLogIn.Show();

            Hide();
        }
        private void SignAnalystButton_Click(object sender, EventArgs e)
        {
            LoginForm analystSigninForm = new LoginForm(new AnalystForm(Data.problems));
            analystSigninForm.OnReterned += Show;
            analystSigninForm.Show();
			
            Hide();
        }
    }
}
