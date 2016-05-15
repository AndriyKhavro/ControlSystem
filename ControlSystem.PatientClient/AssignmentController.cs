using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ControlSystem.Entities;
using ControlSystem.BL;

namespace ControlSystem.PatientClient
{
    public class AssignmentController : ApiController
    {
        private readonly IPatientAssignmentService _assignmentService;
        private readonly IExerciseHistoryService _exerciseHistoryService;

        public AssignmentController(IPatientAssignmentService assignmentService, IExerciseHistoryService exerciseHistoryService)
        {
            _assignmentService = assignmentService;
            _exerciseHistoryService = exerciseHistoryService;
        }

        [HttpGet]
        public IEnumerable<ExerciseAssignmentDto> Get()
        {
            return _assignmentService.GetCurrentAssignment().Select(a => new ExerciseAssignmentDto
            {
                ExerciseAssignmentId = a.ExerciseAssignmentId,
                Name = a.Exercise.Name,
                Description = a.Exercise.Description,
                ExpectedReps = a.ExpectedReps,
                ExpectedSets = a.ExpectedSets
            });
        }

        [HttpPost]
        public IHttpActionResult AddHistory(ExerciseHistory history)
        {
            var updatedHistory = _exerciseHistoryService.AddExerciseHistory(history);
            return Ok(updatedHistory);
        }
    }

    public class ExerciseAssignmentDto
    {
        public int ExerciseAssignmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExpectedSets { get; set; }
        public int ExpectedReps { get; set; }
    }
}