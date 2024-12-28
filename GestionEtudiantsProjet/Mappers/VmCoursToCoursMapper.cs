using GestionEtudiantsProjet.Models;
using GestionEtudiantsProjet.ViewModels;
using System.Net;

namespace GestionEtudiantsProjet.Mappers
{
////////////    Un Cours en VMCours pour envoyer les données à la vue.
////////////Un VMCours en Cours pour sauvegarder les données dans la base de données.
    public class VmCoursToCoursMapper
    {
       
        //conversion de VMCours en Cours
        public static Cours GetCoursFromCoursViewModel(CoursViewModel vm)
        {
            Cours cours = new Cours()
            {
                Nom = vm.Nom,
                Volume_horaire= vm.Volume_horaire
              
            };
            return cours;
        }

    }
}
