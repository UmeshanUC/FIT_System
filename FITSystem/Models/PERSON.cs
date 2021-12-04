using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class Person
    {
        [Key]
        public string NIC { get; set; }
        public string Name { get; set; }
        [ForeignKey("WorkRole")]
        public int WorkRoleID { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime JoinedDate { get; set; }
        public int Telephone { get; set; }
        public string Pic { get; set; } //datatype ?


        #region NavigationProps
        public virtual WorkRole WorkRole { get; set; }
        public virtual Login Login { get; set; }
        public virtual Member Member{ get; set; }
        public virtual Employee Employee{ get; set; }
        #endregion

    }
}
