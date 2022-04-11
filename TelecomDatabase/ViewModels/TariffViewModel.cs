using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelecomLogic.ViewModels
{
    public class TariffViewModel
    {
        public int Id_tariff { get; set; }

        [DisplayName("Услуга")]
        public string name_service { get; set; }

        [DisplayName("Название тарифа")]
        public string name_tariff { get; set; }

        [DisplayName("Единицы тарифа")]
        public string unit_tariff { get; set; }

        [DisplayName("Количество в тарифе")]
        public int amount_tariff { get; set; }

        [DisplayName("Цена тарифа")]
        public decimal price_tariff { get; set; }

        [DisplayName("Количество сверхтарифа")]
        public int amount_overtariff { get; set; }

        [DisplayName("Цена сверхтарифа")]
        public decimal price_overtariff { get; set; }
    }
}