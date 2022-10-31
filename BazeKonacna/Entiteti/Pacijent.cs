using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
   public class Pacijent
    {
        public virtual int Jmbg { get; protected set; }
        public virtual String Ime { get; set; }
        public virtual String Adresa { get; set; }
        public virtual String Prezime { get; set; }
        public virtual OpstaPraksa Lekar { get; set; }
        public virtual Ambulanta Ambulanta { get; set; }
        public virtual Odeljenje Odeljenje { get; set; }
        public virtual DateTime datumPrijema { get; set; }
        public virtual DateTime datumOtpusta { get; set; }
    }
}
