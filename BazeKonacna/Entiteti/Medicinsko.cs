using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
  public class Medicinsko
    {
        public virtual int godineStaza { get; set; }
        public virtual int Jmbg { get; set; }
        public virtual String Ime { get; set; }
        public virtual String Prezime { get; set; }

    }
}
