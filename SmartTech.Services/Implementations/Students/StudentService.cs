using SmartTech.Data.Entities;
using SmartTech.Repo.Interfaces;
using SmartTech.Services.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech.Services.Implementations.Students
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IRepository<Student> _studentRepository;

        #endregion

        #region Ctor
        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        #endregion

        #region Methods


        public void Delete(int id)
        {
            var student = _studentRepository.Table.FirstOrDefault(e => e.Id == id);
            if (student == null)
                throw new ArgumentException("There is no student with this id.");
            _studentRepository.Delete(student);
        }

        public Student GetById(int id)
        {
            return _studentRepository.Table.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _studentRepository.Table.ToList();
        }

        public void Insert(Student student)
        {
            _studentRepository.Insert(student);
        }

        public void Update(Student student)
        {
            _studentRepository.Update(student);
        }

        #endregion
    }
}
