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
        [JsonPropertyAttribute] public Dictionary<Expert, Matrix[]> expertMatrixDictionary = new Dictionary<Expert, Matrix[]>();


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
            expertMatrixDictionary.Add(expert, new Matrix[Enum.GetValues(typeof(SolvingMethod)).Length]);

            InitMatrix(expert);
        }
        public void AddAlternative(Alternative alternative)
        {
            alternatives.Add(alternative);
        }
        public Matrix GetMatrix(Expert expert, int solvingMethodIndex)
        {
            return GetMatrix(expert, (SolvingMethod)solvingMethodIndex);
        }
        public Matrix GetMatrix(Expert expert, SolvingMethod solvingMethod)
        {
            if (expertMatrixDictionary.ContainsKey(expert))
            {
                return expertMatrixDictionary[expert][(int)solvingMethod];
            }
            else
            {
                AddExpert(expert);
                return GetMatrix(expert, solvingMethod);
            }
        }
        public void InitMatrix(Expert expert)
        {
            if (!expertMatrixDictionary.ContainsKey(expert))
            {
                AddExpert(expert);
            }

            expertMatrixDictionary[expert] = new Matrix[Enum.GetValues(typeof(SolvingMethod)).Length];

            expertMatrixDictionary[expert][(int)SolvingMethod.PairComparison] = new Matrix(alternatives.Count, alternatives.Count);
            expertMatrixDictionary[expert][(int)SolvingMethod.WeightedJudgement] = new Matrix(1, alternatives.Count);
            expertMatrixDictionary[expert][(int)SolvingMethod.Prefer] = new Matrix(1, alternatives.Count);
            expertMatrixDictionary[expert][(int)SolvingMethod.Rang] = new Matrix(1, alternatives.Count);
            expertMatrixDictionary[expert][(int)SolvingMethod.FullPairMatching] = new Matrix(alternatives.Count, alternatives.Count);
        }


        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Status Status { get => status; set => status = value; }
        public List<Alternative> Alternatives => alternatives;
        public List<Expert> Experts => experts;
    }
}
