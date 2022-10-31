using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
   public class Odeljenje
    {
        public virtual String Sifra { get; protected set; }
        public virtual String Tip { get; set; }
        public virtual  DateTime datumIzgradnje { get; set; }
        public virtual Stacionar nalaziSe { get; set; }
        public virtual Specijalist specijalista { get; set; }
        public virtual IList<Pacijent> Pacijenti { get; set; }
        public virtual IList<Higijenicar> Higijenicari { get; set; }
        public Odeljenje()
        {
            Pacijenti = new List<Pacijent>();
            Higijenicari = new List<Higijenicar>();
        }
            
    }
}
