﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Core.Models
{
    public class Feature:BaseEntity
    {
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Icon { get; set; }
    }
}
