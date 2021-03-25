using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    public class Problem
    {
        public string name;
        public string description;
        public string status;
        public List<Alternative> alternatives;
        public List<Expert> experts;


        public Problem()
        {
            alternatives = new List<Alternative>();
            experts = new List<Expert>();
        }
        public Problem(string name, string status) : this()
        {
            this.name = name;
            this.status = status;
        }
        public Problem(string name, string description, string status) : this(name, status)
        {
            this.description = description;
        }
        public Problem(string name, string description, string status, List<Alternative> alternatives) : this(name, description, status)
        {
            this.alternatives = alternatives;
        }
        public Problem(string name, string description, string status, List<Alternative> alternatives, List<Expert> experts) : this(name, description, status, alternatives)
        {
            this.experts = experts;
        }
    }
}
