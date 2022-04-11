using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelecomDB.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime date_conclusion { get; set; }

        [ForeignKey("Id_service")]
        public string name_service { get; set; }

        [ForeignKey("Id_tariff")]
        public string name_tariff { get; set; }

        [ForeignKey("Id_client")]
        public string name_client { get; set; }
    }
}