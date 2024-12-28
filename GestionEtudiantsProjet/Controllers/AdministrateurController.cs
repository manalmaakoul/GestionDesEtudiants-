using GestionEtudiantsProjet.Mappers;
using GestionEtudiantsProjet.Models;
using GestionEtudiantsProjet.Services.Implementations;
using GestionEtudiantsProjet.Services.Interfaces;
using GestionEtudiantsProjet.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using NuGet.ContentModel;

public class AdministrateurController : Controller
{
    private ICoursService coursService;
    private ICoursEnseignantService coursEnseignantService;
    
    public AdministrateurController(ICoursService cs,ICoursEnseignantService coursEnseignantService)
    {
        this.coursService= cs;
        this.coursEnseignantService = coursEnseignantService;
    }
    [HttpGet]
    public IActionResult AjouterCours()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AjouterCours(CoursViewModel vmcours)
    {
        if (ModelState.IsValid)
        {
            Cours cours = VmCoursToCoursMapper.GetCoursFromCoursViewModel(vmcours);
            coursService.AjouterCours(cours);
            return RedirectToAction("ListCours");
        }
        return View("AjouterCours");
    }
    
    public IActionResult ListCours()
    {
        List<Cours> CoursList = coursService.ListCours();
        List<ListCoursViewModel>VmList= ListCoursToListVmCoursMapper.GetListVmCoursFromListCours(CoursList);
        
        return View(VmList);
    }
    public IActionResult ModifierCours(int Id)
    {   
         Cours CoursSelected=coursService.GetCoursById(Id);
        UpdateCoursViewModel vm = CoursToUpdateVmCoursMapper.CoursToUpdateVmCours(CoursSelected);
        return View(vm);
    }
    [HttpPost]
    public IActionResult ModifierCours(int Id,UpdateCoursViewModel vm)
    {
        if(ModelState.IsValid) 
        {
            Cours cours = UpdateVmCoursToCoursMapper.GetCoursFromUpdateViewModel(vm);
            cours.Id = Id;
            coursService.ModifierCours(cours);  
            return RedirectToAction("ListCours");
        }
        return View();
    }
    
    [HttpGet]
    public IActionResult SupprimerCours(int Id)
    {
        Cours cours = coursService.GetCoursById(Id);
        if(cours ==null)
        {
            return NotFound();
        }
      
        return View(cours);// // Retourne une vue de confirmation avec les détails du cours
    }
    // Cette méthode exécute la suppression une fois confirmée.
    [HttpPost]
    public IActionResult ConfirmerSuppression(int id)
    {
        coursService.SupprimerCours(id);
        return RedirectToAction("ListCours");
    }

    [HttpGet]
    public IActionResult AffecterCours()
    {
        // Créer le ViewModel
        var model = new AffecterCoursViewModel
        {
            // Récupérer les listes de cours et d'enseignants depuis la base de données
            CoursList = coursService.ListCours(),
            EnseignantList = coursEnseignantService.GetAllEnseignants(),
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult AffecterCours(int coursId, int enseignantId)
    {
        coursService.AjouterEnseignantAuCours(coursId, enseignantId);
        return RedirectToAction("listEnseignant");
    }
    [HttpGet]
    public IActionResult CoursParEnseignant(int enseignantId)
    {
        List<Cours> listEnseignant = coursService.GetCoursPourEnseignant(enseignantId);
        if (listEnseignant == null)
        {
            // Gestion du cas où aucun cours n'est trouvé
            return View(new List<Cours>());
        }
    
            return View(listEnseignant);
    }
}
   