using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Glitch
    {
        [Required]
        public int Id { get; set; }

        public string Libelle { get; set; }

        [Required]
        public string Flag { get; set; }
    }
}
