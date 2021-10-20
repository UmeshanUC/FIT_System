using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class Permissions
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("WorkRole")]
        public int RoleId { get; set; }
        [Required]
        public int PermId { get; set; }
        public string PermDescription { get; set; }

        //Navigation Props
        public virtual WorkRole WorkRole { get; set; }
    }
}
