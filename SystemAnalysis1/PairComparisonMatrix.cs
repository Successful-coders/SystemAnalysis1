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


        public double CalculatePreferAlternative()
        {
            for (int i = 0; i < size; i++)
            {

            }

            throw new NotImplementedException();
        }
        public double CalculateNorm()
        {
            throw new NotImplementedException();
        }
        public double CalculateWieght()
        {
            throw new NotImplementedException();
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
    }
}
