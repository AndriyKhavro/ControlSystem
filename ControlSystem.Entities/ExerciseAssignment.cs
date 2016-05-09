using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem.Entities
{
    public class ExerciseAssignment
    {
        public int ExerciseAssignmentId { get; set; }
        public virtual Exercise Exercise { get; set; }
        public int ExpectedSets { get; set; } 
        public int ExpectedReps { get; set; }
        public virtual ICollection<ExerciseHistory> ExerciseHistories { get; set; }
    }
}
