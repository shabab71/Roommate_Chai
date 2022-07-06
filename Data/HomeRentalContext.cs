using HomeRental.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeRental.Data
{
    public class HomeRentalContext : IdentityDbContext<ApplicationUser>
    {
        public HomeRentalContext(DbContextOptions<HomeRentalContext> options)
            : base(options)
        {

        }
        public DbSet<Rooms> Rooms { get; set; }
    }

}