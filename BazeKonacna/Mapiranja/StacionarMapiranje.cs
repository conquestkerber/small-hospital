using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class StacionarMapiranje:ClassMap<Stacionar>
    {
        public StacionarMapiranje()
        {
            Table("STACIONAR");
            Id(x => x.Naziv).Column("NAZIV");
            HasMany(x => x.Odeljenja);
        }
    }
}
