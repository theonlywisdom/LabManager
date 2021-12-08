using LabManager.UI.Events;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.ViewModels
{
    public class ClientViewModel
    {
        private IEventAggregator _eventAggregator;

        public ClientViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenViewEvent>()
                .Subscribe(OnOpenView);
        }

        private void OnOpenView(OpenViewEventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
