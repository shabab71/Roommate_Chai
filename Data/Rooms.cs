﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeRental.Data
{
    public class Rooms
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Owner { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Location { get; set; }

        public string Rent { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
