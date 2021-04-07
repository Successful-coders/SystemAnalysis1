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
        private void removeProblemButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedProblem();
        }
        private void problemsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == problemsGrid.Columns.Count - 1)
                return;

            int problemIndex = e.RowIndex;
            Problem problem;

            if (problemIndex >= problems.Count)
            {
                problem = new Problem();
                problems.Add(problem);
            }
            else
            {
                problem = problems[e.RowIndex];
            }

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
                bool isAllMatricesFull = true;
                foreach (var expert in problems[i].Experts)
                {
                    if (!problems[i].GetMatrix(expert).IsFull)
                    {
                        isAllMatricesFull = false;
                        break;
                    }
                }
                if (isAllMatricesFull)
                {
                    problems[i].Status = Status.Анализ;
                }

                problemsGrid.Rows.Add(new object[] { (i + 1).ToString(), problems[i].Name, problems[i].Status.ToString()});
                DataGridViewButtonCell button = problemsGrid.Rows[i].Cells[problemsGrid.Rows[i].Cells.Count - 1] as DataGridViewButtonCell;
                button.Style.ForeColor = button.Style.SelectionForeColor = Color.White;
                button.Style.BackColor = button.Style.SelectionBackColor = Color.Red;
                button.FlatStyle = FlatStyle.Flat;
                button.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            problemsGrid.Rows.Add(new string[3]);
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
            if (problemsGrid.SelectedRows.Count <= 0 || problemsGrid.SelectedRows[0].Index == problemsGrid.Rows.Count - 1 || problems[problemsGrid.SelectedRows[0].Index].Status == Status.Оценивание)
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

        private void problemsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == problemsGrid.Columns["deleteButton"].Index)
            {
                RemoveSelectedProblem();
            }
        }
    }
}
