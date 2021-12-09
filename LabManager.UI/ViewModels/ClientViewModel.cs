using Autofac.Features.Indexed;
using LabManager.UI.Events;
using LabManager.UI.State;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;

        private INavigator Navigator { get; set; }

        private IIndex<string, ViewModelBase> _viewModelCreator;

        public ClientViewModel(IEventAggregator eventAggregator,
            INavigator navigator, IIndex<string,ViewModelBase> viewModelCreator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenViewEvent>()
                .Subscribe(OnOpenView);
            Navigator = navigator;
            _viewModelCreator = viewModelCreator;
        }

        private void OnOpenView(OpenViewEventArgs args)
        {
            Navigator.CurrentViewModel = _viewModelCreator[args.ViewModelName];
        }
    }
}
