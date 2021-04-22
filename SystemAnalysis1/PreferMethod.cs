using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    class PreferMethod
    {
        private Matrix matrix;
        private List<Expert> experts;


        public PreferMethod(Matrix matrix, List<Expert> experts)
        {
            this.matrix = matrix;
            this.experts = experts;
        }

        public Matrix CalculateModifyMatrix()
        {
            Matrix modifymatrix = new Matrix(matrix.height, matrix.width);
            for (int i = 0; i < modifymatrix.height; i++)
            {
                for (int j = 0; j < modifymatrix.width; j++)
                {
                    modifymatrix.values[i, j] = modifymatrix.width - matrix.values[i, j];
                }
            }
            return modifymatrix;
        }

        public double[] CalculatePrefer()
        {
            
            Matrix K = CalculateModifyMatrix();
            double[] L = new double[matrix.width];
            for (int i = 0; i < matrix.width; i++)
            {
                L[i] = CalculateColumn(i, K);
            }
            return L;
        }

        public double CalculateColumn(int j, Matrix matrixCalc)
        {
            var returnedValue = 0.0d;
            for (int i = 0; i < matrixCalc.height; i++)
            {
                returnedValue += matrixCalc.values[i, j];
            }
            return returnedValue;
        }

        public double CalculateLNorm()
        {
            double returnedvalue = 0.0d;
            var L = CalculatePrefer();
            for (int i = 0; i < matrix.width; i++)
            {
                returnedvalue += L[i];
            }
            return returnedvalue;
        }

        public double[] CalculateWeight()
        {
            double[] returnedValue = new double[matrix.width];
            var L = CalculatePrefer();
            var Lnorm = CalculateLNorm();
            for (int j = 0; j < matrix.width; j++)
            {
                returnedValue[j] = L[j]/Lnorm;
            }

            return returnedValue;
        }
    }
}
