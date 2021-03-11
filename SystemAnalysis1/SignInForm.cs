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
            List<Alternative> testAlternatives = new List<Alternative>()
            {
                new Alternative("desc0"),
                new Alternative("desc1"),
                new Alternative("desc2"),
            };

            ExpertText expertText = new ExpertText(testAlternatives);
            expertText.Closed += (s, args) => Show();
            expertText.Show();

            Hide();
        }
        private void SignAnalystButton_Click(object sender, EventArgs e)
        {
            Close();
			
            LoginForm analystSigninForm = new LoginForm(new AnalystForm());
            analystSigninForm.Closed += (s, args) => Show();
            analystSigninForm.Show();
        }
    }
}
