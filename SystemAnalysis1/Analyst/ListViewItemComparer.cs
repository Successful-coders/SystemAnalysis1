using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis1
{
    public class ListViewItemComparer : IComparer
    {
        private int _columnIndex;
        public int ColumnIndex
        {
            get
            {
                return _columnIndex;
            }
            set
            {
                _columnIndex = value;
            }
        }

        private SortOrder _sortDirection;
        public SortOrder SortDirection
        {
            get
            {
                return _sortDirection;
            }
            set
            {
                _sortDirection = value;
            }
        }

        private ColumnDataType _columnType;
        public ColumnDataType ColumnType
        {
            get
            {
                return _columnType;
            }
            set
            {
                _columnType = value;
            }
        }


        public ListViewItemComparer()
        {
            _sortDirection = SortOrder.None;
        }

        public int Compare(object x, object y)
        {
            ListViewItem lviX = x as ListViewItem;
            ListViewItem lviY = y as ListViewItem;

            int result;

            if (lviX == null && lviY == null)
            {
                result = 0;
            }
            else if (lviX == null)
            {
                result = -1;
            }

            else if (lviY == null)
            {
                result = 1;
            }

            switch (ColumnType)
            {
                case ColumnDataType.Int:
                    int xInt = int.Parse(lviX.SubItems[ColumnIndex].Text);
                    int yInt = int.Parse(lviY.SubItems[ColumnIndex].Text);
                    if (SortDirection == SortOrder.Descending)
                    {
                        return yInt.CompareTo(xInt);
                    }
                    else
                    {
                        return xInt.CompareTo(yInt);
                    }
                case ColumnDataType.Double:
                    double xDouble = double.Parse(lviX.SubItems[ColumnIndex].Text);
                    double yDouble = double.Parse(lviY.SubItems[ColumnIndex].Text);
                    if (SortDirection == SortOrder.Descending)
                    {
                        return yDouble.CompareTo(xDouble);
                    }
                    else
                    {
                        return xDouble.CompareTo(yDouble);
                    }
                default:
                    result = string.Compare(
                        lviX.SubItems[ColumnIndex].Text,
                        lviY.SubItems[ColumnIndex].Text,
                        false);
                    break;
            }

            if (SortDirection == SortOrder.Descending)
            {
                return -result;
            }
            else
            {
                return result;
            }
        }
    }

    public enum ColumnDataType
    {
        Int,
        Double,
    }
}
