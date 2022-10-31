using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    public class Intervencija
    {
        public virtual String Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual String Vrsta { get; set; }
        public virtual Stomatolog Vrsi { get; set; }

    }
}
