using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    class ExpertEstimationsMethod
    {
        private Matrix matrix;
        private List<Expert> experts;


        public ExpertEstimationsMethod(Matrix matrix, List<Expert> experts)
        {
            this.matrix = matrix;
            this.experts = experts;
        }


        public double CalculateRNorm()
        {
            double R = 0.0d;
            for (int i = 0; i < experts.Count; i++)
            {
                R += experts[i].competence;
            }
            return R;
        }
        public double CalculateS(int index)
        {
            double S = 0.0d, R = 0.0d;
            R = CalculateRNorm();
            S = experts[index].competence / R;
            return S;
        }
        
        public double CalculateColumn(int j)
        {
            var returnedValue = 0.0d;
            for (int i = 0; i < matrix.height; i++)
            {
                returnedValue += matrix.values[i, j];
            }
            return returnedValue;
        }

        public double[] CalculateWeight()
        {
            double[]  returnedValue  = new double[matrix.width];
            for (int i = 0; i < matrix.height; i++)
            {
                for (int j = 0; j < matrix.width; j++)
                {
                    returnedValue[j] = CalculateColumn(j) * CalculateS(i);
                }
            }
            return returnedValue;
        }
    }
}
