using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem.Entities
{
    public class ExerciseHistory
    {
        public int ExerciseHistoryId { get; set; }

        public virtual ExerciseAssignment ExerciseAssignment { get; set; }

        public int ActualRepeat1 { get; set; }

        public int ActualRepeat2 { get; set; }

        public TimeSpan Time { get; set; }

        public short Grade { get; set; }

        public Feeling Feeling { get; set; }

        public DateTime Date { get; set; }
    }
}
