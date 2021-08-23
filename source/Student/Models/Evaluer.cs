using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Evaluer
    {
        public decimal NoteEva { get; set; }
        public DateTime DateEva { get; set; }
        public string TypeEva { get; set; }
        public decimal Coef { get; set; }

        public int EtudiantId { get; set; }
        public virtual Etudiant Etudiant { get; set; }

        public int MatiereId { get; set; }
        public virtual Matiere Matiere { get; set; }
    }
}
