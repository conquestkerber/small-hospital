using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Linq;  

namespace BazeKonacna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Odeljenje p = s.Load<Odeljenje>("ODLJ2");

               
                    MessageBox.Show("Odeljenje:" + p.Sifra +"se nalazi u:" + p.nalaziSe.Naziv);
             
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
               OpstaPraksa p = s.Load<OpstaPraksa>(77778888);
                    foreach (Pacijent pac in p.Pacijenti)
                    {
                        MessageBox.Show("Lekar: " + p.Ime + p.Prezime + " leci: " + pac.Ime + pac.Prezime);
                    }               
              
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Stomatolog p = s.Load<Stomatolog>(49874665);               
                MessageBox.Show("Stomatolog:" + p.Ime + p.Prezime + "radi u:" + p.Amblunata.Naziv);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Odeljenje p = s.Load<Odeljenje>("ODLJ1");

                    foreach (Higijenicar o in p.Higijenicari)
                    {
                        MessageBox.Show("Higijenicari koji rade na odeljenju su: " + o.Ime + o.Prezime);
                    }

                    Higijenicar hig = s.Load<Higijenicar>(67098345);

                foreach (Odeljenje o in hig.Odeljenja)
                {
                    MessageBox.Show("Odeljenja na kojima radi higijenicar " + hig.Ime + hig.Prezime + "je: " + o.Sifra);
                }             
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void Dodaj_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2007, 9, 8);
            ISession s = DataLayer.GetSession();
            TehnickoOdrzavanje teh = s.Load<TehnickoOdrzavanje>(67098345);
            Stolica a1 = new Stolica();
            a1.datumProizvodnje = dt;
            a1.Proizvodjac = "Mavina";
            a1.sBroj = "s3459";
            a1.Odrzava = teh;
            s.Save(a1);
            s.Flush();
            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Pacijent p = s.Load<Pacijent>(22222222);
            p.Adresa = "bulevar 12";
            s.SaveOrUpdate(p);
            s.Flush();
            s.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DateTime dat = new DateTime(2015, 5, 9);
            ISession s = DataLayer.GetSession();
            Stomatolog stomatolog = s.Load<Stomatolog>(49874665);
            Intervencija i1 = new Intervencija();
            i1.Id = "n123";
            i1.Vrsta = "vadjenje";
            i1.Datum = dat;
            i1.Vrsi = stomatolog;
            stomatolog.intervencije.Add(i1);

            s.SaveOrUpdate(stomatolog);
            s.Flush();
            s.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Intervencija i1 = s.Load<Intervencija>("n123");
            s.Delete(i1);
            s.Flush();
            s.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Odeljenje");
                IList<Odeljenje> il = q.List<Odeljenje>();
               // Specijalist spec = s.Load<Specijalist>(23909872);
                foreach (Odeljenje ode in il) //spec.Ima)                                                 
                {
                    MessageBox.Show("Sifra je:" + ode.Sifra + " " + "a tip je:" + ode.Tip);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery iq = s.CreateQuery("from Odeljenje as o where o.Tip='hirurgija'");                       
                IList<Odeljenje> odeljenje = iq.List<Odeljenje>();
                //Higijenicar hig = s.Load<Higijenicar>(67098345);
                foreach (Odeljenje odelj in odeljenje) // hig.Odeljenja)                            
                {
                    MessageBox.Show("Sifra je:" + odelj.Sifra +" " +  "datum je:" + odelj.datumIzgradnje.ToShortDateString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Odeljenje as o where o.Tip=? and o.Sifra=? ");
            iq.SetParameter(0, "dermatologija");
            iq.SetParameter(1, "ODLJ1");
            IList<Odeljenje> od = iq.List<Odeljenje>();
            foreach (Odeljenje odelj in od)
            {
                MessageBox.Show("Sifra je:" + odelj.Sifra + " " + "Datum je:" + odelj.datumIzgradnje.ToShortDateString());
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery iq = s.CreateQuery("select e.nalaziSe from Odeljenje as e " 
                    + "where e.Tip= :tip");
                iq.SetString("tip", "hirurgija");
                IList<Stacionar> stacionari = iq.List<Stacionar>();
                foreach (Stacionar st in stacionari)
                {
                    MessageBox.Show("Naziv:" + st.Naziv);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery iq = s.CreateQuery("from Odeljenje");
                IEnumerable<Odeljenje> ieo = iq.Enumerable<Odeljenje>();
                foreach (Odeljenje odeljenje in ieo)
                {
                    if (odeljenje.Tip == "dermatologija")
                    {
                        break;
                                              
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            // IQuery iq = s.CreateQuery("from Odeljenje as o where o.Tip='onkologija' ");
            IQuery iq = s.CreateQuery("from Pacijent as p where p.Ime = 'Uros'");
            Pacijent pacijent = iq.UniqueResult<Pacijent>();
            //Odeljenje od = iq.UniqueResult<Odeljenje>();
            //MessageBox.Show(od.Sifra);
            MessageBox.Show("Prezime pacijenta je:" + pacijent.Prezime + " " + "Adresa pacijenta je:" + pacijent.Adresa);
            s.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IList<Pacijent> pacijent = s.QueryOver<Pacijent>()
                                         .Where(x => x.Ime == "Milos")
                                         .Where(x => x.Adresa == "bulevar 12")
                                         .List<Pacijent>();
            foreach(Pacijent pac in pacijent)
            {
                MessageBox.Show("Datum prijema:" + pac.datumPrijema.ToShortDateString() + " " + "Datum otpusta:" + pac.datumOtpusta.ToShortDateString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            ISQLQuery isq = s.CreateSQLQuery("select p.* from Pacijent p");
            isq.AddEntity(typeof(Pacijent));
            IList<Pacijent> pacijent = isq.List<Pacijent>();
            foreach(Pacijent pac in pacijent)
            {
                MessageBox.Show("Ime pacijenta:" +pac.Ime + " " +"Jmbg pacijenta:" + pac.Jmbg + " " +"Adresa pacijenta:"  + pac.Adresa);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<Stolica> stolica = from st in s.Query<Stolica>()
                                           where (st.Proizvodjac == "Stefan")
                                           orderby st.datumProizvodnje
                                           select st;
            foreach(Stolica stol in stolica)
            {
                MessageBox.Show("Broj stolice:" +stol.sBroj);
            }
            s.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ICriteria c = s.CreateCriteria<Stolica>();
                c.Add(Expression.Eq("Proizvodjac", "Mavina"));

                IList<Stolica> stolica = c.List<Stolica>();
                foreach (Stolica stol in stolica)
                {
                    MessageBox.Show("Broj stolice:" + stol.sBroj);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Odeljenje");
                q.SetFirstResult(0);
                q.SetMaxResults(3);

                IList<Odeljenje> odeljenja = q.List<Odeljenje>();

                foreach (Odeljenje o in odeljenja)
                {
                    MessageBox.Show("Tip odeljenja:" + o.Tip);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pacijent p = s.Load<Pacijent>(56564545);
                ITransaction t = s.BeginTransaction();
                s.Delete(p);
                t.Rollback();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery iq = s.CreateQuery(" select o.Tip, count(o) from Odeljenje as o " 
                                          + " group by o.Tip ");
                IList<object[]> lista = iq.List<object[]>();
                foreach(object[] lis in lista)
                {
                    string ime = (string)lis[0];
                    long broj = (long)lis[1];
                    MessageBox.Show(ime + " " +broj.ToString());
                }
                s.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
