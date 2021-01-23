using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using schoolBagAssignment.Models;
using schoolBagAssignment.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace schoolBagAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolServices _services;

        public SchoolController(ISchoolServices services)
        {
            _services = services;
        }

        // GET: api/<SchoolController>
        [HttpGet]
        public ActionResult<List<School>> Get()
        {
            var schools = _services.GetAllSchools();
            if (schools.Count==0)
            {
                return NotFound("No schools to show !!!");
            }
            return Ok(schools);
        }

        // POST api/<SchoolController>
        [HttpPost]
        public ActionResult<School> Post(School school)
        {
           
           

            var newSchool = _services.AddSchool(school);
            if (newSchool == null)
            {
                return NotFound("Error, when adding data !!!");
            }

            return Ok(newSchool);
            
        }

        
    }
}
