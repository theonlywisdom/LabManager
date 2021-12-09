using LabManager.Model;
using LabManager.UI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.UI.ViewModels
{
    public class ClientDetailViewModel : DetailViewModelBase, IClientDetailViewModel
    {
        private IClientRepository _clientRepository;

        public ClientDetailViewModel(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public override async Task LoadAsync(int? clientId)
        {
            if (clientId.HasValue)
            {
               Client = await _clientRepository.GetByIdAsync(clientId.Value);
            }
        }

        private Client _client;

        public Client Client
        {
            get => _client;
            set
            {
                _client = value;
                OnPropertyChanged();
            }
        }

    }

    public interface IClientDetailViewModel : IDetailViewModel
    {

    }
}
