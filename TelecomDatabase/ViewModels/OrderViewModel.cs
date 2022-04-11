using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelecomLogic.ViewModels
{
    public class OrderViewModel
    {
        public int Id_order { get; set; }

        [DisplayName("Дата заключения")]
        public DateTime date_conclusion { get; set; }

        [DisplayName("Услуга")]
        public string name_service { get; set; }

        [DisplayName("Тариф")]
        public string name_tariff { get; set; }

        [DisplayName("Клиент")]
        public string name_client { get; set; }
    }
}