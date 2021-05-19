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
        private const double EPS = 0.001;


        Problem problem;


        public MethodResult(Problem problem)
        {
            this.problem = problem;

            InitializeComponent();

            problemNameText.Text = problem.Name;
            problemDescriptionText.Text = problem.Description;

            FillAlternative(alternativesListView);

            var pairComparisonList = CreateMethodList();
            FillMethodList(pairComparisonList);
            pairComparisonList.SetGroupState(ListViewGroupState.Collapsible);

            FillSecondMethod(method2LIstView);
            FillThirdOneMethod(preferMethodListView);
            FillThirdTwoMethod(rangMethodListView);
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

        private void FillAlternative(ListView list)
        {
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                list.Items.Add(new ListViewItem(
                    new string[] {
                                (i + 1).ToString(),
                                problem.Alternatives[i].description
                    }));
            }
        }

        private void FillMethodList(ListView list)
        {
            for (int i = 0; i < problem.Experts.Count; i++)
            {
                list.Groups.Add(new ListViewGroup(problem.Experts[i].name));

                Matrix matrix = problem.GetMatrix(problem.Experts[i], SolvingMethod.PairComparison);
                PairComparisonMethod pairComparisonMethod = new PairComparisonMethod(matrix);

                int rank = 0;
                double prevWeight = -1;
                for (int j = 0; j < problem.Alternatives.Count; j++)
                {
                    double weight = pairComparisonMethod.CalculateWieght(j);

                    if (Math.Abs(weight - prevWeight) > EPS)
                    {
                        rank++;
                    }

                    list.Items.Add(new ListViewItem(
                        new string[] {
                            rank.ToString(),
                            problem.Alternatives[j].description,
                            weight.ToString()
                        },
                        list.Groups[i]));

                    ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
                    list.ListViewItemSorter = sorter;
                    list.Sort();

                    prevWeight = weight;
                }
            }
        }
        private void FillSecondMethod(ListView list)
        {
            Matrix matrix2Method = new Matrix(problem.Experts.Count, problem.Alternatives.Count);

            for (int i = 0; i < problem.Experts.Count; i++)
            {
                Matrix matrix = problem.GetMatrix(problem.Experts[i], SolvingMethod.WeightedJudgement);
                for (int j = 0; j < problem.Alternatives.Count; j++)
                {
                    matrix2Method.values[i, j] = matrix.values[0, j];
                }

            }

            ExpertEstimationsMethod expertEstimationsMethod = new ExpertEstimationsMethod(matrix2Method, problem.Experts);
            var weights = expertEstimationsMethod.CalculateWeight();
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];

                list.Items.Add(new ListViewItem(
                    new string[] {
                                i.ToString(),
                                problem.Alternatives[i].description,
                                weight.ToString(),
                    }));
            }

            ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
            list.ListViewItemSorter = sorter;
            list.Sort();

            int rank = 0;
            double prevWeight = -1;
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];
                if (Math.Abs(weight - prevWeight) > EPS)
                {
                    rank++;
                }

                var item = list.FindItemWithText(problem.Alternatives[i].description, true, 0);
                item.SubItems[0].Text = rank.ToString();

                prevWeight = weight;
            }
        }
        private void FillThirdOneMethod(ListView list)
        {
            Matrix matrix2Method = new Matrix(problem.Experts.Count, problem.Alternatives.Count);

            for (int i = 0; i < problem.Experts.Count; i++)
            {
                Matrix matrix = problem.GetMatrix(problem.Experts[i], SolvingMethod.Prefer);
                for (int j = 0; j < problem.Alternatives.Count; j++)
                {
                    matrix2Method.values[i, j] = matrix.values[0, j];
                }

            }


            PreferMethod preferMethod = new PreferMethod(matrix2Method, problem.Experts);
            var weights = preferMethod.CalculateWeight();
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];

                list.Items.Add(new ListViewItem(
                    new string[] {
                                "",
                                problem.Alternatives[i].description,
                                weight.ToString(),
                    }));
            }

            ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
            list.ListViewItemSorter = sorter;
            list.Sort();

            int rank = 0;
            double prevWeight = -1;
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];
                if (Math.Abs(weight - prevWeight) > EPS)
                {
                    rank++;
                }

                list.Items[i].SubItems[0].Text = rank.ToString();

                prevWeight = weight;
            }

            list.Sort();
        }

        private void FillThirdTwoMethod(ListView list)
        {
            Matrix matrix2Method = new Matrix(problem.Experts.Count, problem.Alternatives.Count);

            for (int i = 0; i < problem.Experts.Count; i++)
            {
                Matrix matrix = problem.GetMatrix(problem.Experts[i], SolvingMethod.Rang);
                for (int j = 0; j < problem.Alternatives.Count; j++)
                {
                    matrix2Method.values[i, j] = matrix.values[0, j];
                }

            }


            RangMethod rangMethod = new RangMethod(matrix2Method, problem.Experts);
            var weights = rangMethod.CalculateWeight();
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];

                list.Items.Add(new ListViewItem(
                    new string[] {
                                "",
                                problem.Alternatives[i].description,
                                weight.ToString(),
                    }));
            }

            ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
            list.ListViewItemSorter = sorter;
            list.Sort();

            int rank = 0;
            double prevWeight = -1;
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];
                if (Math.Abs(weight - prevWeight) > EPS)
                {
                    rank++;
                }

                list.Items[i].SubItems[0].Text = rank.ToString();

                prevWeight = weight;
            }

            list.Sort();
        }

        private double Sum(double[] d)
        {
            double returnedValue = 0.0d;
            for (int i = 0; i < d.Length; i++)
            {
                returnedValue += d[i];
            }
            return returnedValue;
        }
        private void FillFourthMethod(ListView list)
        {
            double[] weights = new double[problem.GetMatrix(problem.Experts[0], SolvingMethod.FullPairMatching).height];
            for (int k = 0; k < problem.Experts.Count; k++)
            {
                Matrix matrix = problem.GetMatrix(problem.Experts[k], SolvingMethod.FullPairMatching);
                PairComprasionExpert pairExpertsMethod = new PairComprasionExpert(matrix, problem.Experts[k]);
                var d = pairExpertsMethod.CalculateNormPrefer(k);
                for (int i = 0; i < matrix.height; i++)
                {
                    weights[i] = Sum(d);
                }
            }
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];
                list.Items.Add(new ListViewItem(
                    new string[] {
                                "",
                                problem.Alternatives[i].description,
                                weight.ToString(),
                    }));
            }

            ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
            list.ListViewItemSorter = sorter;
            list.Sort();

            int rank = 0;
            double prevWeight = -1;
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];
                if (Math.Abs(weight - prevWeight) > EPS)
                {
                    rank++;
                }

                list.Items[i].SubItems[0].Text = rank.ToString();

                prevWeight = weight;
            }

            list.Sort();
        }
        

        private ListViewExtended CreateMethodList()
        {
            ListViewExtended listViewExtended = new ListViewExtended();

            // 
            // PairComparisonList
            // 
            listViewExtended.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            listViewExtended.HideSelection = false;
            listViewExtended.Location = new System.Drawing.Point(302, 190);
            listViewExtended.Name = "PairComparisonList";
            listViewExtended.Size = new System.Drawing.Size(352, 436);
            listViewExtended.TabIndex = 24;
            listViewExtended.UseCompatibleStateImageBehavior = false;
            listViewExtended.View = System.Windows.Forms.View.Details;
            // 
            // alternativeIndex
            // 
            ColumnHeader alternativeIndex = new ColumnHeader();
            alternativeIndex.Text = "№";
            alternativeIndex.Width = 32;
            // 
            // alternativeDescription
            // 
            ColumnHeader alternativeDescription = new ColumnHeader();
            alternativeDescription.Text = "Альтерантива";
            alternativeDescription.Width = 217;
            // 
            // alternativeWeight
            // 
            ColumnHeader alternativeWeight = new ColumnHeader();
            alternativeWeight.Text = "Вес";
            alternativeWeight.Width = 100;

            listViewExtended.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            alternativeIndex,
            alternativeDescription,
            alternativeWeight});
            Controls.Add(listViewExtended);

            return listViewExtended;
        }
    }
}
