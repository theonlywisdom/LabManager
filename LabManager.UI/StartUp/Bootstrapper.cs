using Autofac;
using LabManager.UI.State;
using LabManager.UI.ViewModels;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.StartUp
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ClientCollectionViewModel>()
                .Keyed<ViewModelBase>(nameof(ClientCollectionViewModel));

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<Navigator>().As<INavigator>();
            builder.RegisterType<ClientViewModel>().As<ViewModelBase>();


            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();

            return builder.Build();
        }
    }
}
