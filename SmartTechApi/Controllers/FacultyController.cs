﻿using SmartTech.Services.Faculties;
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
        #region Fields
        private readonly IFacultyService _facultySevice;

        #endregion

        #region Ctor

        //inject the faculty service in the constructor
        public FacultyController(IFacultyService facultySevice)
        {
            _facultySevice = facultySevice;
        }

        #endregion


        #region Actions

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

        #endregion
    }
}
