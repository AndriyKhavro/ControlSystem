namespace ControlSystem.DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diagnosis",
                c => new
                    {
                        DiagnosisId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DiagnosisId);
            
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        ExerciseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Complexity = c.Int(nullable: false),
                        BodyRegion = c.String(),
                        PatientState = c.Int(nullable: false),
                        Description = c.String(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.ExerciseId);
            
            CreateTable(
                "dbo.ExerciseHistories",
                c => new
                    {
                        ExerciseHistoryId = c.Int(nullable: false, identity: true),
                        Repeat1 = c.Int(nullable: false),
                        Repeat2 = c.Int(nullable: false),
                        Time = c.Time(nullable: false, precision: 7),
                        Grade = c.Short(nullable: false),
                        Feeling = c.Int(nullable: false),
                        Exercise_ExerciseId = c.Int(),
                        Workout_WorkoutId = c.Int(),
                    })
                .PrimaryKey(t => t.ExerciseHistoryId)
                .ForeignKey("dbo.Exercises", t => t.Exercise_ExerciseId)
                .ForeignKey("dbo.Workouts", t => t.Workout_WorkoutId)
                .Index(t => t.Exercise_ExerciseId)
                .Index(t => t.Workout_WorkoutId);
            
            CreateTable(
                "dbo.Workouts",
                c => new
                    {
                        WorkoutId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkoutId);
            
            CreateTable(
                "dbo.ExerciseDiagnosis",
                c => new
                    {
                        Exercise_ExerciseId = c.Int(nullable: false),
                        Diagnosis_DiagnosisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Exercise_ExerciseId, t.Diagnosis_DiagnosisId })
                .ForeignKey("dbo.Exercises", t => t.Exercise_ExerciseId, cascadeDelete: true)
                .ForeignKey("dbo.Diagnosis", t => t.Diagnosis_DiagnosisId, cascadeDelete: true)
                .Index(t => t.Exercise_ExerciseId)
                .Index(t => t.Diagnosis_DiagnosisId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExerciseHistories", "Workout_WorkoutId", "dbo.Workouts");
            DropForeignKey("dbo.ExerciseHistories", "Exercise_ExerciseId", "dbo.Exercises");
            DropForeignKey("dbo.ExerciseDiagnosis", "Diagnosis_DiagnosisId", "dbo.Diagnosis");
            DropForeignKey("dbo.ExerciseDiagnosis", "Exercise_ExerciseId", "dbo.Exercises");
            DropIndex("dbo.ExerciseDiagnosis", new[] { "Diagnosis_DiagnosisId" });
            DropIndex("dbo.ExerciseDiagnosis", new[] { "Exercise_ExerciseId" });
            DropIndex("dbo.ExerciseHistories", new[] { "Workout_WorkoutId" });
            DropIndex("dbo.ExerciseHistories", new[] { "Exercise_ExerciseId" });
            DropTable("dbo.ExerciseDiagnosis");
            DropTable("dbo.Workouts");
            DropTable("dbo.ExerciseHistories");
            DropTable("dbo.Exercises");
            DropTable("dbo.Diagnosis");
        }
    }
}
