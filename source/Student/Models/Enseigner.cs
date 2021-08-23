using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Enseigner
    {
        public decimal NbrHr { get; set; }
        public DateTime AnneeSco { get; set; }

        public int MatiereId { get; set; }
        public virtual Matiere Matiere { get; set; }

        public int ProfesseurId { get; set; }
        public virtual Professeur Professeur { get; set; }
    }
}
