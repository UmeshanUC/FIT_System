using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Database
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
    }
    //////////////////////////////////////------------------////////////////////////////////////////////
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserID { get; set; }
        [Required]
        public string PassWd { get; set; }
        [Required]
        public int AccessLevel { get; set; } // Make it float later ans match the switch case in login Btn
    }
    //////////////////////////////////////------------------////////////////////////////////////////////
    public class UserLoginLog
    {
        [Key, Column(Order = 0)]
        public string UserID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime LoggedTS { get; set; }
        public DateTime? LogOutTS { get; set; }
    }
    //////////////////////////////////////------------------////////////////////////////////////////////




}
