using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    public class Matrix
    {
        public double[,] values;
        public int width;
        public int height;


        public Matrix(int height, int width)
        {
            this.height = height;
            this.width = width;

            values = new double[height, width]; 
        }


        public override string ToString()
        {
            string text ="";

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    text += values[i, j] + "   ";
                }

                text += Environment.NewLine;
            }

            return text;
        }


        public bool IsFull { get; set; }
    }
}
