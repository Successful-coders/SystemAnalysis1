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
    public partial class MethodResult : Form
    {
        public MethodResult(Problem problem)
        {
            InitializeComponent();

            problemNameText.Text = problem.Name;
            problemDescriptionText.Text = problem.Description;

            List<double> weights = new List<double>();

            //foreach (var expert in problem.Experts)
            for (int i = 0; i < problem.Experts.Count; i++)
            {
                PairComparisonList.Groups.Add(new ListViewGroup(problem.Experts[i].name));

                for (int j = 0; j < problem.Alternatives.Count; j++)
                {
                    PairComparisonList.Items.Add(new ListViewItem(
                        new string[] {
                            (problem.Alternatives[j].index + 1).ToString(),
                            problem.Alternatives[j].description, 
                            problem.GetMatrix(problem.Experts[i]).CalculateWieght(j).ToString() 
                        },
                        PairComparisonList.Groups[i]));

                    ListViewItemComparer sorter = GetListViewSorter(PairComparisonList.Columns.Count - 1, SortOrder.Descending);
                    PairComparisonList.ListViewItemSorter = sorter;
                    PairComparisonList.Sort();
                }
            }
        }

        private void SortByWeight(Problem problem, int indexExpert)
        {
            for (int j = 0; j < problem.Alternatives.Count; j++)
            {
                problem.GetMatrix(problem.Experts[indexExpert]).CalculateWieght(j);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private ListViewItemComparer GetListViewSorter(int columnIndex, SortOrder sortOrder)
        {
            ListViewItemComparer sorter = (ListViewItemComparer)PairComparisonList.ListViewItemSorter;
            if (sorter == null)
            {
                sorter = new ListViewItemComparer();
            }

            sorter.ColumnIndex = columnIndex;

            string columnName = PairComparisonList.Columns[columnIndex].Name;
            sorter.ColumnType = ColumnDataType.Double;
            sorter.SortDirection = sortOrder;

            return sorter;
        }
    }
}
