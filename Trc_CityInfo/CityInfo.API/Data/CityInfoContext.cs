﻿using CityInfo.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Data
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
           : base(options)
        {
            // Database.EnsureCreated();
            Database.Migrate();
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
    }
}
