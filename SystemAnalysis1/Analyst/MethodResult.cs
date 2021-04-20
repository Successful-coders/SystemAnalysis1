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
    public partial class MethodResult : Form
    {
        Problem problem;


        public MethodResult(Problem problem)
        {
            this.problem = problem;

            InitializeComponent();

            problemNameText.Text = problem.Name;
            problemDescriptionText.Text = problem.Description;


            int listOffset = 300;

            var pairComparisonList = CreateMethodList();
            //FillMethodList(pairComparisonList);
            //pairComparisonList.SetGroupState(ListViewGroupState.Collapsible);

            var method2List = CreateMethodList();
            method2List.Location = new Point(pairComparisonList.Location.X + listOffset, pairComparisonList.Location.Y);
            FillSecondMethod(method2List);
            method2List.SetGroupState(ListViewGroupState.Collapsible);
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


        private void FillMethodList(ListView list)
        {
            for (int i = 0; i < problem.Experts.Count; i++)
            {
                list.Groups.Add(new ListViewGroup(problem.Experts[i].name));

                for (int j = 0; j < problem.Alternatives.Count; j++)
                {
                    list.Items.Add(new ListViewItem(
                        new string[] {
                            (problem.Alternatives[j].index + 1).ToString(),
                            problem.Alternatives[j].description,
                            problem.GetMatrix(problem.Experts[i]).CalculateWieght(j).ToString()
                        },
                        list.Groups[i]));

                    ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
                    list.ListViewItemSorter = sorter;
                    list.Sort();
                }
            }
        }
        //--------------------лаба 2
        private double CalculateRNorm()
        {
            double R = 0.0d;
            for (int i = 0; i < problem.Experts.Count; i++)
            {
                R += problem.Experts[i].competence;
            }
            return R;
        }
        private double CalculateS(int index)
        {
            double S = 0.0d, R=0.0d;
            R = CalculateRNorm();
            S = problem.Experts[index].competence / R;
            return S;
        }

        private double CalculateV(int i, int j)
        {
            double V = 0.0d;

            V += problem.GetMatrix(problem.Experts[j]).CalculateWieghtSecondMethod(j, CalculateS(i));

            return V;
        }
        //--------------------
        private void FillSecondMethod(ListView list)
        {
            for (int i = 0; i < problem.Experts.Count; i++)
            {

                for (int j = 0; j < problem.Alternatives.Count; j++)
                {

                    list.Items.Add(new ListViewItem(
                        new string[] {(problem.Alternatives[j].index + 1).ToString(),
                            problem.Alternatives[j].description,
                            CalculateV(i,j).ToString()
                        },
                        list.Groups[j]));//ТУТ ВЫВОДИТСЯ ЧТО ТО НЕ ТАК ХЗ)))

                    ListViewItemComparer sorter = GetListViewSorter(list.Columns.Count - 1, SortOrder.Descending);
                    list.ListViewItemSorter = sorter;
                    list.Sort();
                }
            }

        }

        private ListViewExtended CreateMethodList()
        {
            ListViewExtended listViewExtended = new ListViewExtended();

            // 
            // PairComparisonList
            // 
            listViewExtended.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            listViewExtended.HideSelection = false;
            listViewExtended.Location = new System.Drawing.Point(16, 190);
            listViewExtended.Name = "PairComparisonList";
            listViewExtended.Size = new System.Drawing.Size(532, 436);
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
            alternativeDescription.Width = 400;
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