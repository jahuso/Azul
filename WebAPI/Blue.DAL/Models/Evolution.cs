using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blue.DAL
{
    public class Evolution
    {
        [Key]
        public string ID { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int HistoryID { get; set; }
    }
}
