using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
  public  class TehnickoOdrzavanje : Nemedicinsko
    {
        public virtual String Struka { get; set; }
        public virtual IList<Stolica> Odrzava { get; set; }


        public TehnickoOdrzavanje()
        {
            Odrzava = new List<Stolica>();
        }
    }
}
