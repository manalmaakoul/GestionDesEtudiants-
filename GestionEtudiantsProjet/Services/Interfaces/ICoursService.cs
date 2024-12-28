using GestionEtudiantsProjet.Models;

namespace GestionEtudiantsProjet.Services.Interfaces
{
    public interface ICoursService
    {
        public void AjouterCours(Cours cours);
        public List<Cours> ListCours();
        public Cours GetCoursById(int id); 
        public void ModifierCours(Cours cours);
        public void SupprimerCours(int Id);
        //Enseignant part:
        public void AjouterEnseignantAuCours(int coursId, int enseignantId);
        public List<Cours> GetCoursPourEnseignant(int enseignantId);

    }
}
