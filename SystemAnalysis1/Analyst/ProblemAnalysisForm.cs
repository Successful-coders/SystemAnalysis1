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
            Hide();
            AddAlternativeForm addAlternative = new AddAlternativeForm(problem.alternatives);
            addAlternative.Closed += (s, args) => Show();
            addAlternative.Show();
        }
        private void editItemButton_Click(object sender, EventArgs e)
        {
            if (alternativesListView.SelectedItems.Count == 1)
            {
                EditAlternativeForm editAlternativeForm =
                    new EditAlternativeForm(problem.alternatives.FirstOrDefault(x => x.description == alternativesListView.SelectedItems[0].SubItems[1].Text));
                editAlternativeForm.Show();
            }
        }
        private void removeItemButton_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in alternativesListView.SelectedItems)
            {
                alternativesListView.Items.Remove(selectedItem as ListViewItem);
            }

            for (int i = 0; i < alternativesListView.Items.Count; i++)
            {
                alternativesListView.Items[i].SubItems[0] = new ListViewItem.ListViewSubItem(alternativesListView.Items[i], i.ToString());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            problem.description = problemDescriptionTextBox.Text;

            Close();
        }
    }
}
