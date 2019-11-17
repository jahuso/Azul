using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blue.DAL
{
    public class Appointment
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime Hour { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Doctor { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Patient { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string AppointmentType { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Status { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string ConsultingRoom { get; set; }
    }
}
