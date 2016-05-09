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

        public AssignmentController(IPatientAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        [HttpGet]
        public IEnumerable<ExerciseAssignmentDto> Get(DateTime date, PartOfDay partOfDay)
        {
            return _assignmentService.GetCurrentAssignment(date, partOfDay).Select(a => new ExerciseAssignmentDto
            {
                Name = a.Exercise.Name,
                Description = a.Exercise.Description,
                ExpectedReps = a.ExpectedReps,
                ExpectedSets = a.ExpectedSets
            });
        }
    }

    public class ExerciseAssignmentDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExpectedSets { get; set; }
        public int ExpectedReps { get; set; }
    }
}