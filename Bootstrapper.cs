using System.Web.Mvc;
using Microsoft.Practices.Unity;
using LoadTracking.Data.Repository;
using LoadTracking.Core.Domain.Entity;
using LoadTracking.Data.UnitOfWork;

using LoadTracking.Services.Cargomax;
using LoadTracking.Services.ProgressLogs;
using Unity.Mvc5;

namespace LoadTracking.Ioc
{
    public static class IOCExtensions
    {
        public static void BindInRequestScope<T1, T2>(this IUnityContainer container) where T2 : T1
        {
            container.RegisterType<T1, T2>(new HierarchicalLifetimeManager());
        }

        public static void BindInSingletonScope<T1, T2>(this IUnityContainer container) where T2 : T1
        {
            container.RegisterType<T1, T2>(new ContainerControlledLifetimeManager());
        }
    }
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.BindInRequestScope<IGenericRepository<User>, GenericRepository<User>>();
            container.BindInRequestScope<IGenericRepository<Rule>, GenericRepository<Rule>>();
            container.BindInRequestScope<IGenericRepository<Ramp>, GenericRepository<Ramp>>();
            container.BindInRequestScope<IGenericRepository<RuleResult>, GenericRepository<RuleResult>>();
            container.BindInRequestScope<IGenericRepository<ProgressLog>, GenericRepository<ProgressLog>>();

            container.BindInRequestScope<IUnitOfWork, UnitOfWork>();

           
            container.BindInRequestScope<ICargoMaxService, CargoMaxService>();
            container.BindInRequestScope<IProgressLogService, ProgressLogService>();
        }
    }
}