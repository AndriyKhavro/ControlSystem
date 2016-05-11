using System;
using ControlSystem.Entities;

namespace ControlSystem.BL
{
    public class PartOfDayResolver: IPartOfDayResolver
    {
        public Workout ResolveWorkout(ExerciseSchedule schedule, DateTime dateTime)
        {
            if (dateTime.Hour < 12)
            {
                return schedule.MorningWorkout;
            }
            if (dateTime.Hour >= 12 && dateTime.Hour < 18)
            {
                return schedule.AfternoonWorkout;
            }
            return schedule.EveningWorkout;
        }

        public string ResolveWorkoutPropertyName(DateTime dateTime)
        {
            if (dateTime.Hour < 12)
            {
                return "MorningWorkout";
            }
            if (dateTime.Hour >= 12 && dateTime.Hour < 18)
            {
                return "AfternoonWorkout";
            }
            return "EveningWorkout";
        }
    }
}
