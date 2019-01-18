using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartTechApi.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImageName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FacultyName { get; set; }

    }
}