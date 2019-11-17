using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blue.DAL
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Appointment { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Type { get; set; }
    }
}
