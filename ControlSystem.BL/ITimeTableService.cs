using System.Collections.Generic;
using ControlSystem.Entities;

namespace ControlSystem.BL
{
    public interface ITimeTableService
    {
        IEnumerable<Exercise> GetExercises(int[] diagnosesIDs, PatientState patientState);

        void SaveExerciseSchedule(ExerciseSchedule schedule);
    }
}