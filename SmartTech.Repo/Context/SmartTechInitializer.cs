using SmartTech.Data.Entities;
using SmartTech.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech.Repo.Context
{

    public class SmartTechInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SmartTechContext>
    {
        /// <summary>
        /// Initalize the database with some data
        /// </summary>
        protected override void Seed(SmartTechContext context)
        {

            var faculties = new List<Faculty>
            {
            new Faculty{Name="Ain Shams"},
            new Faculty{Name="Helwan"},
            new Faculty{Name="AUC"},
            new Faculty{Name="GUC"}
            };

            faculties.ForEach(s => context.Faculties.Add(s));
            context.SaveChanges();

            base.Seed(context);
        }
    }

}
