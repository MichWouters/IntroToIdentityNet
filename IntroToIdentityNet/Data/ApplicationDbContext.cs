using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IntroToIdentityNet.Models;
using IntroToIdentityNet;

namespace IntroToIdentityNet.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<IntroToIdentityNet.Models.Animal> Animal { get; set; }
        public DbSet<IntroToIdentityNet.Movie> Movie { get; set; }
    }
}
