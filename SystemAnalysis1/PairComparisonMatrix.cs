using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    public class PairComparisonMatrix
    {
        public double[,] values;
        public int size;


        public PairComparisonMatrix(int size)
        {
            this.size = size;

            values = new double[size, size]; 
        }


        public double CalculatePreferAlternative(int rowIndex)
        {
            double returnedValue = 0.0d;

            for (int i = 0; i < size; i++)
            {
                returnedValue += values[rowIndex, i];
            }

            return returnedValue;
        }
        public double CalculateNorm()
        {
            double returnedValue = 0.0d;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    returnedValue += values[i, j];
                }
            }

            return returnedValue;
        }
        public double CalculateWieght(int rowIndex)
        {
            return CalculatePreferAlternative(rowIndex) / CalculateNorm();
        }


        public override string ToString()
        {
            string text ="";

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    text += values[i, j] + "   ";
                }

                text += Environment.NewLine;
            }

            return text;
        }

        public double CalculateWieghtSecondMethod(int columnIndex, double S)
        {
            double returnedValue = 0.0d;

            for (int i = 0; i < size; i++)
            {
                returnedValue += values[i, columnIndex];
            }

            return returnedValue*S;
        }

        public bool IsFull { get; set; }
    }
}
