using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class ITEM
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string Name { get; set; }
        public string Section { get; set; }
        public string Purchased_date { get; set; }
        public int Unit_value { get; set; }
        public int Quantity { get; set; }

        ////////////////REFERENCES////////////////////

    }
}
