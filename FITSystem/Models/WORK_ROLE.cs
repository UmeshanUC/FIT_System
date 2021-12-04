using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Utilities.IO.Pem;

namespace FITSystem.Models
{
    public class WorkRole
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; } //  Permission ID - Taken to Permission Granting
        [Required]
        public string  RoleName { get; set; }
        public string Description { get; set; }

        #region NavigationProps
        #endregion

    }
}
