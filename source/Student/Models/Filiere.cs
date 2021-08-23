using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Filiere
    {
        public Filiere()
        {
            this.Groupes = new HashSet<Groupe>();
            this.Inscrires = new HashSet<Inscrire>();
            this.Modules = new HashSet<Module>();
        }

        public int Id { get; set; }
        public string NomFil { get; set; }

        public virtual ICollection<Groupe> Groupes { get; set; }
        public virtual ICollection<Inscrire> Inscrires { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
    }
}
