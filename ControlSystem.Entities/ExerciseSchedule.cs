using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem.Entities
{
    public class ExerciseSchedule
    {
        public int ExerciseScheduleId { get; set; }
        public virtual Workout MorningWorkout { get; set; }
        public virtual Workout AfternoonWorkout { get; set; }
        public virtual Workout EveningWorkout { get; set; }
        public DateTime Date { get; set; }
    }
}
