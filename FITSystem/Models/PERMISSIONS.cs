using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class PERMISSIONS
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Perm_id { get; set; }
        public int Role_id { get; set; }
        public string Perm_Description { get; set; }

        ////////////////REFERENCES////////////////////
       //public virtual WORK_ROLE WORK_ROLE{ get; set; }
    }
}
