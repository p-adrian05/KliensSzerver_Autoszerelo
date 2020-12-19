using KliensSzerverAutoszerelo_Common.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Autoszerelo_Szerver.Controllers
{

    [Route("api/works")]
    [ApiController]
    public class CarMechanicController : ControllerBase
    {
        private Work[] works = new Work[]
        {
            new Work{Id=1, FirstName="Gábor", LastName = "Nagy", CarBrand="TOYOTA", CarType="Type", Description="Leírás", LicensePlate="SSS111", WorkState=WorkState.Recorded},
            new Work{Id=2, FirstName="Sanyi", LastName = "Nagy", CarBrand="TOYOTA", CarType="Type", Description="Leírás", LicensePlate="SSK111", WorkState=WorkState.Recorded}
        };


        [HttpGet]
        public ActionResult<IEnumerable<Work>> Get()
        {
            return Ok(works);
        }

        [HttpGet("{id}")]
        public ActionResult<Work> Get(long id)
        {
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
    }
}
