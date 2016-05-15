using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlSystem.Entities;
using ControlSystem.Infrastructure;

namespace ControlSystem.BL
{
    public class ExerciseHistoryService : IExerciseHistoryService
    {
        private readonly IRepository<ExerciseHistory> _repository;

        public ExerciseHistoryService(IRepository<ExerciseHistory> repository)
        {
            _repository = repository;
        }

        public ExerciseHistory AddExerciseHistory(ExerciseHistory history)
        {
            history.Date = DateTime.Today;
            _repository.Add(history);
            _repository.SaveChanges();
            return history;
        }
    }
}
