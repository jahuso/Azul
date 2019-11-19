using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blue.DAL.Models
{
    public class Patient
    {
        public string ID { get; set; }
        public string TypeID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Insurance { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public string Occupation { get; set; }
        public string Religion { get; set; }
        public string AfiliationType { get; set; }
    }
}
