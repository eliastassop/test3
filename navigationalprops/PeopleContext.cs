using Microsoft.EntityFrameworkCore;
using navigationalprops.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace navigationalprops
{
    public class PeopleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost;Database=Demo;User Id=sa;Password=admin!@#123;");
        }
        public PeopleContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Email> Emails { get; set; }

    }
}
