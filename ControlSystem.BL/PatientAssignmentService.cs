using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlSystem.Entities;
using ControlSystem.Infrastructure;

namespace ControlSystem.BL
{
    public class PatientAssignmentService : IPatientAssignmentService
    {
        private readonly IRepository<ExerciseSchedule> _repository;

        public PatientAssignmentService(IRepository<ExerciseSchedule> repository)
        {
            _repository = repository;
        }

        public IEnumerable<ExerciseAssignment> GetCurrentAssignment(DateTime date, PartOfDay partOfDay)
        {
            var currentSchedule = _repository.GetAll().FirstOrDefault(s => s.Date == date);

            switch (partOfDay)
            {
                case PartOfDay.Morning:
                    return currentSchedule?.MorningWorkout.Assignments;
                case PartOfDay.Afternoon:
                    return currentSchedule?.AfternoonWorkout.Assignments;
                case PartOfDay.Evening:
                    return currentSchedule?.EveningWorkout.Assignments;
                default:
                    throw new ArgumentOutOfRangeException(nameof(partOfDay));
            }
        }
    }
}
