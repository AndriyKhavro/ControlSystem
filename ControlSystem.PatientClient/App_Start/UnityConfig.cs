using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using ControlSystem.BL;
using ControlSystem.DA;
using ControlSystem.Infrastructure;
using Unity.WebApi;

namespace ControlSystem.PatientClient
{
    public static class UnityConfig
    {
        public static void RegisterComponents(HttpConfiguration config)
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<DbContext, ControlSystemContext>(new HierarchicalLifetimeManager());
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<IPatientAssignmentService, PatientAssignmentService>();
            container.RegisterType<IPartOfDayResolver, PartOfDayResolver>();
            container.RegisterType<IExerciseHistoryService, ExerciseHistoryService>();

            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}