using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtudiantsProjet.Models
{
    [Table("EmploiDuTemps")]
    public class EmploiDuTemps
    {
        public int Id {  get; set; }
        public string Jour { get; set; }
        public DateTime Heure_debut { get; set; }
        public DateTime Heure_fin { get; set; }
        public int salle {  get; set; }
        public int Nombre_heures { get; set; }
        public IList<Administrateur>Administrateurs { get; set; }
        public IList<Cours> Cours { get; set; }
        public IList<Etudiant>Etudiants { get; set; }
        public IList<Enseignant>Enseignants { get; set;}
        public Vacation Vacation { get; set; }
        public int VacationId { get; set; }



    }
}
