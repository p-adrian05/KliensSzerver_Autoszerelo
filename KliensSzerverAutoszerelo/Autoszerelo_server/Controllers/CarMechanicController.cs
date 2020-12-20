using Autoszerelo_Szerver.Repositories;
using KliensSzerverAutoszerelo_Common.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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
        public ActionResult CreateWork(Work work)
        {
            WorkRepository.AddWork(work);
            
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult<Work> UpdateWork(Work work,long id) {
            Work dbWork = WorkRepository.GetWork(id);

            if(dbWork != null) {
                WorkRepository.UpdateWork(work);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteWork(long id) {
            Work work = WorkRepository.GetWork(id);

            if (work != null) {
                WorkRepository.DeleteWork(work);
                return Ok();
            }
            return NotFound();
        }
 
    }
}
