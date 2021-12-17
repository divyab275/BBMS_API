using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BBMS_API.Models.Auth;

namespace BBMS_API.Models
{
    public class ProvidenceDbContext : IdentityDbContext<ApplicationUser> // DbContext
    {
        public DbSet<Dept> Depts { get; set; }
        public DbSet<BloodBank> BloodBanks { get; set; }
        public DbSet<BloodCamp> BloodCamps { get; set; }

        public DbSet<Donation> Donations { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Inventory> Inventories { get; set; }




        public ProvidenceDbContext() : base()
        {

        }

        public ProvidenceDbContext(DbContextOptions<ProvidenceDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
