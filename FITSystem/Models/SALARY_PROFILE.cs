﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class SalaryProfile
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int EmplId { get; set; }
        public int BaseSalary { get; set; }
        public int Deduction { get; set; }
        public int Bonus { get; set; }
        public int NetSalary { get; set; }

        ////////////////REFERENCES////////////////////
    }
}
