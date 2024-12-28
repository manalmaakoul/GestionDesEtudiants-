using GestionEtudiantsProjet.Models;
using GestionEtudiantsProjet.ViewModels;

namespace GestionEtudiantsProjet.Mappers
{
    public class UpdateVmCoursToCoursMapper
    {
        public static Cours GetCoursFromUpdateViewModel(UpdateCoursViewModel vm)
        {
            Cours cours = new Cours()
            {
                Nom = vm.Nom,
                Volume_horaire = vm.Volume_horaire

            };
            return cours;
        }
    }
}
