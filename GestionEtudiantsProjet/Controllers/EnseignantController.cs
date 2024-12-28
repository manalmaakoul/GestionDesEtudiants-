using GestionEtudiantsProjet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestionEtudiantsProjet.Controllers
{
    public class EnseignantController : Controller
    {
        private ICoursService coursService;
       
        public EnseignantController(ICoursService cs)
        {
            this.coursService = cs;
        }


    }
}
