using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    class PairComparisonMethod
    {
        private Matrix matrix;


        public PairComparisonMethod(Matrix matrix)
        {
            this.matrix = matrix;
        }


        public double CalculatePreferAlternative(int rowIndex)
        {
            double returnedValue = 0.0d;

            for (int i = 0; i < matrix.width; i++)
            {
                returnedValue += matrix.values[rowIndex, i];
            }

            return returnedValue;
        }
        public double CalculateNorm()
        {
            double returnedValue = 0.0d;

            for (int i = 0; i < matrix.height; i++)
            {
                for (int j = 0; j < matrix.width; j++)
                {
                    returnedValue += matrix.values[i, j];
                }
            }

            return returnedValue;
        }
        public double CalculateWieght(int rowIndex)
        {
            return CalculatePreferAlternative(rowIndex) / CalculateNorm();
        }
    }
}
