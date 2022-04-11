using TelecomLogic.StorageInterfaces;
using TelecomLogic.BindingModels;
using TelecomLogic.ViewModels;
using TelecomLogic.Interfaces;

namespace TelecomLogic.Logic
{
    public class TariffLogic : ITariffLogic
    {
        private readonly ITariffStorage _tariffStorage;
        public TariffLogic(ITariffStorage tariffStorage)
        {
            _tariffStorage = tariffStorage;
        }
        public List<TariffViewModel> Read(TariffBindingModel model)
        {
            if (model == null)
            {
                return _tariffStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<TariffViewModel> { _tariffStorage.GetElement(model) };
            }
            return _tariffStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(TariffBindingModel model)
        {
            _tariffStorage.Insert(new TariffBindingModel
            {
                name_tariff = model.name_tariff,
                amount_overtariff = model.amount_overtariff,
                amount_tariff = model.amount_tariff,
                price_overtariff = model.price_overtariff,
                price_tariff = model.price_tariff,
                unit_tariff = model.unit_tariff,
                name_service = model.name_service,
            });
        }
        public void Delete(TariffBindingModel model)
        {
            var element = _tariffStorage.GetElement(new TariffBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _tariffStorage.Delete(model);
        }
    }
}
