﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNC_API.Models
{
    [Table("Depts")]
    public class Dept
    {
      
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int DeptNo { get; set; }

        public string DeptName { get; set; }

        public string  Location { get; set; }

    }
}
