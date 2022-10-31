using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class OpstaPraksaMapiranje:SubclassMap<OpstaPraksa>
    {
        public OpstaPraksaMapiranje()
        {
            Table("OPSTA_PRAKSA");
            KeyColumn("JMBG");
            Map(x => x.brOrdinacije).Column("BROJ_ORDINACIJE");
            HasMany(x => x.Pacijenti);
        }
    }
}
