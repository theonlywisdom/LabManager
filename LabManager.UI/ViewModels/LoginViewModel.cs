using LabManager.UI.State;
using System.Windows.Input;

namespace LabManager.UI.ViewModels
{
    public class LoginViewModel : LoginViewModelBase
    {
        private string _username;

        public string Username
        {
            get
            {
                return _username;
            }
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

    }

}
