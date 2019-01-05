[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MasterTrainer.API.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(MasterTrainer.API.App_Start.NinjectWebCommon), "Stop")]

namespace MasterTrainer.API.App_Start
{
    using System;
    using System.Web;
    using MasterTrainer.Business.AuthenticationManagement.Services;
    using MasterTrainer.Business.PawnManagement.Mappers;
    using MasterTrainer.Business.PawnManagement.Repositories;
    using MasterTrainer.Business.PawnManagement.Services;
    using MasterTrainer.Business.RegistrationManagement.Services;
    using MasterTrainer.Business.UserManagement.Mappers;
    using MasterTrainer.Business.UserManagement.Repositories;
    using MasterTrainer.Business.UserManagement.Services;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            // Services
            kernel.Bind<IAuthenticationService>().To<AuthenticationService>();
            kernel.Bind<IRegistrationService>().To<RegistrationService>();
            kernel.Bind<IPasswordService>().To<PasswordService>();
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IPawnService>().To<PawnService>();

            // Mappers
            kernel.Bind<IUserMapper>().To<UserMapper>();
            kernel.Bind<IPawnMapper>().To<PawnMapper>();

            // Repositories
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IPawnRepository>().To<PawnRepository>();
        }
    }
}