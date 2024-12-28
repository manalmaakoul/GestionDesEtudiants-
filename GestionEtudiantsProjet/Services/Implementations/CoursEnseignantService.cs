using GestionEtudiantsProjet.Models;
using GestionEtudiantsProjet.Services.Interfaces;

namespace GestionEtudiantsProjet.Services.Implementations
{
    public class CoursEnseignantService : ICoursEnseignantService
    {
        MyContext db;
        public CoursEnseignantService(MyContext db) 
        {
           this.db = db;
        }

        public List<Enseignant> GetAllEnseignants()
        {
            return db.Enseignants.ToList();
        }
    }
}
