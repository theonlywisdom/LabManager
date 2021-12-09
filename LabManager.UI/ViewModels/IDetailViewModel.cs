using System.Threading.Tasks;

namespace LabManager.UI.ViewModels
{
    public interface IDetailViewModel
    {
        Task LoadAsync(int? id);
    }
    }
