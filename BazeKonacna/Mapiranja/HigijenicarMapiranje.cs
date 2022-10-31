using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class HigijenicarMapiranje:SubclassMap<Higijenicar>
    {
        public HigijenicarMapiranje()
        {
            Table("HIGIJENICAR");
            KeyColumn("JMBG");
            HasManyToMany(x => x.Odeljenja).Table("RADE").ParentKeyColumn("JMBG0").ChildKeyColumn("SIFRA1");
        }
    }
}
