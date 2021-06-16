using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FITSystem.Models
{
    public class SALARY_RATE
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Role_ID { get; set; }
        public int Base_salary { get; set; }
        public int Implemented_date { get; set; }
        

        ////////////////REFERENCES////////////////////
    }
}
