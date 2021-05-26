using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class LOGIN
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("WORK_ROLE")]
        public int Empl_id { get; set; }
        [Required]
        public string Username{ get; set; } // Make it float later ans match the switch case in login Btn
        [Required]
        public string Passwd { get; set; }

        //////////////REFERENCES////////////////////
        public WORK_ROLE WORK_ROLE { get; set; }
    }
}
