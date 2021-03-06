﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlatExpenseCalculator.Models
{
    public class Room
    {
        public int Id { get; set; }
        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        public string Name { get; set; }
        public float AreaM2 { get; set; }
        public IEnumerable<ApplicationUser> Occupants { get; set; }
        public decimal RentPerWeek { get; set; }

    }
}
