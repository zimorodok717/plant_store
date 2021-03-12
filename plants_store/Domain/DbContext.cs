using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using online_pharmacy.Domain.Entities;

namespace online_pharmacy.Domain
{
    public class DbContext:IdentityDbContext<IdentityUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder miBuilder)
        {
            base.OnModelCreating(miBuilder);
        }

    }
}
