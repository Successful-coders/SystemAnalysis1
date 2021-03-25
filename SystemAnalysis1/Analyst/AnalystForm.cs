﻿using System;
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
            ProblemAnalysisForm problemAnalysisForm = new ProblemAnalysisForm(new Problem("", ""));
            problemAnalysisForm.Closed += (s, args) => Show();
            problemAnalysisForm.Show();
        }
        private void removeProblemButton_Click(object sender, EventArgs e)
        {
            if (problemsGrid.SelectedRows.Count <= 0)
                return;

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

            SignInForm signInForm = new SignInForm();
            signInForm.Show();
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
                problemsGrid.Rows.Add(new string[] { i.ToString(), problems[i].description, problems[i].status });
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
            for (int i = 0; i < problemsGrid.SelectedRows.Count; i++)
            {
                problems.RemoveAt(problemsGrid.SelectedRows[i].Index);
            }

            foreach (DataGridViewRow item in problemsGrid.SelectedRows)
            {
                problemsGrid.Rows.RemoveAt(item.Index);
            }
        }
    }
}
