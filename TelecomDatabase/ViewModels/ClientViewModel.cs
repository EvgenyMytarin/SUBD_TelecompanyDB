using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TelecomLogic.ViewModels
{
    public class ClientViewModel
    {
        public int Id_client { get; set; }

        [DisplayName("Фамилия")]
        public string last_name { get; set; }
        [DisplayName("Имя")]
        public string name { get; set; }
        [DisplayName("Отчество")]
        public string middle_name { get; set; }
        [DisplayName("Телефон")]
        public string phone_number { get; set; }
    }
}