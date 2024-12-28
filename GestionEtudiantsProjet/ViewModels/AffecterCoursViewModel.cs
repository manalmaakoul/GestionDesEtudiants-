using GestionEtudiantsProjet.Models;

namespace GestionEtudiantsProjet.ViewModels
{
    public class AffecterCoursViewModel
    {
        public List<Cours> CoursList { get; set; } // Liste des cours
        public List<Enseignant> EnseignantList { get; set; } // Liste des enseignants
    }
}
