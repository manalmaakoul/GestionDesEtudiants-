using GestionEtudiantsProjet.Models;

namespace GestionEtudiantsProjet.Services.Interfaces
{
    public interface ICoursEnseignantService
    {
       public List<Enseignant> GetAllEnseignants();
    }
}
