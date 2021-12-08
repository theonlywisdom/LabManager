using LabManager.UI.Events;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LabManager.UI.ViewModels
{
    public class NavigationViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;

        public ICommand OpenViewCommand { get; private set; }

        public NavigationViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            OpenViewCommand = new DelegateCommand<Type>(OnOpenViewExecute);
        }

        private void OnOpenViewExecute(Type viewModelType)
        {
            _eventAggregator.GetEvent<OpenViewEvent>()
                .Publish(
                new OpenViewEventArgs
                {
                    ViewModelName = viewModelType.Name
                }
                );
        }
    }
}
