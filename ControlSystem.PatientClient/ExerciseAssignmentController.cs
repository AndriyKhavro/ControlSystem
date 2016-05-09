using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ControlSystem.Entities;
using ControlSystem.BL;

namespace ControlSystem.PatientClient
{
    public class ExerciseAssignmentController : ApiController
    {
        private readonly IPatientAssignmentService _assignmentService;

        public ExerciseAssignmentController(IPatientAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        public IEnumerable<ExerciseAssignment> Get(DateTime date, PartOfDay partOfDay)
        {
            return _assignmentService.GetCurrentAssignment(date, partOfDay);
        }
    }
}