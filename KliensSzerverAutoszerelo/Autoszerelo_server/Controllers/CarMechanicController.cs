using Autoszerelo_Szerver.Repositories;
using KliensSzerverAutoszerelo_Common.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Autoszerelo_Szerver.Controllers
{

    [Route("api/work")]
    [ApiController]
    public class CarMechanicController : ControllerBase
    {
       

        [HttpGet]
        public ActionResult<IEnumerable<Work>> Get()
        {
            var works = WorkRepository.GetWorks();
            return Ok(works);
        }



        [HttpPost]
        public ActionResult Post(Work work)
        {
            WorkRepository.AddWork(work);

            return Ok();
        }


        
    }
}
