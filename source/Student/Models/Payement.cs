using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Payement
    {
        public decimal Id { get; set; }
        public DateTime DatePay { get; set; }
        public string TypePay { get; set; }
        public decimal FraisSco { get; set; }
        public decimal MonPaye { get; set; }
        public decimal MonRes { get; set; }

        public int EtudiantId { get; set; }
        public virtual Etudiant Etudiant { get; set; }
    }
}
