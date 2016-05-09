using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlSystem.Entities;
using ControlSystem.Infrastructure;

namespace ControlSystem.BL
{
    public class TimeTableService : ITimeTableService
    {
        private readonly IRepository<Exercise> _exerciseRepository;
        private readonly IRepository<ExerciseSchedule> _scheduleRepository; 

        public TimeTableService(IRepository<Exercise> exerciseRepository, IRepository<ExerciseSchedule> scheduleRepository)
        {
            _exerciseRepository = exerciseRepository;
            _scheduleRepository = scheduleRepository;
        }

        public IEnumerable<Exercise> GetExercises(int[] diagnosesIDs, PatientState patientState)
        {
            return _exerciseRepository.GetAll()
                  .Where(
                      ex => ex.PatientState == patientState && ex.Diagnoses.Any(d => diagnosesIDs.Contains(d.DiagnosisId)));
        }

        public void SaveExerciseSchedule(ExerciseSchedule schedule)
        {
            _scheduleRepository.Add(schedule);
            _scheduleRepository.SaveChanges();
        }
    }
}
