using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class LOGIN_LOG
    {
        [Key, Column(Order = 0)]
        public string Empl_id { get; set; }
        [Key, Column(Order = 1)]
        public DateTime LoggedTS { get; set; }
        public DateTime? LogOutTS { get; set; }
    }
}
