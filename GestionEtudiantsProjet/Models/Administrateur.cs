using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtudiantsProjet.Models
{
    [Table("Administrateur")]
    public class Administrateur : Utilisateur
    {
        
        public IList<Vacation> vacations { get; set; }
        public IList<EmploiDuTemps> EmploisDuTemps {  get; set; }
        public IList<Cours>Cours { get; set; }
        public IList<AbsenceEnseignant> AbsencesEnseignants { get; set; }
        

        
    }
}
