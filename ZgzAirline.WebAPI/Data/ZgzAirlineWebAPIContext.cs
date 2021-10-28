using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZgzAirline.Core.Models;

namespace ZgzAirline.WebAPI.Data
{
    public class ZgzAirlineWebAPIContext : DbContext
    {
        public ZgzAirlineWebAPIContext (DbContextOptions<ZgzAirlineWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ZgzAirline.Core.Models.Airline> Airline { get; set; }
    }
}
