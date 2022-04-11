using TelecomLogic.StorageInterfaces;
using TelecomLogic.BindingModels;
using TelecomLogic.ViewModels;

namespace TelecomLogic.StorageInterfaces
{
    public interface IServiceStorage
    {
        List<ServiceViewModel> GetFullList();
        List<ServiceViewModel> GetFilteredList(ServiceBindingModel model);
        ServiceViewModel GetElement(ServiceBindingModel model);
        void Insert(ServiceBindingModel model);
        void Update(ServiceBindingModel model);
        void Delete(ServiceBindingModel model);
    }
}