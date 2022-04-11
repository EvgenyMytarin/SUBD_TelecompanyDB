using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelecomDB.Models
{
    public class Tariff
    {
        public int Id { get; set; }

        [ForeignKey("Id_service")]
        public string name_service { get; set; }

        [Required]
        public string name_tariff { get; set; }

        [Required]
        public string unit_tariff { get; set; }

        [Required]
        public int amount_tariff { get; set; }

        [Required]
        public decimal price_tariff { get; set; }

        [Required]
        public int amount_overtariff { get; set; }

        [Required]
        public decimal price_overtariff { get; set; }
    }
}