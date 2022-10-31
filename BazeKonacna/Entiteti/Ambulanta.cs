using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    public class Ambulanta
    {
        public virtual String Naziv {get; set; }
        public virtual IList<Pacijent> Pacijenti { get; set; }

        public Ambulanta()
        {
            Pacijenti = new List<Pacijent>();
        }
    }
}
