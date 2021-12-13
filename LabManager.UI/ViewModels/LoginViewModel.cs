using LabManager.UI.Events;
using LabManager.UI.State.Authenticators;
using Prism.Commands;
using Prism.Events;
using System;
using System.Windows.Input;

namespace LabManager.UI.ViewModels
{
    public class LoginViewModel : LoginViewModelBase
    {
        private string _username;
        private IEventAggregator _eventAggregator;

        public LoginViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            LoginCommand = new DelegateCommand<string>(OnLoginCommandExecute);
        }

        private void OnLoginCommandExecute(string args)
        {
            _eventAggregator.GetEvent<LoginAccountEvent>()
                    .Publish(
                new LoginAccountEventArgs
                {
                    UserPassword = args
                });
        }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }

    }

    public class LoginViewModelBase : ViewModelBase
    {
        public virtual string Username { get; set; }
    }
}
