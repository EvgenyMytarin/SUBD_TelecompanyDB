using TelecomLogic.BindingModels;
using TelecomLogic.ViewModels;

namespace TelecomLogic.Interfaces
{
    public interface IServiceLogic
    {
        List<ServiceViewModel> Read(ServiceBindingModel model);
        void CreateOrUpdate(ServiceBindingModel model);
        void Delete(ServiceBindingModel model);
    }
}