using SmartTech.Services.Students;
using SmartTechApi.Extensions;
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
                //get all students from the service, map each student entity to student model
                return Ok(_studentService.GetStudents().Select(e => e.ToModel()));
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
                return Ok(_studentService.GetById(id).ToModel());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/student/delete")]
        public IHttpActionResult DeleteStudent(int id)
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
        [Route("api/student/add")]
        public IHttpActionResult AddStudent([FromBody]StudentModel studentModel)
        {
            try
            {
                if (studentModel == null)
                    throw new ArgumentNullException(nameof(studentModel), "student model can not be null");

                var entity = studentModel.ToEntity();
                _studentService.Insert(entity);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("api/student/edit")]
        public IHttpActionResult EditStudent([FromBody]StudentModel studentModel)
        {
            try
            {
                if (studentModel == null)
                    throw new ArgumentNullException(nameof(studentModel), "student model can not be null");
                if (studentModel.Id <= 0)
                    throw new ArgumentException("student id must be positive integer.");

                var entity = _studentService.GetById(studentModel.Id);
                if (entity == null)
                    throw new ArgumentException("There is no student with this id.");

                var newStudent = studentModel.ToEntity(entity);
                _studentService.Update(newStudent);
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
