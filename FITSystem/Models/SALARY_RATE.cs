using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FITSystem.Models
{
    public class SalaryRate
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int RoleId { get; set; }
        public int BaseSalary { get; set; }
        public int ImplementedDate { get; set; }
        

        ////////////////REFERENCES////////////////////
    }
}
