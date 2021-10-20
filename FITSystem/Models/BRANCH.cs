using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FITSystem.Models
{
    public class Branch
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int BranchCode { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Telephone { get; set; }
        public string Location { get; set; }

        ////////////////REFERENCES////////////////////
    }
}
