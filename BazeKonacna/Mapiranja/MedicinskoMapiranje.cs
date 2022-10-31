using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class MedicinskoMapiranje:ClassMap<Medicinsko>
    {
        public MedicinskoMapiranje()
        {
            Table("MEDICINSKO");
           //  KeyColumn("JMBG");
             Map(x => x.godineStaza).Column("GODINE_STAZA");
             Id(x => x.Jmbg).Column("JMBG");
            //Map(x => x.Jmbg).Column("JMBG");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
           
        }
    }
}
