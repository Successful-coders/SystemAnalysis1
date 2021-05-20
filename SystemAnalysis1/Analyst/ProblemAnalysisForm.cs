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

            problemDescriptionTextBox.Text = problem.Description;
            problemNameTextBox.Text = problem.Name;
            problem.FullPairScale = (int)fullPairScaleNumeric.Value;

            Closed += (s, args) =>
            {
                problem.Description = problemDescriptionTextBox.Text;
                problem.Name = problemNameTextBox.Text;
            };
        }


        private void ProblemAnalysisForm_Activated(object sender, EventArgs e)
        {
            InitAlternativeListView(problem.Alternatives);
            InitExpertsListView(problem.Experts);

            if (problem.Status != Status.Редактирование)
            {
                MakeFormReadOnly();
            }
            analyzeButton.Visible = problem.Status == Status.Анализ;

            if (problem.Status != Status.Редактирование)
            {
                MakeButtonsDisable();
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void alternativesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            object valueObject = (sender as DataGridView).CurrentCell.Value;
            string cellValue = "";
            if (valueObject != null)
            {
                cellValue = (sender as DataGridView).CurrentCell.Value.ToString();
            }
            Alternative alternative;

            if (e.RowIndex < problem.Alternatives.Count)
            {
                alternative = problem.Alternatives[e.RowIndex];
            }
            else
            {
                alternative = new Alternative("", e.RowIndex);
                
                problem.AddAlternative(alternative);

                DataGridViewButtonCell button = alternativesGrid.Rows[e.RowIndex].Cells[alternativesGrid.Rows[e.RowIndex].Cells.Count - 1] as DataGridViewButtonCell;
                MakeButtonActive(button);

                alternativesGrid.Rows.Add(new string[] { (problem.Alternatives.Count + 1).ToString(), "" });
            }

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
            Expert expert;

            if (e.RowIndex < problem.Experts.Count)
            {
                expert = problem.Experts[e.RowIndex];
            }
            else
            {
                expert = new Expert("", 1);
                problem.AddExpert(expert);

                DataGridViewButtonCell button = expertsGrid.Rows[e.RowIndex].Cells[expertsGrid.Rows[e.RowIndex].Cells.Count - 1] as DataGridViewButtonCell;
                MakeButtonActive(button);

                expertsGrid.Rows.Add(new string[] { (problem.Experts.Count + 1).ToString(), "", "" });
            }

            switch (e.ColumnIndex)
            {
                case 1:
                    {
                        expert.name = cellValue;
                        break;
                    }
                case 2:
                    {
                        double expertCompetence = double.Parse(cellValue);
                        if (expertCompetence < 1.0d || expertCompetence > 12.0d)
                        {
                            MessageBox.Show("Компетенция должна быть в пределах от 1 до 12");

                            (sender as DataGridView).CurrentCell.Value = "1";

                            break;
                        }

                        expert.competence = double.Parse(cellValue);
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

                DataGridViewButtonCell button = alternativesGrid.Rows[i].Cells[alternativesGrid.Rows[i].Cells.Count - 1] as DataGridViewButtonCell;
                MakeButtonActive(button);
            }

            alternativesGrid.Rows.Add(new string[] { (problem.Alternatives.Count + 1).ToString(), "" });
        }
        private void InitExpertsListView(List<Expert> experts)
        {
            expertsGrid.Rows.Clear();

            for (int i = 0; i < experts.Count; i++)
            {
                expertsGrid.Rows.Add(new string[] { (i + 1).ToString(), experts[i].name, experts[i].competence.ToString() });

                DataGridViewButtonCell button = expertsGrid.Rows[i].Cells[expertsGrid.Rows[i].Cells.Count - 1] as DataGridViewButtonCell;
                MakeButtonActive(button);
            }

            expertsGrid.Rows.Add(new string[] { (problem.Experts.Count + 1).ToString(), "", "" });
        }
        private void RemoveSelectedAlternatives()
        {
            if (alternativesGrid.SelectedRows.Count <= 0 || alternativesGrid.SelectedRows[0].Index == alternativesGrid.Rows.Count - 1 || alternativesGrid.ReadOnly)
                return;

            for (int i = 0; i < alternativesGrid.SelectedRows.Count; i++)
            {
                problem.Alternatives.RemoveAt(alternativesGrid.SelectedRows[i].Index);
            }

            foreach (DataGridViewRow item in alternativesGrid.SelectedRows)
            {
                
                alternativesGrid.Rows.RemoveAt(item.Index);
            }

            SortAlternativesIndexes();
        }
        private void RemoveSelectedExperts()
        {
            if (expertsGrid.SelectedRows.Count <= 0 || expertsGrid.SelectedRows[0].Index == expertsGrid.Rows.Count - 1 || expertsGrid.ReadOnly)
                return;

            for (int i = 0; i < expertsGrid.SelectedRows.Count; i++)
            {
                problem.Experts.RemoveAt(expertsGrid.SelectedRows[i].Index);
            }

            foreach (DataGridViewRow item in expertsGrid.SelectedRows)
            {
                expertsGrid.Rows.RemoveAt(item.Index);
            }

            SortExpertsIndexes();
        }
        private void SortAlternativesIndexes()
        {
            for (int i = 0; i < alternativesGrid.Rows.Count; i++)
            {
                alternativesGrid.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void SortExpertsIndexes()
        {
            for (int i = 0; i < expertsGrid.Rows.Count; i++)
            {
                expertsGrid.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void MakeButtonActive(DataGridViewButtonCell button)
        {
            button.Style.ForeColor = button.Style.SelectionForeColor = Color.White;
            button.Style.BackColor = button.Style.SelectionBackColor = Color.Red;
            button.FlatStyle = FlatStyle.Flat;
            button.Style.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }
        private void MakeButtonDisable(DataGridViewButtonCell button)
        {
            if (button == null)
                return;

            button.Style.ForeColor = button.Style.SelectionForeColor = Color.Gray;
            button.Style.BackColor = button.Style.SelectionBackColor = Color.Gray;
        }
        private void MakeButtonsDisable()
        {
            for (int i = 0; i < alternativesGrid.Rows.Count; i++)
            {
                DataGridViewButtonCell button = alternativesGrid.Rows[i].Cells[alternativesGrid.Rows[i].Cells.Count - 1] as DataGridViewButtonCell;
                MakeButtonDisable(button);
            }
            for (int i = 0; i < expertsGrid.Rows.Count; i++)
            {
                DataGridViewButtonCell button = expertsGrid.Rows[i].Cells[expertsGrid.Rows[i].Cells.Count - 1] as DataGridViewButtonCell;
                MakeButtonDisable(button);
            }
        }
        private void expertsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == expertsGrid.Columns["deleteExpertButton"].Index)
            {
                RemoveSelectedExperts();
            }
        }
        private void alternativesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == alternativesGrid.Columns["deleteButton"].Index)
            {
                RemoveSelectedAlternatives();
            }
        }
        private void sendToExpertButton_Click(object sender, EventArgs e)
        {
            problem.Status = Status.Оценивание;
            for (int i = 0; i < problem.Experts.Count; i++)
            {
                problem.InitMatrix(problem.Experts[i]);
            }
            MakeFormReadOnly();
            MakeButtonsDisable();
        }
        private void MakeFormReadOnly()
        {
            alternativesGrid.ReadOnly = true;
            expertsGrid.ReadOnly = true;
            problemNameTextBox.ReadOnly = true;
            problemDescriptionTextBox.ReadOnly = true;
            sendToExpertButton.Visible = false;
            saveButton.Enabled = false;
            fullPairScaleNumeric.ReadOnly = true;
        }
        private void analyzeButton_Click(object sender, EventArgs e)
        {
            MethodResult methodResult = new MethodResult(problem);
            methodResult.Show();
            methodResult.Closed += (s, args) => Show();

            Hide();
            MakeButtonsDisable();
        }

        private void fullPairScaleNumeric_ValueChanged(object sender, EventArgs e)
        {
            problem.FullPairScale = (int)fullPairScaleNumeric.Value;
        }
    }
}
