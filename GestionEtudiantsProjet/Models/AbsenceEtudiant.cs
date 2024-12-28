using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtudiantsProjet.Models
{
    [Table("AbsenceEtudiant")]
    public class AbsenceEtudiant
    {
        public int Id { get; set; } 
        public DateTime DateAbsence { get; set; }
        public string Justification { get; set; }
        public IList<Etudiant>Etudiants { get; set; }
        public IList<Enseignant> Enseignants { get; set;}
    }
}
