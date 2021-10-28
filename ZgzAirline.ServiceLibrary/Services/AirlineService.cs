using System;
using System.Collections.Generic;
using System.Text;
using ZgzAirline.Core.Models;
using ZgzAirline.Core.Services;

namespace ZgzAirline.ServiceLibrary.Services
{
    public class AirlineService : IAirlineService
    {
        private readonly IAirlineRepository _airlineRepository;

        public AirlineService(IAirlineRepository airlineRepository)
        {
            _airlineRepository = airlineRepository;
        }
        public List<Airline> GetAllAirlines()
        {
            return _airlineRepository.GetAllAirlines();
        }
    }
}
