using LabManager.UI.Data.Lookups;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LabManager.UI.ViewModels
{
    public class ClientCollectionViewModel : ViewModelBase, ICollectionViewModel
    {
        private IClientLookupService _clientLookupService;

        public ClientCollectionViewModel(IClientLookupService clientLookupService)
        {
            _clientLookupService = clientLookupService;
            Clients = new ObservableCollection<ClientCollectionItemViewModel>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _clientLookupService.GetAllAsync();
            Clients.Clear();
            foreach (var item in lookup)
            {
                Clients.Add(new ClientCollectionItemViewModel(item.Id, item.Code,
                    item.Name, item.Address, item.Postcode, item.Person,
                    item.JobTitle, item.Phone, item.Email));
            }
        }

        public ObservableCollection<ClientCollectionItemViewModel> Clients { get; }

    }
}
