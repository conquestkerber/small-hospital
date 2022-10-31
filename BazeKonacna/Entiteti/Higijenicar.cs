using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    public class Higijenicar : Nemedicinsko
    {
      public virtual IList<Odeljenje> Odeljenja { get; set; }

        public Higijenicar()
        {
            Odeljenja = new List<Odeljenje>();
        }
    }
}
