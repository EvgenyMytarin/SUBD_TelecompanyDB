using TelecomLogic.StorageInterfaces;
using TelecomLogic.BindingModels;
using TelecomLogic.ViewModels;
using TelecomLogic.Interfaces;

namespace TelecomLogic.Logic
{
    public class ServiceLogic : IServiceLogic
    {
        private readonly IServiceStorage _serviceStorage;
        public ServiceLogic(IServiceStorage serviceStorage)
        {
            _serviceStorage = serviceStorage;
        }
        public List<ServiceViewModel> Read(ServiceBindingModel model)
        {
            if (model == null)
            {
                return _serviceStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ServiceViewModel> { _serviceStorage.GetElement(model) };
            }
            return _serviceStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(ServiceBindingModel model)
        {
            _serviceStorage.Insert(new ServiceBindingModel
            {
                name_service = model.name_service,
                availability_overtariff = model.availability_overtariff
            }) ;
        }
        public void Delete(ServiceBindingModel model)
        {
            var element = _serviceStorage.GetElement(new ServiceBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _serviceStorage.Delete(model);
        }
    }
}