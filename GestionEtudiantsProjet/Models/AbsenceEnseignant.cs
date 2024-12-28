using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtudiantsProjet.Models
{
    [Table("AbsenceEnseignant")]
    public class AbsenceEnseignant
    {
        public int Id { get; set; }
        public DateTime DateAbsence { get; set; }
        public string Justification { get; set; }
        public IList<Enseignant> Enseignants { get; set; }
        public IList<Administrateur> Administrateurs { get; set; }
        public IList<Cours> Cours { get; set; }

    }
}
