using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBMS_API.Models
{
    public enum BloodGroup
    {
        APositive,ANegative,BPositive,BNegative,ABPositive,ABNegative,OPositive,ONegative
    }
    public class Inventory
    {
        public int ID { get; set; }
        public int NoOfBottles { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public int BloodBankID { get; set; }
        public BloodBank BloodBank { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }
    }
}
