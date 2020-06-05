using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Covid19Tracker.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmedCasesController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<ConfirmedCaseByAge> GetByAge()
        {
            return new List<ConfirmedCaseByAge> { 
                new ConfirmedCaseByAge { Age = 50, NumberOfPatients = 500 }, 
                new ConfirmedCaseByAge { Age = 40, NumberOfPatients = 500 }
            };
        }
    }
}
