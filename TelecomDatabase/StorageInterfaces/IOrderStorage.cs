using TelecomLogic.StorageInterfaces;
using TelecomLogic.BindingModels;
using TelecomLogic.ViewModels;

namespace TelecomLogic.StorageInterfaces
{
    public interface IOrderStorage
    {
        List<OrderViewModel> GetFullList();
        List<OrderViewModel> GetFilteredList(OrderBindingModel model);
        OrderViewModel GetElement(OrderBindingModel model);
        void Insert(OrderBindingModel model);
        void Update(OrderBindingModel model);
        void Delete(OrderBindingModel model);
    }
}