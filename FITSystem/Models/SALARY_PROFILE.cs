using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class SALARY_PROFILE
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Empl_id { get; set; }
        public int Base_salary { get; set; }
        public int Deduction { get; set; }
        public int Bonus { get; set; }
        public int Net_salary { get; set; }

        ////////////////REFERENCES////////////////////
    }
}
