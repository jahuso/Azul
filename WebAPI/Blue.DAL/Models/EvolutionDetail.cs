using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blue.DAL
{
    public class EvolutionDetail
    {
        [Key]
        public int DetailID { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int EvolutionID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Subjetive { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Objetive { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(800)")]
        public string Analisis { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Temperature { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Justification { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(800)")]
        public string Diagnose { get; set; }
    }
}
