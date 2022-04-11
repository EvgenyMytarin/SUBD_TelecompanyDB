using System.ComponentModel.DataAnnotations;

namespace TelecomDB.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string name_service { get; set; }
        [Required]
        public string availability_overtariff { get; set; }

    }
}