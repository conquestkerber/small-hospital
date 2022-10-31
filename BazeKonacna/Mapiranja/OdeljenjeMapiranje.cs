using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class OdeljenjeMapiranje:ClassMap<Odeljenje>
    {
        public OdeljenjeMapiranje()
        {
            Table("ODELJENJE");
            Id(x => x.Sifra).Column("SIFRA");
            Map(x => x.Tip).Column("TIP");
            Map(x => x.datumIzgradnje).Column("DATUM_IZGRADNJE");
            References(x => x.nalaziSe).Column("NAZIV3");
            References(x => x.specijalista).Column("JMBG4");
            HasMany(x => x.Pacijenti);
            HasManyToMany(x => x.Higijenicari).Table("RADE").ParentKeyColumn("SIFRA1").ChildKeyColumn("JMBG0").Inverse().Cascade.All();
        }
    }
}
