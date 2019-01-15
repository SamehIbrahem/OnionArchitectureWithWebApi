using SmartTech.Data.Entities;
using SmartTech.Repo.Interfaces;
using SmartTech.Services.Faculties;
using SmartTech.Services.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech.Services.Implementations.Faculties
{
    public class FacultyService : IFacultyService
    {
        #region Fields
        private readonly IRepository<Faculty> _facultyRepository;

        #endregion

        #region Ctor
        public FacultyService(IRepository<Faculty> facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        #endregion

        #region Methods

        public IEnumerable<Faculty> GetFaculties()
        {
            return _facultyRepository.Table.ToList();
        }

        #endregion
    }
}
