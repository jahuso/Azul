using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blue.DAL.Models
{
    public class HistoryDetail
    {
        public string ID { get; set; }
        public string History { get; set; }
        public DateTime Fecha { get; set; }
        public string Reason { get; set; }
        public string CurrentDisease { get; set; }
        //Complementar con la informacion del backlog
    }
}
