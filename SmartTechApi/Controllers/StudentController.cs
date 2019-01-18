using SmartTech.Services.Students;
using SmartTechApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartTechApi.Controllers
{
    public class StudentController : ApiController
    {
        #region Fields

        private readonly IStudentService _studentService;

        #endregion

        #region Ctor
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_studentService.GetStudents());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(_studentService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("api/student/delete-student")]
        public IHttpActionResult DeleteStudent([FromBody]int id)
        {
            try
            {
                _studentService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("api/student/add-student")]
        public IHttpActionResult AddStudent([FromBody]StudentModel studentModel)
        {
            try
            {
               // _studentService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        #endregion
    }
}
