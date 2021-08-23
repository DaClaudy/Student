using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Matiere
    {
        public Matiere()
        {
            this.Enseigners = new HashSet<Enseigner>();
            this.Evaluers = new HashSet<Evaluer>();
        }

        public int Id { get; set; }
        public string NomMat { get; set; }

        public virtual ICollection<Enseigner> Enseigners { get; set; }
        public virtual ICollection<Evaluer> Evaluers { get; set; }

        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }

        public int SalleId { get; set; }
        public virtual Salle Salle { get; set; }
    }
}
