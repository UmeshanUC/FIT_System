using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class BRANCH_MANAGER
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Empl_id { get; set; }
        public string Branch { get; set; }

        ////////////////REFERENCES////////////////////
    }
}
