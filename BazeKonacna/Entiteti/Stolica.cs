using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    public class Stolica
    {
        public virtual String sBroj { get; set; }
        public virtual String Proizvodjac { get; set; }
        public virtual DateTime datumProizvodnje { get; set; }

        public virtual TehnickoOdrzavanje Odrzava { get; set; }
        public virtual IList<Stomatolog> Stomatolozi { get; set; }


        public Stolica()
        {
            Stomatolozi = new List<Stomatolog>();
        }
    }
}
