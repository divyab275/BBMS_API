using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBMS_API.Models
{
    public class Donor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ContactNo { get; set; }

    }
}
