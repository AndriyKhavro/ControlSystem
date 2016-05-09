namespace ControlSystem.DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExerciseAssignments", "ExerciseSchedule_ExerciseScheduleId", "dbo.ExerciseSchedules");
            DropIndex("dbo.ExerciseAssignments", new[] { "ExerciseSchedule_ExerciseScheduleId" });
            AddColumn("dbo.ExerciseAssignments", "ExpectedSets", c => c.Int(nullable: false));
            AddColumn("dbo.ExerciseAssignments", "ExpectedReps", c => c.Int(nullable: false));
            AddColumn("dbo.ExerciseSchedules", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.ExerciseAssignments", "ExpectedRepeat1");
            DropColumn("dbo.ExerciseAssignments", "ExpectedRepeat2");
            DropColumn("dbo.ExerciseAssignments", "ExerciseSchedule_ExerciseScheduleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExerciseAssignments", "ExerciseSchedule_ExerciseScheduleId", c => c.Int());
            AddColumn("dbo.ExerciseAssignments", "ExpectedRepeat2", c => c.Int(nullable: false));
            AddColumn("dbo.ExerciseAssignments", "ExpectedRepeat1", c => c.Int(nullable: false));
            DropColumn("dbo.ExerciseSchedules", "Date");
            DropColumn("dbo.ExerciseAssignments", "ExpectedReps");
            DropColumn("dbo.ExerciseAssignments", "ExpectedSets");
            CreateIndex("dbo.ExerciseAssignments", "ExerciseSchedule_ExerciseScheduleId");
            AddForeignKey("dbo.ExerciseAssignments", "ExerciseSchedule_ExerciseScheduleId", "dbo.ExerciseSchedules", "ExerciseScheduleId");
        }
    }
}
