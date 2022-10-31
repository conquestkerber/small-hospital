using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeKonacna
{
    class PacijentMapiranje:ClassMap<Pacijent>
    {
        public PacijentMapiranje()
        {
            Table("PACIJENT");
            Id(x => x.Jmbg).Column("JMBG");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.datumPrijema).Column("DATUM_PRIJEMA");
            Map(x => x.datumOtpusta).Column("DATUM_OTPUSTA");
            References(x => x.Lekar).Column("JMBG8");
            References(x => x.Ambulanta).Column("NAZIV3");
            References(x => x.Odeljenje).Column("SIFRA5");
        }
    }
}
