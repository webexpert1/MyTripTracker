using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Data
{
    public class TripContext: DbContext
    {
        private readonly TripContext context;

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
        }

        public TripContext(DbContextOptions<TripContext> options): base(options)
        {
        }

        //public static void SeedData(this ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Trip>().HasData(
        //         new Trip { Id = 1, Name = "MVP", StartDate = new DateTime(2020, 2, 1), EndDate = new DateTime(2020, 03, 01) },
        //         new Trip { Id = 2, Name = "Dev Intersection", StartDate = new DateTime(2020, 03, 3), EndDate = new DateTime(2020, 03, 04) },
        //         new Trip { Id = 3, Name = "Build 2020", StartDate = new DateTime(2020, 04, 5), EndDate = new DateTime(2020, 04, 06) }
        //        );
        //}
    }
}
