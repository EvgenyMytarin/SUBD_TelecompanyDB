using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelecomLogic.BindingModels
{
    public class TariffBindingModel
    {
        public int? Id { get; set; }

        public string name_service { get; set; }

        public string name_tariff { get; set; }

        public string unit_tariff { get; set; }

        public int amount_tariff { get; set; }

        public decimal price_tariff { get; set; }

        public int amount_overtariff { get; set; }

        public decimal price_overtariff { get; set; }
    }
}