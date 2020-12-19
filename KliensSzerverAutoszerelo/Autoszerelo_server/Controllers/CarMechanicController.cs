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

        [HttpGet("{id}")]
        public ActionResult<Work> Get(long id)
        {
            var works = WorkRepository.GetWorks();
            var work = works.FirstOrDefault(x => x.Id == id);

            if (work != null)
            {
                return Ok(work);
            }
            else
            {
                return NotFound();
            }
            
        }

        [HttpPost]
        public ActionResult Post(Work work)
        {
            var works = WorkRepository.GetWorks();

            var newId = GetNewId(works);
            work.Id = newId;

            works.Add(work);
            WorkRepository.StoreWorks(works);

            return Ok();
        }


        private long GetNewId(IList<Work> works)
        {
            long id = 0;

            foreach (var work in works)
            {
                if (id < work.Id)
                {
                    id = work.Id;
                }
            }

            return id + 1;
        }
    }
}
