using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtudiantsProjet.Models
{
    [Table("Etudiant")]
    public class Etudiant:Utilisateur
    {
        public DateTime Date_naissance { get; set; }
        public string LieuDeNaissance { get; set; }
        public string Groupe { get;set; }
        public AbsenceEtudiant AbsenceEtudiant { get; set; }
        public int AbsenceEtudiantID { get; set; }
        public IList<Cours>Cours { get; set; }
        public IList<EmploiDuTemps>EmploisDuTemps { get; set; }

    }
}
