using Autofac.Features.Indexed;
using LabManager.UI.Events;
using LabManager.UI.State;
using Prism.Events;
using System;

namespace LabManager.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;

        private IIndex<string, ViewModelBase> _viewModelCreator;

        public INavigator Navigator { get; set; }

        public MainViewModel(LoginViewModelBase loginViewModel, INavigator navigator, IIndex<string, ViewModelBase> viewModelCreator, IEventAggregator eventAggregator)
        {
            LoginViewModel = loginViewModel;
            Navigator = navigator;
            Navigator.CurrentViewModel = LoginViewModel;
            _viewModelCreator = viewModelCreator;
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<OpenViewEvent>()
                .Subscribe(OnOpenView);
        }

        private void OnOpenView(OpenViewEventArgs args)
        {
            ViewModel = _viewModelCreator[args.ViewModelName];
        }

        private ViewModelBase _viewModel;

        public ViewModelBase ViewModel
        {
            get => _viewModel;
            set
            {
                _viewModel = value;
                OnPropertyChanged();
            }
        }

        public LoginViewModelBase LoginViewModel { get; }
    }
}
