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
        private List<Problem> problems;


        public AnalystForm(List<Problem> problems)
        {
            this.problems = problems;

            InitializeComponent();
        }


        private void AnalystForm_Activated(object sender, EventArgs e)
        {
            InitProblemsListView(problems);
        }
        private void addProblemButton_Click(object sender, EventArgs e)
        {
            problems.Add(new Problem("", ""));

            Hide();
            ProblemAnalysisForm problemAnalysisForm = new ProblemAnalysisForm(problems[problems.Count - 1]);
            problemAnalysisForm.Closed += (s, args) => Show();
            problemAnalysisForm.Show();
        }
        private void removeProblemButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedProblem();
        }
        private void editProblemButton_Click(object sender, EventArgs e)
        {
            if (problemsGrid.SelectedRows.Count == 1)
            {
                Problem problem = problems[problemsGrid.SelectedRows[0].Index];

                EditProblem(problem);
            }
        }
        private void problemsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Problem problem = problems[e.RowIndex];

            EditProblem(problem);
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void problemsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && problemsGrid.CurrentCell.Selected)
            {
                e.Handled = true;

                RemoveSelectedProblem();
            }
        }

        private void InitProblemsListView(List<Problem> problems)
        {
            problemsGrid.Rows.Clear();

            for (int i = 0; i < problems.Count; i++)
            {
                problemsGrid.Rows.Add(new string[] { (i + 1).ToString(), problems[i].name, problems[i].status });
            }
        }
        private void EditProblem(Problem problem)
        {
            Hide();
            ProblemAnalysisForm problemAnalysisForm = new ProblemAnalysisForm(problem);
            problemAnalysisForm.Closed += (s, args) => Show();
            problemAnalysisForm.Show();
        }
        private void RemoveSelectedProblem()
        {
            if (problemsGrid.SelectedRows.Count <= 0)
                return;

            for (int i = 0; i < problemsGrid.SelectedRows.Count; i++)
            {
                problems.RemoveAt(problemsGrid.SelectedRows[i].Index);
            }

            foreach (DataGridViewRow item in problemsGrid.SelectedRows)
            {
                problemsGrid.Rows.RemoveAt(item.Index);
            }

            SortIndexes();
        }
        private void SortIndexes()
        {
            for (int i = 0; i < problems.Count; i++)
            {
                problemsGrid.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
    }
}
