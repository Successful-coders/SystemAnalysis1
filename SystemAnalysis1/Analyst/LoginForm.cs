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
    public partial class LoginForm : Form
    {
        private KeyValuePair<string, string> loginPassword = new KeyValuePair<string, string>("0", "0");
        private Form nextForm;


        public LoginForm(Form nextForm)
        {
            InitializeComponent();

            this.nextForm = nextForm;
        }


        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != loginPassword.Key)
            {
                MessageBox.Show("Такого пользователя не существует");
            }
            else if (passwordTextBox.Text != loginPassword.Value)
            {
                MessageBox.Show("Неправильно введён пароль");
            }
            else
            {
                Hide();
                nextForm.Show();
                nextForm.Closed += (s, args) => Close();
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
