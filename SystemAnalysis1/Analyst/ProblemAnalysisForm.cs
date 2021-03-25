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
    public partial class ProblemAnalysisForm : Form
    {
        private Problem problem;


        public ProblemAnalysisForm(Problem problem)
        {
            InitializeComponent();

            this.problem = problem;

            problemDescriptionTextBox.Text = problem.description;
        }


        private void addItemButton_Click(object sender, EventArgs e)
        {

        }
        private void removeItemButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            problem.description = problemDescriptionTextBox.Text;

            Close();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProblemAnalysisForm_Activated(object sender, EventArgs e)
        {
            InitAlternativeListView(problem.alternatives);
        }
        private void InitAlternativeListView(List<Alternative> alternatives)
        {
            alternativesGrid.Rows.Clear();

            for (int i = 0; i < alternatives.Count; i++)
            {
                alternativesGrid.Rows.Add(new string[] { i.ToString(), alternatives[i].description });
            }
        }
    }
}
