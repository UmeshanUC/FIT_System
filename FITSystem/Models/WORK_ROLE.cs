using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class WORK_ROLE
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("PERMISSIONS")]
        public int Empl_id { get; set; }
        [Required] 
        public int Role_id { get; set; }
        [Required]
        public string  Role_name { get; set; }
        public string Description { get; set; }

        ////////////////REFERENCES////////////////////

        public  PERMISSIONS PERMISSIONS { get; set; }
        public  LOGIN LOGIN{ get; set; }
        //public ICollection<PERMISSIONS> PERMISSIONS { get; set; }
        //public ICollection<LOGIN> LOGIN { get; set; }


    }
}
