﻿using System;
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
        private readonly IPartOfDayResolver _partOfDayResolver;

        public PatientAssignmentService(IRepository<ExerciseSchedule> repository, IPartOfDayResolver partOfDayResolver)
        {
            _repository = repository;
            _partOfDayResolver = partOfDayResolver;
        }

        public IEnumerable<ExerciseAssignment> GetCurrentAssignment()
        {
            var now = DateTime.Now;
            var workoutPropertyName = _partOfDayResolver.ResolveWorkoutPropertyName(now);
            var currentSchedule = _repository.GetAll($"{workoutPropertyName}.Assignments.Exercise").FirstOrDefault(s => s.Date == now.Date);
            if (currentSchedule == null)
            {
                return new ExerciseAssignment[0];
            }

            return _partOfDayResolver.ResolveWorkout(currentSchedule, now).Assignments;
        }
    }
}
