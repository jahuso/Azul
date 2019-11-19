using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blue.DAL.Models
{
    public class Doctor
    {
        [Key]
        public int Code { get; set; }
        [Required]
        [Column(TypeName= "nvarchar(15)")]
        public string IDNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string MobilePhone { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Mail { get; set; }  
    }
}
