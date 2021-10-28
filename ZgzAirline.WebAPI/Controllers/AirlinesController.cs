using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZgzAirline.Core.Models;
using ZgzAirline.WebAPI.Data;

namespace ZgzAirline.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlinesController : ControllerBase
    {
        private readonly ZgzAirlineWebAPIContext _context;

        public AirlinesController(ZgzAirlineWebAPIContext context)
        {
            _context = context;
        }
        [HttpGet("[action]")]
        public List<Airline> GetAllAirlines()
        {
            return _context.Airline.ToList();
        }
    }
}
