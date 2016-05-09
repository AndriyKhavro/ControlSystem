using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlSystem.Entities
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public ExerciseComplexity Complexity { get; set; }

        public string BodyRegion { get; set; }

        public PatientState PatientState { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public virtual ICollection<Diagnosis> Diagnoses { get; set; }

        public virtual ICollection<ExerciseAssignment> Assignments { get; set;} 

        public override string ToString()
        {
            return Name;
        }
    }
}
