﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Models
{
    public class PRODUCT
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Product_id { get; set; }
        public string Details { get; set; }
        public string Supplier { get; set; }
        public int Price { get; set; }
        

        ////////////////REFERENCES////////////////////
    }
}