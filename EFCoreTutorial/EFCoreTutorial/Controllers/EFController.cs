using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreTutorial.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFCoreTutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EFController : ControllerBase
    {
        EfCoreContext _efCoreContext;
        public EFController(EfCoreContext efCoreContext)
        {
            _efCoreContext = efCoreContext;
        }

        [HttpGet]
        [Route("create")]
        public IActionResult CreateDb()
        {
            _efCoreContext.Database.EnsureCreated();
            return Ok();
        }
    }
}
