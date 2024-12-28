using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtudiantsProjet.Models
{
    [Table("Enseignant")]
    public class Enseignant:Utilisateur
    {
        public int PPR {  get; set; }
        public string Grade { get; set; }
        public string Specialite {  get; set; }
        public decimal Taux_horaire { get; set; }
        // Collection de vacations attribuées à cet enseignant
        public IList<Vacation> vacations { get; set; }
        public AbsenceEnseignant AbsenceEnseignant { get; set; }
        public int AbsenceEnseignantId { get; set; }
        public AbsenceEtudiant AbsenceEtudiant { get; set; }
        public int AbsenceEtudiantId { get; set; }
        public IList<Cours>Cours { get; set; }
        public IList<EmploiDuTemps>EmploisDuTemps { get; set; }
    }
}
