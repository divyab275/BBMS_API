using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DNC_API.Models.Auth;

namespace DNC_API.Models
{
    public class ProvidenceDbContext : IdentityDbContext<ApplicationUser> // DbContext
    {
        public DbSet<Dept> Depts { get; set; }

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
