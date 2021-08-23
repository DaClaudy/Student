using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Fournir
    {
        public int EtudiantId { get; set; }
        public virtual Etudiant Etudiant { get; set; }

        public int DossierId { get; set; }
        public virtual Dossier Dossier { get; set; }
    }
}
