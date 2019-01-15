using SmartTech.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech.Services.Faculties
{
    public interface IFacultyService
    {
        IEnumerable<Faculty> GetFaculties();
    }
}
