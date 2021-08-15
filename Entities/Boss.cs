using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Boss
    {
        [Required]
        public int Id { get; set; }

        public string Libelle { get; set; }

        [Required]
        public string Flag { get; set; }
    }
}
