using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class StomatologMapiranje:SubclassMap<Stomatolog>
    {
        public StomatologMapiranje()
        {
            Table("STOMATOLOZI");
            KeyColumn("JMBG");
            Map(x => x.Smena).Column("SMENA");
            References(x => x.Amblunata).Column("NAZIV1");
            References(x => x.radiNa).Column("SERIJSKI_BROJ3");
            HasMany(x => x.intervencije).Inverse().Cascade.All();
        }
    }
}
