using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Inscrire
    {
        public decimal FraisIns { get; set; }
        public DateTime DateIns { get; set; }
        public string Promotion { get; set; }

        public int EtudiantId { get; set; }
        public virtual Etudiant Etudiant { get; set; }

        public int FiliereId { get; set; }
        public virtual Filiere Filiere { get; set; }
    }
}
