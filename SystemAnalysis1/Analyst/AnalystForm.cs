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
    public partial class AnalystForm : Form
    {
        private List<Problem> problems = new List<Problem>()
        {
            new Problem("Проблема нехватки общественного транспорта", "Не задействовано"),
            new Problem("Проблема перераспределения выделенного бюджета", "Не задействовано"),
        };


        public AnalystForm()
        {
            InitializeComponent();
        }


        private void AnalystForm_Activated(object sender, EventArgs e)
        {
            InitProblemsListView(problems);
        }
        private void addProblemButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddProblemForm addProblemForm = new AddProblemForm(problems);
            addProblemForm.Closed += (s, args) => Show();
            addProblemForm.Show();
        }
        private void removeProblemButton_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in probliemsListView.SelectedItems)
            {
                probliemsListView.Items.Remove(selectedItem as ListViewItem);
            }

            for (int i = 0; i < probliemsListView.Items.Count; i++)
            {
                probliemsListView.Items[i].SubItems[0] = new ListViewItem.ListViewSubItem(probliemsListView.Items[i], i.ToString());
            }
        }
        private void editProblemButton_Click(object sender, EventArgs e)
        {
            if (probliemsListView.SelectedItems.Count == 1)
            {
                EditProblemForm editProblemForm = 
                    new EditProblemForm(problems.FirstOrDefault(x => x.description == probliemsListView.SelectedItems[0].SubItems[1].Text));
                editProblemForm.Show();
            }
        }
        private void probliemsListView_DoubleClick(object sender, EventArgs e)
        {
            Problem problem = problems.FirstOrDefault(x => x.description == probliemsListView.SelectedItems[0].SubItems[1].Text);

            Hide();
            ProblemAnalysisForm problemAnalysisForm = new ProblemAnalysisForm(problem);
            problemAnalysisForm.Closed += (s, args) => Show();
            problemAnalysisForm.Show();
        }

        private void InitProblemsListView(List<Problem> problems)
        {
            probliemsListView.Items.Clear();

            for (int i = 0; i < problems.Count; i++)
            {
                probliemsListView.Items.Add(new ListViewItem(new string[] { i.ToString(), problems[i].description, problems[i].status }));
            }
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();

            SignInForm signInForm = new SignInForm();
            signInForm.Show();
        }
    }
}
