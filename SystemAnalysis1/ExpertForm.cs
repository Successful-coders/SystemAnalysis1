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
    public partial class ExpertForm : Form
    {
        public ExpertForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Closed += (s, args) => Show();
            signInForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Hide();
            Test test = new Test();
            test.Closed += (s, args) => Show();
            test.Show();
        }
    }
}
