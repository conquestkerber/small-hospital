using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    public class Stomatolog:Medicinsko
    {
        public virtual Stolica radiNa { get; set; }
        public virtual IList<Intervencija> intervencije { get; set; }
        public virtual Ambulanta Amblunata { get; set; }
        public virtual String Smena { get; set; }


        public Stomatolog()
        {
            intervencije = new List<Intervencija>();
        }
    }
}
