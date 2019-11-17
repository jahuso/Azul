using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blue.DAL
{
    public class PhysicalExam
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int DetailID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string HearthFrequency { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string BreathingFrequency { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(6)")]
        public string ArterialPresure { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Temperature { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string O2SAT { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string Weight { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(4)")]
        public string Height { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string NeurologicalStatus { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string HeadandShoulder { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string PulmonaryCardio { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Abdomen { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string GenitoUrinary { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Limbs { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Skin { get; set; }
    }
}
