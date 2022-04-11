using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelecomDB.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        public string name { get; set; }

        public string middle_name { get; set; }

        public string phone_number { get; set; }
    }
}