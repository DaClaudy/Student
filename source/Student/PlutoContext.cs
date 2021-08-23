using Student.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public partial class PlutoContext : DbContext
    {
        public PlutoContext() : base("name=PlutoContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Dossier> Dossiers { get; set; }
        public virtual DbSet<Enseigner> Enseigners { get; set; }
        public virtual DbSet<Etudiant> Etudiants { get; set; }
        public virtual DbSet<Evaluer> Evaluers { get; set; }
        public virtual DbSet<Filiere> Filieres { get; set; }
        public virtual DbSet<Groupe> Groupes { get; set; }
        public virtual DbSet<Inscrire> Inscrires { get; set; }
        public virtual DbSet<Matiere> Matieres { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Payement> Payements { get; set; }
        public virtual DbSet<Professeur> Professeurs { get; set; }
        public virtual DbSet<Salle> Salles { get; set; }
    }
}
