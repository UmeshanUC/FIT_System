using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class EMPLOYEE
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Empl_id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Epf_no { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public int Bank_Account { get; set; }
        public string Joined_Date  { get; set; }
        public int Telephone { get; set; }

        ////////////////REFERENCES////////////////////
    }
}
