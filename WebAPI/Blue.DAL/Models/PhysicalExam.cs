using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class PhysicalExam
    {
        public string ID { get; set; }
        public string HistoryDetail { get; set; }
        public string HearthFrequency { get; set; }
        public string BreathFrequency { get; set; }
        public string ArterialPresure { get; set; }
        public string Temperature { get; set; }
        public string SAT02 { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string NeurologicalStatus { get; set; }
        public string HeadandShoulder { get; set; }
        public string CardioPulmonar { get; set; }
        public string Abdomen { get; set; }
        public string GenitoUrinal { get; set; }
        public string Limbs { get; set; }
        public string Skin { get; set; }
    }
}
