using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "jamica",
                    ShortName = "JN"
                },
                new Country
                {
                    Id = 2,
                    Name = "Ethiopia",
                    ShortName = "ET"
                },
                new Country
                {
                    Id = 3,
                    Name = "Egypt",
                    ShortName = "Eg"
                }
                );
            builder.Entity<Hotel>().HasData(
                    new Hotel
                    {
                        Id = 1,
                        Name = "plat",
                        Address = "Gonder",
                        CountryId = 1,
                        Rating = 4.5
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Gion",
                        Address = "Bahirdar",
                        CountryId = 2,
                        Rating = 2.5
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Nexus",
                        Address = "Addis Abab",
                        CountryId = 3,
                        Rating = 4.0
                    }
            );
        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
