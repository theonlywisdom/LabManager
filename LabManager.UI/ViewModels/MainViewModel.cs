using LabManager.UI.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
