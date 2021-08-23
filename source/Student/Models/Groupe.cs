using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Groupe
    {
        public Groupe()
        {
            this.Etudiants = new HashSet<Etudiant>();
        }

        public int Id { get; set; }
        public string NomGrp { get; set; }

        public virtual ICollection<Etudiant> Etudiants { get; set; }

        public int FiliereId { get; set; }
        public virtual Filiere Filiere { get; set; }
    }
}
