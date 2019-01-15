using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImageName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
