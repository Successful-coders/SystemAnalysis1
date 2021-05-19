using System;
using System.Collections;
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
            FillFourthMethod(pairComprasionExpertListview);
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

                
                double[] weights = new double[problem.Alternatives.Count];
                for (int k = 0; k < problem.Alternatives.Count; k++)
                {
                    weights[k] = pairComparisonMethod.CalculateWieght(k);
                }

                var sortWeights = new double[weights.Length];
                weights.CopyTo(sortWeights, 0);
                Array.Sort(sortWeights, new ReverseComparer());
                Dictionary<double, int> weightRankDict = new Dictionary<double, int>();
                int rank = 1;
                for (int h = 0; h < sortWeights.Length; h++)
                {
                    if (!weightRankDict.ContainsKey(sortWeights[h]))
                    {
                        weightRankDict.Add(sortWeights[h], rank);
                        rank++;
                    }
                }
                for (int j = 0; j < problem.Alternatives.Count; j++)
                {
                    double weight = weights[j];

                    list.Items.Add(new ListViewItem(
                        new string[] {
                                weightRankDict[weight].ToString(),
                                problem.Alternatives[j].description,
                                weight.ToString(),
                        },list.Groups[i]));
                }

                ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
                list.ListViewItemSorter = sorter;
                list.Sort();
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
            var sortWeights = new double[weights.Length];
            weights.CopyTo(sortWeights, 0);
            Array.Sort(sortWeights, new ReverseComparer());
            Dictionary<double, int> weightRankDict = new Dictionary<double, int>();
            int rank = 1;
            for (int i = 0; i < sortWeights.Length; i++)
            {
                if (!weightRankDict.ContainsKey(sortWeights[i]))
                {
                    weightRankDict.Add(sortWeights[i], rank);
                    rank++;
                }
            }
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];

                list.Items.Add(new ListViewItem(
                    new string[] {
                                weightRankDict[weight].ToString(),
                                problem.Alternatives[i].description,
                                weight.ToString(),
                    }));
            }

            ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
            list.ListViewItemSorter = sorter;
            list.Sort();
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
            var sortWeights = new double[weights.Length];
            weights.CopyTo(sortWeights, 0);
            Array.Sort(sortWeights, new ReverseComparer());
            Dictionary<double, int> weightRankDict = new Dictionary<double, int>();
            int rank = 1;
            for (int i = 0; i < sortWeights.Length; i++)
            {
                if (!weightRankDict.ContainsKey(sortWeights[i]))
                {
                    weightRankDict.Add(sortWeights[i], rank);
                    rank++;
                }
            }
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];

                list.Items.Add(new ListViewItem(
                    new string[] {
                                weightRankDict[weight].ToString(),
                                problem.Alternatives[i].description,
                                weight.ToString(),
                    }));
            }

            ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
            list.ListViewItemSorter = sorter;
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
            var sortWeights = new double[weights.Length];
            weights.CopyTo(sortWeights, 0);
            Array.Sort(sortWeights, new ReverseComparer());
            Dictionary<double, int> weightRankDict = new Dictionary<double, int>();
            int rank = 1;
            for (int i = 0; i < sortWeights.Length; i++)
            {
                if (!weightRankDict.ContainsKey(sortWeights[i]))
                {
                    weightRankDict.Add(sortWeights[i], rank);
                    rank++;
                }
            }
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];

                list.Items.Add(new ListViewItem(
                    new string[] {
                                weightRankDict[weight].ToString(),
                                problem.Alternatives[i].description,
                                weight.ToString(),
                    }));
            }

            ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
            list.ListViewItemSorter = sorter;
            list.Sort();

        }

        private double SumRow(double[,] d, int i)
        {
            var returnedValue = 0.0d;
            for (int j = 0; j < d.GetLength(1); j++)
            {
                returnedValue += d[i, j];
            }
            return returnedValue;
        }
        private void FillFourthMethod(ListView list)
        {
            double[] weights = new double[problem.GetMatrix(problem.Experts[0], SolvingMethod.FullPairMatching).height];
            double[,] d = new double[problem.Alternatives.Count, problem.Experts.Count];
            for (int k = 0; k < problem.Experts.Count; k++)
            {
                Matrix matrix = problem.GetMatrix(problem.Experts[k], SolvingMethod.FullPairMatching);
                PairComprasionExpert pairExpertsMethod = new PairComprasionExpert(matrix, problem.Experts[k]);
                var returnedValue = pairExpertsMethod.CalculateNormPrefer(k);
                for (int i = 0; i < problem.Alternatives.Count; i++)
                {
                    d[i, k] = returnedValue[i];
                }
            }
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                weights[i] = SumRow(d, i);
            }

            var sortWeights = new double[weights.Length];
            weights.CopyTo(sortWeights, 0);
            Array.Sort(sortWeights, new ReverseComparer());
            Dictionary<double, int> weightRankDict = new Dictionary<double, int>();
            int rank = 1;
            for (int i = 0; i < sortWeights.Length; i++)
            {
                if (!weightRankDict.ContainsKey(sortWeights[i]))
                {
                    weightRankDict.Add(sortWeights[i], rank);
                    rank++;
                }
            }
            for (int i = 0; i < problem.Alternatives.Count; i++)
            {
                double weight = weights[i];
                list.Items.Add(new ListViewItem(
                    new string[] {
                                weightRankDict[weight].ToString(),
                                problem.Alternatives[i].description,
                                weight.ToString(),
                    }));
            }

            ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
            list.ListViewItemSorter = sorter;
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
            alternativeIndex.Text = "Ранг";
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

        public class ReverseComparer : IComparer
        {
            // Call CaseInsensitiveComparer.Compare with the parameters reversed.
            public int Compare(Object x, Object y)
            {
                return (new CaseInsensitiveComparer()).Compare(y, x);
            }
        }
    }
}
