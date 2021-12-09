using LabManager.UI.ViewModels;

namespace LabManager.UI.State
{
    public interface INavigator
    {
        public ViewModelBase CurrentViewModel { get; set; }
    }

    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

    }
}
