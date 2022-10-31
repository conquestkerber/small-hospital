using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class TehnickoOdrazavanjeMapiranje:SubclassMap<TehnickoOdrzavanje>
    {
        public TehnickoOdrazavanjeMapiranje()
        {
            Table("TEHNICKO_ODRZAVANJE");
            KeyColumn("JMBG");
            Map(x => x.Struka).Column("STRUKA");
            HasMany(x => x.Odrzava);
        }
    }
}
