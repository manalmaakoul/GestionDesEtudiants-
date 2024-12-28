using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtudiantsProjet.Models
{
    [Table("Cours")]
    public class Cours
    {   
        public int Id { get; set; }
        public string Nom { get; set; }      
        public int Volume_horaire { get; set; }
        public IList<Administrateur> Administrateurs {  get; set; }
        public IList<Etudiant>Etudiants { get; set; }
        public IList<AbsenceEtudiant>AbsencesEtudiants { get; set; }
        public IList<Enseignant>Enseignants { get; set; }
        public IList<AbsenceEnseignant> AbsencesEnseignants { get; set;}
        public IList<EmploiDuTemps>EmploisDutemps { get; set; }

    }
}
