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
        [ForeignKey("Person")]
        public string EmplId { get; set; }
        [Required]
        public string Username{ get; set; } 
        [Required]
        public string Passwd { get; set; }
        [Required][ForeignKey("WorkRole")]
        public int PermissionLevel { get; set; }

        #region NavigationProps
        public virtual Person Person{ get; set; }
        public virtual WorkRole WorkRole{ get; set; }
        #endregion
    }
}
