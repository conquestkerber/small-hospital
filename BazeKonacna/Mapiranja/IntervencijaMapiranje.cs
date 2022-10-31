using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class IntervencijaMapiranje:ClassMap<Intervencija>
    {
        public IntervencijaMapiranje()
        {
            Table("INTERVENCIJA");
            Id(x => x.Id).Column("ID");
            Map(x => x.Vrsta).Column("VRSTA");
            Map(x => x.Datum).Column("DATUM");
            References(x => x.Vrsi).Column("JMBG3");
        }
    }
}
