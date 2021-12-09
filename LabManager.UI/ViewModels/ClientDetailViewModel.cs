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
                await _clientRepository.GetByIdAsync(clientId.Value);
            }
        }
    }

    public interface IClientDetailViewModel : IDetailViewModel
    {

    }
}
