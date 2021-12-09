using LabManager.UI.State;

namespace LabManager.UI.ViewModels
{
    public class MainViewModel
    {
        public INavigator Navigator { get; set; }

        public ViewModelBase ViewModel { get; private set; }
        public MainViewModel(ViewModelBase viewModel, INavigator navigator)
        {
            ViewModel = viewModel;
            Navigator = navigator;
            Navigator.CurrentViewModel = ViewModel;
        }
    }
}
