using TelecomLogic.StorageInterfaces;
using TelecomLogic.BindingModels;
using TelecomLogic.ViewModels;
using TelecomLogic.Interfaces;

namespace TelecomLogic.Logic
{
    public class OrderLogic : IOrderLogic
    {
        private readonly IOrderStorage _orderStorage;
        public OrderLogic(IOrderStorage orderStorage)
        {
            _orderStorage = orderStorage;
        }
        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            if (model == null)
            {
                return _orderStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<OrderViewModel> { _orderStorage.GetElement(model) };
            }
            return _orderStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(OrderBindingModel model)
        {
            _orderStorage.Insert(new OrderBindingModel
            {                
                name_client = model.name_client,
                name_service = model.name_service,
                name_tariff = model.name_tariff,
                date_conclusion = model.date_conclusion,
            });
        }
        public void Delete(OrderBindingModel model)
        {
            var element = _orderStorage.GetElement(new OrderBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _orderStorage.Delete(model);
        }
    }
}
