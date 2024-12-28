using GestionEtudiantsProjet.Mappers;
using GestionEtudiantsProjet.Models;
using GestionEtudiantsProjet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GestionEtudiantsProjet.Services.Implementations
{  /*gère la logique métier ce qui facilite les tests et la maintenance.
    * Il est responsable de l'interaction avec la base de données via MyContext.*/
    public class CoursService : ICoursService
    {
        MyContext db;
        public CoursService(MyContext db)
        {
            this.db = db;
        }

        public void AjouterCours(Cours cours)
        {
            db.Add(cours);
            db.SaveChanges();
        }
        public List<Cours> ListCours()
        {
            return db.Cours.AsNoTracking().ToList();
        }
        public Cours GetCoursById(int id) 
        { 
            return db.Cours.FirstOrDefault(cours=>cours.Id==id);
        }
        public void ModifierCours(Cours c)
        {
            Cours ToBeUpdated=db.Cours.FirstOrDefault(cours => cours.Id == c.Id);
            if (ToBeUpdated!=null) 
            {
                ToBeUpdated.Nom = c.Nom;
                ToBeUpdated.Volume_horaire = c.Volume_horaire;
                db.SaveChanges();
            }
            else 
            {
                Console.WriteLine("$\"Le cours avec l'ID {c.Id} n'existe pas dans la base de données.\"");
            }
        }

        public void SupprimerCours(int id)
        {
            Cours cours =db.Cours.FirstOrDefault(cours=>cours.Id == id);
            if (cours!=null) 
            {
                db.Cours.Remove(cours);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le cours avec l'ID {0} n'existe pas.", id);
            }
        }
       public void AjouterEnseignantAuCours(int coursId, int enseignantId)
        {
            Cours cours = db.Cours.Include(c => c.Enseignants).FirstOrDefault(c => c.Id ==coursId);
            Enseignant enseignant = db.Enseignants.FirstOrDefault(e => e.Id == enseignantId);
            if(cours!=null && enseignant!=null) 
            {
                cours.Enseignants.Add(enseignant);
                db.SaveChanges();
            }
                
        }
        public List<Cours> GetCoursPourEnseignant(int enseignantId)
        {
            return db.Enseignants
                .Include(e => e.Cours)
                .FirstOrDefault(e => e.Id == enseignantId)?
                .Cours.ToList();

        }


    }
}
