using System;
using ControlSystem.Entities;

namespace ControlSystem.BL
{
    public class PartOfDayResolver: IPartOfDayResolver
    {
        public Workout ResolveWorkout(ExerciseSchedule schedule, PartOfDay partOfDay)
        {
            switch (partOfDay)
            {
                case PartOfDay.Morning:
                    return schedule.MorningWorkout;
                case PartOfDay.Afternoon:
                    return schedule.AfternoonWorkout;
                case PartOfDay.Evening:
                    return schedule.EveningWorkout;
                default:
                    throw new ArgumentOutOfRangeException(nameof(partOfDay));
            }
        }

        public string ResolveWorkoutPropertyName(PartOfDay partOfDay)
        {
            switch (partOfDay)
            {
                case PartOfDay.Morning:
                    return "MorningWorkout";
                case PartOfDay.Afternoon:
                    return "AfternoonWorkout";
                case PartOfDay.Evening:
                    return "EveningWorkout";
                default:
                    throw new ArgumentOutOfRangeException(nameof(partOfDay));
            }
        }
    }
}
