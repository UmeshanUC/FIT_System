using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class MEMBER
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Member_id { get; set; } 
        public string Name { get; set; }
        public int Telephone { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public string Pic { get; set; } //datatype
        public string Package { set; get; }

        ////////////////REFERENCES////////////////////
    }
}
