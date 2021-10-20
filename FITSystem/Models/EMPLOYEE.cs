using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class Employee
    {
        [Key]
        [ForeignKey("WorkRole")]
        public int EmplId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EpfNo { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int BankAccount { get; set; }
        public string JoinedDate  { get; set; }
        public int Telephone { get; set; }

        //Navigation Props

        public virtual WorkRole WorkRole { get; set; }
        public virtual Login Login { get; set; }
    }
}
