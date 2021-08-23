using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Dossier
    {
        public Dossier()
        {
            this.Etudiants = new HashSet<Etudiant>();
        }

        public int Id { get; set; }
        public string DesDos { get; set; }

        public virtual ICollection<Etudiant> Etudiants { get; set; }
    }
}
