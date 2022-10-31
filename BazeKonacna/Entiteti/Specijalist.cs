using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
  public class Specijalist:Medicinsko
    {
        public virtual String Specijalnost { get; set; }
        public virtual IList<Odeljenje> Ima { get; set; }

        public Specijalist()
        {
            Ima = new List<Odeljenje>();
        }
    }
}
