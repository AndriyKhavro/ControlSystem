using System;
using ControlSystem.Entities;

namespace ControlSystem.BL
{
    public interface IPartOfDayResolver
    {
        Workout ResolveWorkout(ExerciseSchedule schedule, DateTime dateTime);
        string ResolveWorkoutPropertyName(DateTime dateTime);
    }
}
