using SmartTech.Services.Faculties;
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
                var data = _facultySevice.GetFaculties();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
