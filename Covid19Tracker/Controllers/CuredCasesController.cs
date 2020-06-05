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
    public class CuredCasesController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<CuredCaseByAge> GetByAge()
        {
            return new List<CuredCaseByAge> {
                new CuredCaseByAge { Age = 50, NumberOfPatients = 200 },
                new CuredCaseByAge { Age = 40, NumberOfPatients = 260 }
            };
        }
    }
}
