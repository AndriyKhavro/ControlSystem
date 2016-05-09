using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem.Entities
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public virtual ICollection<ExerciseAssignment> Assignments { get; set; }
    }
}
