using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blue.DAL.Models
{
    public class Appointment
    {
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string Doctor { get; set; }
        public string Patient { get; set; }
        public string AfiliationType { get; set; }
        public string AppointmentType { get; set; }
        public string Status { get; set; }
        public string ConsultingRoom { get; set; }
    }
}
