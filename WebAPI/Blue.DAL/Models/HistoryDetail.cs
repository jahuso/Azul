using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blue.DAL
{
    public class HistoryDetail
    {
        [Key]
        public int DetailID { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int HistoryID { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Reason { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string CurrentDisease { get; set; }
        //Complementar con la informacion del backlog
    }
}
