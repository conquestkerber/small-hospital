using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class AmbulantaMapiranje:ClassMap<Ambulanta>
    {
        public AmbulantaMapiranje()
        {
            Table("AMBULANTA");
            Id(x => x.Naziv).Column("NAZIV");
            HasMany(x => x.Pacijenti);
        }
    }
}
