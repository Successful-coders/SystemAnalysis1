﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    public class PairComparisonMatrix
    {
        public double[] values;


        public PairComparisonMatrix(int size)
        {
            values = new double[size]; 
        }


        public double CalculatePreferAlternative()
        {
            for (int i = 0; i < values.Length; i++)
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
    }
}
