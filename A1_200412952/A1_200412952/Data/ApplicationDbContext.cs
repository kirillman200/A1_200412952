using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using A1_200412952.Models;

namespace A1_200412952.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<A1_200412952.Models.Animal> Animal { get; set; }
        public DbSet<A1_200412952.Models.Pet_Food> Pet_Food { get; set; }
    }
}
