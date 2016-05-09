using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlSystem.Entities
{
    public class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Exercise> Exercises { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
