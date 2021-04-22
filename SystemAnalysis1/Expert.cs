using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SystemAnalysis1
{
    [TypeConverter(typeof(ExpertConverter))]
    public class Expert : IEquatable<Expert>
    {
        public string name;
        public double competence;


        public Expert(string name, double competence)
        {
            this.name = name;
            this.competence = competence;
        }


        public bool Equals(Expert other)
        {
            if (ReferenceEquals(this, null) ^ ReferenceEquals(other, null))
            {
                return false;
            }
            else if (ReferenceEquals(this, null) && ReferenceEquals(other, null))
            {
                return true;
            }
            else
            {
                return name == other.name && competence == other.competence;
            }
        }
        public override bool Equals(object other)
        {
            if (other.GetType() == typeof(Expert))
            {
                return Equals(other);
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"{name};{competence}";
        }
        public override int GetHashCode()
        {
            return name.Length * Convert.ToInt32(competence);
        }

        public static bool operator ==(Expert expert0, Expert expert1)
        {
            if (ReferenceEquals(expert0, null) ^ ReferenceEquals(expert1, null))
            {
                return false;
            }
            else if (ReferenceEquals(expert0, null) && ReferenceEquals(expert1, null))
            {
                return true;
            }
            else
            {
                return expert0.Equals(expert1);
            }
        }
        public static bool operator !=(Expert expert0, Expert expert1)
        {
            return !(expert0 == expert1);
        }
    }
}
