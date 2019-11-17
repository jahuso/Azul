using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blue.DAL
{
    public class Patient
    {
        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(2)")]
        public string TypeID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string MobilePhone { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Mail { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Insurance { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime DOB { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(1)")]
        public string Sex { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Occupation { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Religion { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string AfiliationType { get; set; }
    }
}
