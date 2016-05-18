using System.Collections.Generic;
using ControlSystem.Entities;

namespace ControlSystem.DA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ControlSystem.DA.ControlSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ControlSystem.DA.ControlSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var d1 = new Diagnosis
            {
                Name = "Травма колінного суглобу",
                Exercises = new List<Exercise>()
            };

            var d2 = new Diagnosis
            {
                Name = "Перелом ноги",
                Exercises = new List<Exercise>()
            };

            var d3 = new Diagnosis
            {
                Name = "Сколіоз",
                Exercises = new List<Exercise>()
            };

            var e1 = new Exercise
            {
                Name = "Віджимання",
                Diagnoses = new List<Diagnosis>(),
                Description = "Тут буде опис віджимань",
                VideoUrl = @"http://www.youtube.com/embed/9Xa29bU7x08"
            };

            var e2 = new Exercise
            {
                Name = "Присідання",
                Diagnoses = new List<Diagnosis>(),
                Description = "Тут буде опис присідань",
                VideoUrl = @"http://www.youtube.com/embed/MUIxtItGioU"
            };

            var e3 = new Exercise
            {
                Name = "Планка",
                Diagnoses = new List<Diagnosis>(),
                Description = "Тут буде опис планки",
                VideoUrl = @"http://www.youtube.com/embed/pNsb32LhufE"
            };
            
            d1.Exercises.Add(e1);
            d1.Exercises.Add(e2);
            d1.Exercises.Add(e3);

            e1.Diagnoses.Add(d1);
            e2.Diagnoses.Add(d1);
            e3.Diagnoses.Add(d1);

            context.Diagnoses.AddOrUpdate(d => d.Name, d1, d2, d3);

            context.Exercises.AddOrUpdate(e => e.Name,
                e1, e2, e3);

            context.SaveChanges();
        }
    }
}
