using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    public class Problem
    {
        public string description;
        public string status;
        public List<Alternative> alternatives;


        public Problem(string description, string status)
        {
            this.description = description;
            this.status = status;

            alternatives = new List<Alternative>();
        }
    }
}
