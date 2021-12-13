using Autofac.Features.Indexed;
using LabManager.UI.Events;
using LabManager.UI.State;
using LabManager.UI.State.Authenticators;
using Prism.Events;
using System;

namespace LabManager.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IAuthenticator _authenticator;

        private IEventAggregator _eventAggregator;

        private IIndex<string, ViewModelBase> _viewModelCreator;

        public INavigator Navigator { get; set; }

        private readonly LoginViewModel _loginViewModel;

        public MainViewModel(LoginViewModel loginViewModel, INavigator navigator, IIndex<string, ViewModelBase> viewModelCreator, IEventAggregator eventAggregator, IAuthenticator authenticator)
        {
            _loginViewModel = loginViewModel;
            Navigator = navigator;
            Navigator.CurrentViewModel = _loginViewModel;
            _viewModelCreator = viewModelCreator;
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<LoginAccountEvent>()
                .Subscribe(OnAccountLongin);
            _authenticator = authenticator;
        }

        private async void OnAccountLongin(LoginAccountEventArgs args)
        {
            bool success = await _authenticator.Login(_loginViewModel.Username, args.UserPassword);
            if (success)
            {
                var vm = _viewModelCreator[nameof(ClientViewModel)];
                Navigator.CurrentViewModel = vm;
            }
        }

        //private void OnOpenView(OpenViewEventArgs args)
        //{
        //    ViewModel = _viewModelCreator[args.ViewModelName];
        //}

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

    }
}
