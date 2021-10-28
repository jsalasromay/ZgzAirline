using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZgzAirline.Core.Models;
using ZgzAirline.Infra.Mapping;

namespace ZgzAirline.Infra.Context
{
    public class ZgzAirlineContext : DbContext
    {
        public virtual DbSet<Airline> Airlines { get; set; }
        public ZgzAirlineContext(DbContextOptions<ZgzAirlineContext> options) : base(options)
        {
        }
        public ZgzAirlineContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AirlineMapping());
        }
    }
}
