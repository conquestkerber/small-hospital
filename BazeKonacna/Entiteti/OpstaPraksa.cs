using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    public class OpstaPraksa:Medicinsko
    {
        public virtual int brOrdinacije { get; set; }
        public virtual IList<Pacijent> Pacijenti { get; set; }


        public OpstaPraksa()
        {
            Pacijenti = new List<Pacijent>();
        }
    }
}
