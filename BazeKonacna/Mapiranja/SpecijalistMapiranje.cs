using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class SpecijalistMapiranje:SubclassMap<Specijalist>
    {
        public SpecijalistMapiranje()
        {
            Table("SPECIJALISTI");
            KeyColumn("JMBG");
            Map(x => x.Specijalnost).Column("SPECIJALNOST");
            HasMany(x => x.Ima);
        }
    }
}
