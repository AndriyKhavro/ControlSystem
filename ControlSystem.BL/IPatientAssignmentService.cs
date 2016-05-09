using System;
using System.Collections.Generic;
using ControlSystem.Entities;

namespace ControlSystem.BL
{
    public interface IPatientAssignmentService
    {
        IEnumerable<ExerciseAssignment> GetCurrentAssignment(DateTime date, PartOfDay partOfDay);
    }
}