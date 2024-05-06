﻿using CarRental.Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string CarImageURL { get; set; }
        public CarTransType Trans_Type { get; set; }
        public int Seats { get; set; }
        public int Cost_Per_Day { get; set; }
        public bool IsAvailable { get; set; }

        [ForeignKey("User")]
        public string OwnerId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; } = new HashSet<Rental>();

    }
}
