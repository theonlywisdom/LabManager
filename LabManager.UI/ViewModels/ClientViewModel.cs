using Autofac.Features.Indexed;
using LabManager.UI.Events;
using LabManager.UI.State;
using Prism.Events;

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
            Navigator = navigator;
            _viewModelCreator = viewModelCreator;
            NavigationViewModel = navigationViewModel;
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
