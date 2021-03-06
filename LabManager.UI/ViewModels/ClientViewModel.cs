using Autofac.Features.Indexed;
using LabManager.UI.Events;
using LabManager.UI.State;
using Prism.Events;
using System;

namespace LabManager.UI.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;

        private IIndex<string, ViewModelBase> _viewModelCreator;

        public INavigator Navigator { get; set; }

        public ClientViewModel(IEventAggregator eventAggregator,
            INavigator navigator, IIndex<string, ViewModelBase> viewModelCreator, INavigationViewModel navigationViewModel)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenViewEvent>()
                .Subscribe(OnOpenView);
            _eventAggregator.GetEvent<OpenDetailViewEvent>()
                .Subscribe(OnOpenDetailView);
            Navigator = navigator;
            _viewModelCreator = viewModelCreator;
            NavigationViewModel = navigationViewModel;
        }

        private async void OnOpenDetailView(OpenDetailViewEventArgs args)
        {
            Navigator.CurrentViewModel = _viewModelCreator[args.ViewModelName];
            var detailVm = Navigator.CurrentViewModel as ClientDetailViewModel;
            await detailVm.LoadAsync(args.Id);
        }

        public INavigationViewModel NavigationViewModel { get; private set; }

        private async void OnOpenView(OpenViewEventArgs args)
        {
            Navigator.CurrentViewModel = _viewModelCreator[args.ViewModelName];
            var collectionVM = Navigator.CurrentViewModel as ClientCollectionViewModel;
            await collectionVM.LoadAsync();
        }
    }
}
