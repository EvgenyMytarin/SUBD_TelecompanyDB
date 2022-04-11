using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TelecomLogic.ViewModels
{
    public class ServiceViewModel
    {
        public int Id_service { get; set; }

        [DisplayName("Название услуги")]
        public string name_service { get; set; }

        [DisplayName("Наличие сверхтарифа")]
        public string availability_overtariff { get; set; } 
    }
}