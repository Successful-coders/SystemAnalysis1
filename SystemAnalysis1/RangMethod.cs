using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    class RangMethod
    {
        private Matrix matrix;
        private List<Expert> experts;


        public RangMethod(Matrix matrix, List<Expert> experts)
        {
            this.matrix = matrix;
            this.experts = experts;
        }


        public double[] CalculateS()
        {
            double[] S = new double[matrix.width];
            for (int i = 0; i < matrix.width; i++)
            {
                S[i] = CalculateRow(i);
            }
            return S;
        }

        public double CalculateColumn(int j, Matrix calc)
        {
            var returnedValue = 0.0d;
            for (int i = 0; i < calc.height; i++)
            {
                returnedValue += calc.values[i, j];
            }
            return returnedValue;
        }
        public double CalculateRow(int i)
        {
            var returnedValue = 0.0d;
            for (int j = 0; j < matrix.width; j++)
            {
                returnedValue += matrix.values[i, j];
            }
            return returnedValue;
        }

        public Matrix CalculateNormMatrix()
        {
            Matrix R = new Matrix(matrix.height, matrix.width);
            double[] S = new double[matrix.width];
            S = CalculateS();
            for (int i = 0; i < matrix.height; i++)
            {
                for (int j = 0; j < matrix.width; j++)
                {
                    R.values[i, j] = matrix.values[i, j] / S[j];
                }

            }
            return R;
        }

        public double[] CalculateWeight()
        {
            var R = CalculateNormMatrix();
            double[] returnedValue = new double[matrix.width];

            for (int j = 0; j < matrix.width; j++)
            {
                returnedValue[j] = CalculateColumn(j, R) / matrix.height;
            }

            return returnedValue;
        }
    }
}
