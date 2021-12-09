using System.Threading.Tasks;

namespace LabManager.UI.ViewModels
{
    public abstract class DetailViewModelBase : ViewModelBase, IDetailViewModel
    {
        public abstract Task LoadAsync(int? id);
    }
}
