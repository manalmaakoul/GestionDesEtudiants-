using GestionEtudiantsProjet.Models;
using GestionEtudiantsProjet.ViewModels;

namespace GestionEtudiantsProjet.Mappers
{
    public class CoursToUpdateVmCoursMapper
    {
        public static UpdateCoursViewModel CoursToUpdateVmCours(Cours model)
        {
            UpdateCoursViewModel vm = new UpdateCoursViewModel()
            {
                Nom=model.Nom,
                Volume_horaire=model.Volume_horaire,
            };
            return vm;
        }
    }
}
