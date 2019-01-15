using SmartTech.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech.Services.Students
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetById(int id);
        void Insert(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
