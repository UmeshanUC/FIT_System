using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class TRAINING_PROFILE
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string Shedule { get; set; }
        public string Diet { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }


        ////////////////REFERENCES////////////////////
    }
}
