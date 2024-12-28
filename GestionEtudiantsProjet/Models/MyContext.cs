using Microsoft.EntityFrameworkCore;

namespace GestionEtudiantsProjet.Models
{
    public class MyContext :DbContext 
    {
        public DbSet<Etudiant>Etudiants { get; set; }
        public DbSet<Enseignant> Enseignants { get; set; }
        public DbSet<Administrateur> Administrateurs { get; set; }
        public DbSet<AbsenceEnseignant> AbsencesEnseignants { get; set; }
        public DbSet<AbsenceEtudiant> AbsencesEtudiants { get; set; }
        public DbSet<Cours>Cours { get; set; }
        public DbSet<EmploiDuTemps> EmploisDuTemps { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        
        public MyContext(DbContextOptions<MyContext> opt) : base(opt) { }

    }
}
