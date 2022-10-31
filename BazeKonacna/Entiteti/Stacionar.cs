using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    public class Stacionar
    {
        public virtual String Naziv { get; protected set; }
        public virtual IList<Odeljenje> Odeljenja { get; set; }

        public Stacionar()
        {
            Odeljenja = new List<Odeljenje>();
        }

    }
}
