using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blue.DAL
{
    public class ClinicHistory
    {
        [Key]
        public string ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string PatientID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(800)")]
        public string AnalisisPlan { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(800)")]
        public string Diagnostic { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string NeurologicalStatus { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string HeadandShoulder { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CardioPulmonar { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Abdomen { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string GenitoUrinary { get; set; }
    }
}
