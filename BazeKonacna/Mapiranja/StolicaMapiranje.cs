using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class StolicaMapiranje:ClassMap<Stolica>
    {
        public StolicaMapiranje()
        {
            Table("STOLICA");
            Id(x => x.sBroj).Column("SERIJSKI_BROJ");
            Map(x => x.Proizvodjac).Column("PROIZVODJAC");
            Map(x => x.datumProizvodnje).Column("DATUM_PROIZVODNJE");
            References(x => x.Odrzava).Column("JMBG3");
            HasMany(x => x.Stomatolozi);
        }
    }
}
