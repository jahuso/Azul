using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blue.DAL
{
    public class ConsultingRoom
    {
        [Key]
        public string ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Status { get; set; }
    }
}
