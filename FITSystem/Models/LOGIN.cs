using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class Login
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("Employee")]
        public int EmplId { get; set; }
        [Required]
        public string Username{ get; set; } // Make it float later and match the switch case in login Btn
        [Required]
        public string Passwd { get; set; }

        //Navigation Props
        public virtual Employee Employee { get; set; }
    }
}
