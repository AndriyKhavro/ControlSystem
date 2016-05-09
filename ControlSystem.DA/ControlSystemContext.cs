using ControlSystem.DA.Migrations;
using ControlSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem.DA
{
    public class ControlSystemContext : DbContext
    {
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseHistory> ExerciseHistories { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<ExerciseSchedule> ExerciseSchedules{ get; set; }
        public DbSet<ExerciseAssignment> ExerciseAssignments{ get; set; }

        public ControlSystemContext()
            : base("ControlSystemContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ControlSystemContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<ControlSystemContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
