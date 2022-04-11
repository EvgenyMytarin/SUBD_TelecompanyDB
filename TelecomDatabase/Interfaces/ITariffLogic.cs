using TelecomLogic.BindingModels;
using TelecomLogic.ViewModels;

namespace TelecomLogic.Interfaces
{
    public interface ITariffLogic
    {
        List<TariffViewModel> Read(TariffBindingModel model);
        void CreateOrUpdate(TariffBindingModel model);
        void Delete(TariffBindingModel model);
    }
}