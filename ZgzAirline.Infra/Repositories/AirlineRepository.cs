using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZgzAirline.Core.Models;
using ZgzAirline.Core.Services;
using ZgzAirline.Infra.Context;

namespace ZgzAirline.Infra.Repositories
{
    public class AirlineRepository : IAirlineRepository
    {
        private readonly ZgzAirlineContext _context;
        private readonly DbSet<Airline> _entities;

        public AirlineRepository(ZgzAirlineContext context)
        {
            _context = context;
            _entities = context.Set<Airline>();
        }
        public List<Airline> GetAllAirlines()
        {
            try
            {
                var airlines = _entities.ToList();
                return airlines;
            }
            catch
            {
                return null;
            }
        }
    }
}
