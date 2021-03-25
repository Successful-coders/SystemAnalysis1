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
    public partial class ExpertLogIn : Form
    {
        public event Action OnReterned;


        public ExpertLogIn()
        {
            InitializeComponent();
        }


        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string expertName = nameTextBox.Text;

            Close();
            ChooseProblemForm chooseProblemForm = new ChooseProblemForm(expertName);
            chooseProblemForm.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            OnReterned?.Invoke();

            Close();
        }
    }
}
