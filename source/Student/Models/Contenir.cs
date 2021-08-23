using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public partial class Contenir
    {
        public int FiliereId { get; set; }
        public virtual Filiere Filiere { get; set; }

        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }

    }
}
