using System;

namespace ControlSystem.Entities
{
    public class ExerciseHistory
    {
        public int ExerciseHistoryId { get; set; }
        
        public int ExerciseAssignmentId { get; set; }

        public int ActualSets { get; set; }

        public int ActualReps { get; set; }

        public TimeSpan Time { get; set; }

        public short Grade { get; set; }

        public Feeling Feeling { get; set; }

        public DateTime Date { get; set; }
    }
}
