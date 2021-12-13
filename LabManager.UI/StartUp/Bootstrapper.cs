using Autofac;
using LabManager.DataAccess;
using LabManager.UI.Data.Lookups;
using LabManager.UI.Data.Repositories;
using LabManager.UI.Services;
using LabManager.UI.State;
using LabManager.UI.State.Authenticators;
using LabManager.UI.ViewModels;
using Microsoft.AspNet.Identity;
using Prism.Events;

namespace LabManager.UI.StartUp
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ClientCollectionViewModel>()
                .Keyed<ViewModelBase>(nameof(ClientCollectionViewModel));
            builder.RegisterType<ClientDetailViewModel>()
                .Keyed<ViewModelBase>(nameof(ClientDetailViewModel));

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<Navigator>().As<INavigator>();
            builder.RegisterType<ClientViewModel>().As<ViewModelBase>();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<ClientLookupService>().As<IClientLookupService>();
            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            builder.RegisterType<AccountRepository>().As<IAccountRepository>();
            builder.RegisterType<PasswordHasher>().As<IPasswordHasher>();
            builder.RegisterType<Authenticator>().As<IAuthenticator>();


            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<DbSeedContext>().AsSelf();

            return builder.Build();
        }
    }
}
