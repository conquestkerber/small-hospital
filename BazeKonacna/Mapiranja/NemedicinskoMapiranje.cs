using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class NemedicinskoMapiranje:ClassMap<Nemedicinsko>
    {
        public NemedicinskoMapiranje()
        {
            Table("NEMEDICINSKO");
            // KeyColumn("JMBG");
            Id(x => x.Jmbg).Column("JMBG");
            //Map(x => x.Jmbg).Column("JMBG");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
        }
    }
}
