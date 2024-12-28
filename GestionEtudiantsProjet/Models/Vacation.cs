using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEtudiantsProjet.Models
{
    [Table("Vacation")]
    public class Vacation
    {
        public int Id { get; set; }
        public DateTime DateVacation { get; set; }
        public int Nombre_heures { get; set; }
        public string Justifcation { get; set; }
        public IList<Enseignant> Enseignats { get; set; }
        public IList<Administrateur> Administrateurs { get; set; }
        public IList<EmploiDuTemps> EmploisDutemps { get; set; }



    }
}
