using SmartTech.Services.Faculties;
using SmartTechApi.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartTechApi.Controllers
{
    public class FacultyController : ApiController
    {
        private readonly IFacultyService _facultySevice;

        public FacultyController(IFacultyService facultySevice)
        {
            _facultySevice = facultySevice;
        }



        public IHttpActionResult Get()
        {
            try
            {
                //get the faculties, convert the entities to models and return them
                return Ok(_facultySevice.GetFaculties().Select(e=>e.ToModel()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
