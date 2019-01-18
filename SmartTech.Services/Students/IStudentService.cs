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
        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns></returns>
        IEnumerable<Student> GetStudents();

        /// <summary>
        /// Get student by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Student GetById(int id);

        /// <summary>
        /// Insert given student
        /// </summary>
        /// <param name="student"></param>
        void Insert(Student student);

        /// <summary>
        /// Update given student
        /// </summary>
        /// <param name="student"></param>
        void Update(Student student);

        /// <summary>
        /// Delete Student
        /// </summary>
        /// <param name="student"></param>
        void Delete(int id);
    }
}
