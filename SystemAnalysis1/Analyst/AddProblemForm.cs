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
    public partial class AddProblemForm : Form
    {
        private List<Problem> problems;


        public AddProblemForm(List<Problem> problems)
        {
            InitializeComponent();

            this.problems = problems;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            problems.Add(new Problem(descriptionTextBox.Text, "Не задействовано"));
            Close();
        }
    }
}
