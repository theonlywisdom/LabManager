using LabManager.UI.Data.Lookups;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LabManager.UI.ViewModels
{
    public class ClientCollectionViewModel : ViewModelBase, ICollectionViewModel
    {
        private IClientLookupService _clientLookupService;
        private IEventAggregator _eventAggregator;

        public ClientCollectionViewModel(IClientLookupService clientLookupService, IEventAggregator eventAggregator)
        {
            _clientLookupService = clientLookupService;
            Clients = new ObservableCollection<ClientCollectionItemViewModel>();
            _eventAggregator = eventAggregator;
        }

        public async Task LoadAsync()
        {
            var lookup = await _clientLookupService.GetAllAsync();
            Clients.Clear();
            foreach (var item in lookup)
            {
                Clients.Add(new ClientCollectionItemViewModel(item.Id, item.Code,
                    item.Name, item.Address, item.Postcode, item.Person,
                    item.JobTitle, item.Phone, item.Email, nameof(ClientDetailViewModel), _eventAggregator));
            }
        }

        public ObservableCollection<ClientCollectionItemViewModel> Clients { get; }

    }
}
