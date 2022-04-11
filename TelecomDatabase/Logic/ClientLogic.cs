using TelecomLogic.StorageInterfaces;
using TelecomLogic.BindingModels;
using TelecomLogic.ViewModels;
using TelecomLogic.Interfaces;

namespace TelecomLogic.Logic
{
    public class ClientLogic : IClientLogic
    {
        private readonly IClientStorage _clientStorage;
        public ClientLogic(IClientStorage clientStorage)
        {
            _clientStorage = clientStorage;
        }
        public List<ClientViewModel> Read(ClientBindingModel model)
        {
            if (model == null)
            {
                return _clientStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ClientViewModel> { _clientStorage.GetElement(model) };
            }
            return _clientStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(ClientBindingModel model)
        {
            _clientStorage.Insert(new ClientBindingModel
            {
                last_name = model.last_name,
                name = model.name,
                middle_name = model.middle_name,
                phone_number = model.phone_number
            });
        }
        public void Delete(ClientBindingModel model)
        {
            var element = _clientStorage.GetElement(new ClientBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _clientStorage.Delete(model);
        }
    }
}