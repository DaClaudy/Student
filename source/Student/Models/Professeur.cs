using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Professeur
    {
        public Professeur()
        {
            this.Enseigners = new HashSet<Enseigner>();
        }

        public int Id { get; set; }
        public string NomProf { get; set; }
        public string PrenomProf { get; set; }
        public string AdresseEtu { get; set; }
        public string E_mail { get; set; }
        public string PostProf { get; set; }
        public decimal TelProf { get; set; }

        public virtual ICollection<Enseigner> Enseigners { get; set; }
    }
}
