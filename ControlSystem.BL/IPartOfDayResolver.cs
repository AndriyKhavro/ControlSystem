using ControlSystem.Entities;

namespace ControlSystem.BL
{
    public interface IPartOfDayResolver
    {
        Workout ResolveWorkout(ExerciseSchedule schedule, PartOfDay partOfDay);
        string ResolveWorkoutPropertyName(PartOfDay partOfDay);
    }
}
