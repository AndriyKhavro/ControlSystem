using ControlSystem.Entities;

namespace ControlSystem.BL
{
    public interface IExerciseHistoryService
    {
        ExerciseHistory AddExerciseHistory(ExerciseHistory history);
    }
}