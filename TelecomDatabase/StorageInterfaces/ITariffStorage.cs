using TelecomLogic.StorageInterfaces;
using TelecomLogic.BindingModels;
using TelecomLogic.ViewModels;

namespace TelecomLogic.StorageInterfaces
{
    public interface ITariffStorage
    {
        List<TariffViewModel> GetFullList();
        List<TariffViewModel> GetFilteredList(TariffBindingModel model);
        TariffViewModel GetElement(TariffBindingModel model);
        void Insert(TariffBindingModel model);
        void Update(TariffBindingModel model);
        void Delete(TariffBindingModel model);
    }
}