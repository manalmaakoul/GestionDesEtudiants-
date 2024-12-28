using GestionEtudiantsProjet.Models;
using GestionEtudiantsProjet.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Runtime.InteropServices;

namespace GestionEtudiantsProjet.Mappers
{
    public class ListCoursToListVmCoursMapper
    {
        public static List<ListCoursViewModel>GetListVmCoursFromListCours(List<Cours> model)
        {
            var vm = model.Select(c => new ListCoursViewModel
            {   
                Id=c.Id,
                Nom = c.Nom,
                Volume_horaire = c.Volume_horaire,
            }).ToList();
            return vm;
        }
        
    }
}
