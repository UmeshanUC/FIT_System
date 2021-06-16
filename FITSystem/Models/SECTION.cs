using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class SECTION
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Section { get; set; }
        public string Section_manager { get; set; }


            ////////////////REFERENCES////////////////////
        
    }
}
