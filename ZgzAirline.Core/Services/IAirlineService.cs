using System;
using System.Collections.Generic;
using System.Text;
using ZgzAirline.Core.Models;

namespace ZgzAirline.Core.Services
{
    public interface IAirlineService
    {
        List<Airline> GetAllAirlines();
    }
}
