using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Salle
    {
        public Salle()
        {
            this.Matieres = new HashSet<Matiere>();
        }

        public int Id { get; set; }
        public string NomSal { get; set; }

        public virtual ICollection<Matiere> Matieres { get; set; }
    }
}
