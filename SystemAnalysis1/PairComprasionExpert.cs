using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    class PairComprasionExpert
    {
        // тут матрица как бы по определению квадратная, следуя из метода
        private Matrix matrix;
        private Expert expert;

        public PairComprasionExpert(Matrix matrix, Expert expert)
        {
            this.matrix = matrix;
            this.expert = expert;
        }

        public double[] CalculatePrefer(int k)
        {
            double[] f = new double[matrix.height];

            for (int i = 0; i < matrix.height; i++)
            {
                f[i] = CalculateRow(i);
            }
            return f;
        }
        public double[] CalculateNormPrefer(int k)
        {
            double[] f = CalculatePrefer(k);
            double N = matrix.width * (matrix.width - 1.0);
            double[] d = new double[matrix.height];

            for (int i = 0; i < matrix.height; i++)
            {
                d[i] = f[i] / N;
            }

            return d;
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
    }
}
