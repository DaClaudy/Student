using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Etudiant
    {
        public Etudiant()
        {
            this.Evaluers = new HashSet<Evaluer>();
            this.Inscrires = new HashSet<Inscrire>();
            this.Payements = new HashSet<Payement>();
            this.Dossiers = new HashSet<Dossier>();
        }

        public int Id { get; set; }
        public string NomEtu { get; set; }
        public string PrenomEtu { get; set; }
        public string SexeEtu { get; set; }
        public DateTime DateNais { get; set; }
        public string LieuNais { get; set; }
        public string QuaRes { get; set; }
        public string NomParen { get; set; }
        public string Nation { get; set; }
        public string E_mail { get; set; }
        public string AdresseEtu { get; set; }
        public string PhotoEtu { get; set; }
        public decimal TelEtu { get; set; }

        public int GroupeId { get; set; }
        public virtual Groupe Groupe { get; set; }
        public virtual ICollection<Evaluer> Evaluers { get; set; }
        public virtual ICollection<Inscrire> Inscrires { get; set; }
        public virtual ICollection<Payement> Payements { get; set; }
        public virtual ICollection<Dossier> Dossiers { get; set; }
    }
}
