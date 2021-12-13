using LabManager.UI.State.Authenticators;
using Prism.Commands;
using Prism.Events;
using System;
using System.Windows.Input;

namespace LabManager.UI.ViewModels
{
    public class LoginViewModel : LoginViewModelBase
    {
        private string _userName;
        private IEventAggregator _eventAggregator;

        public LoginViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            LoginCommand = new DelegateCommand<IAuthenticator>(OnLoginCommandExecute);
        }

        private void OnLoginCommandExecute(IAuthenticator obj)
        {
            throw new NotImplementedException();
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }

    }

    public class LoginViewModelBase : ViewModelBase
    {

    }
}
