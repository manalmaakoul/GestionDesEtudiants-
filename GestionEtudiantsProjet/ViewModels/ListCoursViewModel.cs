using System.ComponentModel.DataAnnotations;

namespace GestionEtudiantsProjet.ViewModels
{
    public class ListCoursViewModel
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "champ obligatoire !")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Preciser le volume horaire du cours  !")]
        public int Volume_horaire { get; set; }
    }
}
