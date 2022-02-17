using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMS_API.Models
{
    public class Donation
    {
        public int ID { get; set; }
        public int DonorID { get; set; }
        public float Weight { get; set; }
        public int HBCount { get; set; }
        public int NoOfBottles { get; set; }
        public int? HospitalID { get; set; }
        public int? BloodCampID { get; set; }

        public BloodCamp BloodCamp { get; set; }
        public Hospital Hospital { get; set; }
        public Donor Donor { get; set; }
    }
}
