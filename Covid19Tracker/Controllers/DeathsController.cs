using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19Tracker.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeathsController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<DeathByAge> GetByAge()
        {
            return new List<DeathByAge> {
                new DeathByAge { Age = 50, NumberOfPatients = 300 },
                new DeathByAge { Age = 40, NumberOfPatients = 240 }
            };
        }


        [HttpGet("[action]")]
        public IEnumerable<DeathPerDay> GetByDay()
        {
            return new List<DeathPerDay> {
                new DeathPerDay { DateTime = DateTime.Now.AddDays(1).ToShortDateString(), NumberOfPatients = 300 },
                new DeathPerDay { DateTime = DateTime.Now.ToShortDateString(), NumberOfPatients = 240 }
            };
        }

    }
}
