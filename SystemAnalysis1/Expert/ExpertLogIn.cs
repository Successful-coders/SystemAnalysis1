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
            Expert expert = null;

            foreach (var problem in Data.problems)
            {
                expert = problem.Experts.FirstOrDefault(x => x.name == expertName);
                if (expert != null)
                {
                    break;
                }
            }

            if (expert == null)
            {
                expert = new Expert(expertName, 1);
            }

            ChooseProblemForm chooseProblemForm = new ChooseProblemForm(expert);
            chooseProblemForm.Closed += (s, args) => Show();
            chooseProblemForm.Show();

            Hide();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            OnReterned?.Invoke();

            Close();
        }
    }
}
