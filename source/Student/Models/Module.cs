using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Module
    {
        public Module()
        {
            this.Matieres = new HashSet<Matiere>();
            this.Filieres = new HashSet<Filiere>();
        }

        public int Id { get; set; }
        public string NomMod { get; set; }
        public int SemMod { get; set; }
        public decimal FraisMod { get; set; }

        public virtual ICollection<Matiere> Matieres { get; set; }
        public virtual ICollection<Filiere> Filieres { get; set; }
    }
}
