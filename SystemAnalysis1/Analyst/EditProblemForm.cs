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
    public partial class EditProblemForm : Form
    {
        private Problem problem;


        public EditProblemForm(Problem problem)
        {
            InitializeComponent();

            this.problem = problem;
            descriptionTextBox.Text = problem.description;
            statusTextBox.Text = problem.status;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            problem.description = descriptionTextBox.Text;
            problem.status = statusTextBox.Text;

            Close();
        }
    }
}
