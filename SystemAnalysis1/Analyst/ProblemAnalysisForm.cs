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
            problemNameTextBox.Text = problem.name;
        }


        private void ProblemAnalysisForm_Activated(object sender, EventArgs e)
        {
            InitAlternativeListView(problem.alternatives);
            InitExpertsListView(problem.experts);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            problem.description = problemDescriptionTextBox.Text;
            problem.name = problemNameTextBox.Text;

            Close();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void addAlternativeButton_Click(object sender, EventArgs e)
        {
            Alternative newAlternative = new Alternative("Описание...", problem.alternatives.Count);

            problem.alternatives.Add(newAlternative);

            alternativesGrid.Rows.Add(new string[] { problem.alternatives.Count.ToString(), newAlternative.description });
        }

        private void removeAlternativeButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedAlternatives();
        }
        private void addExpertButton_Click(object sender, EventArgs e)
        {
            Expert newExpert = new Expert("Ф.И.О.", "Компетентность..");

            problem.experts.Add(newExpert);

            expertsGrid.Rows.Add(new string[] { problem.experts.Count.ToString(), newExpert.name, newExpert.competence });
        }
        private void removeExpertsButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedExperts();
        }
        private void alternativesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = (sender as DataGridView).CurrentCell.Value.ToString();

            Alternative alternative = problem.alternatives[e.RowIndex];

            switch (e.ColumnIndex)
            {
                case 1:
                    {
                        alternative.description = cellValue;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        private void expertsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = (sender as DataGridView).CurrentCell.Value.ToString();

            Expert expert = problem.experts[e.RowIndex];

            switch (e.ColumnIndex)
            {
                case 1:
                    {
                        expert.name = cellValue;
                        break;
                    }
                case 2:
                    {
                        expert.competence = cellValue;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        private void alternativesGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && alternativesGrid.CurrentCell.Selected)
            {
                e.Handled = true;

                RemoveSelectedAlternatives();
            }
        }
        private void expertsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && expertsGrid.CurrentCell.Selected)
            {
                e.Handled = true;

                RemoveSelectedExperts();
            }
        }

        private void InitAlternativeListView(List<Alternative> alternatives)
        {
            alternativesGrid.Rows.Clear();

            for (int i = 0; i < alternatives.Count; i++)
            {
                alternativesGrid.Rows.Add(new string[] { (i + 1).ToString(), alternatives[i].description });
            }
        }
        private void InitExpertsListView(List<Expert> experts)
        {
            expertsGrid.Rows.Clear();

            for (int i = 0; i < experts.Count; i++)
            {
                expertsGrid.Rows.Add(new string[] { (i + 1).ToString(), experts[i].name, experts[i].competence });
            }
        }
        private void RemoveSelectedAlternatives()
        {
            if (alternativesGrid.SelectedRows.Count <= 0)
                return;

            for (int i = 0; i < alternativesGrid.SelectedRows.Count; i++)
            {
                problem.alternatives.RemoveAt(alternativesGrid.SelectedRows[i].Index);
            }

            foreach (DataGridViewRow item in alternativesGrid.SelectedRows)
            {
                alternativesGrid.Rows.RemoveAt(item.Index);
            }

            SortAlternativesIndexes();
        }
        private void RemoveSelectedExperts()
        {
            if (expertsGrid.SelectedRows.Count <= 0)
                return;

            for (int i = 0; i < expertsGrid.SelectedRows.Count; i++)
            {
                problem.experts.RemoveAt(expertsGrid.SelectedRows[i].Index);
            }

            foreach (DataGridViewRow item in expertsGrid.SelectedRows)
            {
                expertsGrid.Rows.RemoveAt(item.Index);
            }

            SortExpertsIndexes();
        }
        private void SortAlternativesIndexes()
        {
            for (int i = 0; i < problem.alternatives.Count; i++)
            {
                alternativesGrid.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void SortExpertsIndexes()
        {
            for (int i = 0; i < problem.experts.Count; i++)
            {
                expertsGrid.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
    }
}
