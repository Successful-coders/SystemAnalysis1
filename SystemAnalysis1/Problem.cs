using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    public class Problem
    {
        private string name;
        private string description;
        private Status status;
        private List<Alternative> alternatives = new List<Alternative>();
        private List<Expert> experts = new List<Expert>();
        [JsonPropertyAttribute] private Dictionary<Expert, PairComparisonMatrix> expertMatrixDictionary = new Dictionary<Expert, PairComparisonMatrix>();


        public Problem()
        {
            alternatives = new List<Alternative>();
            experts = new List<Expert>();
        }
        public Problem(string name, Status status) : this()
        {
            this.name = name;
            this.status = status;
        }
        public Problem(string name, string description, Status status) : this(name, status)
        {
            this.description = description;
        }
        public Problem(string name, string description, Status status, List<Alternative> alternatives) : this(name, description, status)
        {
            this.alternatives = alternatives;
        }
        public Problem(string name, string description, Status status, List<Alternative> alternatives, List<Expert> experts) : this(name, description, status, alternatives)
        {
            experts.ForEach(expert => AddExpert(expert));
        }


        public void AddExpert(Expert expert)
        {
            experts.Add(expert);
            expertMatrixDictionary.Add(expert, new PairComparisonMatrix(alternatives.Count));
        }
        public void AddAlternative(Alternative alternative)
        {
            alternatives.Add(alternative);
        }
        public PairComparisonMatrix GetMatrix(Expert expert)
        {
            if (expertMatrixDictionary.ContainsKey(expert))
            {
                return expertMatrixDictionary[expert];
            }
            else
            {
                AddExpert(expert);
                return GetMatrix(expert);
            }
        }
        public void InitMatrix(Expert expert)
        {
            if (!expertMatrixDictionary.ContainsKey(expert))
            {
                AddExpert(expert);
            }

            expertMatrixDictionary[expert] = new PairComparisonMatrix(alternatives.Count);
        }


        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Status Status { get => status; set => status = value; }
        public List<Alternative> Alternatives => alternatives;
        public List<Expert> Experts => experts;
    }
}
