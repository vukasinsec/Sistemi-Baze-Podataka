using FashionWeek.Entiteti;
using FluentNHibernate.Utils;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek
{
    public class DTOManager
    {
        #region Organizator

        //public static bool proveriOrganizatora(int id)
       // {

         //   i

        //}

        public static void sacuvajOrganizatora(OrganizatorBasic o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.Organizator m = new FashionWeek.Entiteti.Organizator();

                m.Kolekcija = o.Kolekcija;
                m.PrvaModnaRevija = o.PrvaModnaRevija;



                s.Save(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion

        #region Specijani Gost

        public static void sacuvajSpecijalnogGosta(SpecijalniGostBasic o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Create a new instance of the entity
                FashionWeek.Entiteti.SpecijalniGost m = new FashionWeek.Entiteti.SpecijalniGost();

                // Create new instances for the referenced entities
                FashionWeek.Entiteti.ModniKreator mk = new FashionWeek.Entiteti.ModniKreator
                {
                    MBR = o.MBRModniKreator.MBR
                };

                FashionWeek.Entiteti.ModnaRevija mr = new FashionWeek.Entiteti.ModnaRevija
                {
                    IdModneRevije = o.IDModneRevije.IdModneRevije
                };

                // Save the referenced entities first
                s.SaveOrUpdate(mk);
                s.SaveOrUpdate(mr);

                // Set properties from the basic object to the entity object
                m.MBRModniKreator = mk;
                m.IDModneRevije = mr;
                m.IDGosta = o.IDGosta;

                // Save the main entity object to the database
                s.Save(m);

                // Commit the transaction
                s.Flush();

                // Close the session
                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions
                Console.WriteLine("An error occurred: " + ec.Message);
            }
        }


        #endregion


        #region ModnaRevija

        public static bool proveriRedniBroj(int br)
        {
            bool vrati = false;

            List<ModnaRevijaPregled> revije = vratiSveModneRevije();

            foreach (ModnaRevijaPregled m in revije)
            {
                if(m.RedniBroj == br )
                {
                    vrati = true;
                    break;
                }
                else
                {
                    vrati = false;
                }
            }

            return vrati;
        }


        public static void obrisiReviju(int id)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaRevija o = s.Load<FashionWeek.Entiteti.ModnaRevija>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        public static List<ModnaRevijaPregled> vratiSveModneRevije()
        {
            List<ModnaRevijaPregled> revije = new List<ModnaRevijaPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ModnaRevija> sveRevije = from o in sesija.Query<FashionWeek.Entiteti.ModnaRevija>() select o;

                foreach (FashionWeek.Entiteti.ModnaRevija m in sveRevije)
                {
                    revije.Add(new ModnaRevijaPregled(m.IdModneRevije, m.RedniBroj, m.Naziv, m.Grad, m.DatumOdrzavanja, m.VremeOdrzavanja, m.ImeJavneLicnosti, m.PrezimeJavneLicnosti, m.ZanimanjeJL));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return revije;

        }



        public static List<ModnaRevijaPregled> vratiModneRevije(int id)
        {
            List<ModnaRevijaPregled> revije = new List<ModnaRevijaPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ModnaRevija> sveRevije = from o in sesija.Query<FashionWeek.Entiteti.ModnaRevija>() where o.OrganizatorID.OrganizatorID == id select o;

                foreach (FashionWeek.Entiteti.ModnaRevija m in sveRevije)
                {
                    revije.Add(new ModnaRevijaPregled(m.IdModneRevije, m.RedniBroj, m.Naziv, m.Grad, m.DatumOdrzavanja, m.VremeOdrzavanja, m.ImeJavneLicnosti, m.PrezimeJavneLicnosti, m.ZanimanjeJL));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return revije;

        }

        public static ModnaRevijaBasic vratiReviju(int id)
        {
            ModnaRevijaBasic mrb = new ModnaRevijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaRevija m = s.Load<FashionWeek.Entiteti.ModnaRevija>(id);
                mrb = new ModnaRevijaBasic(m.IdModneRevije, m.RedniBroj, m.Naziv, m.Grad, m.DatumOdrzavanja, m.VremeOdrzavanja, m.ImeJavneLicnosti, m.PrezimeJavneLicnosti, m.ZanimanjeJL);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return mrb;
        }

        public static OrganizatorBasic vratiOrganizatora(int id)
        {
            OrganizatorBasic pb = new OrganizatorBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.Organizator o = s.Load<FashionWeek.Entiteti.Organizator>(id);
                pb = new OrganizatorBasic(o.OrganizatorID, o.Kolekcija, o.PrvaModnaRevija);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static List<OrganizatorPregled> vratiSveOrganizatore()
        {
            List<OrganizatorPregled> organizatori = new List<OrganizatorPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.Organizator> sviOrganizatori = from o in sesija.Query<FashionWeek.Entiteti.Organizator>() select o;

                foreach (FashionWeek.Entiteti.Organizator m in sviOrganizatori)
                {
                    organizatori.Add(new OrganizatorPregled(m.OrganizatorID, m.Kolekcija, m.PrvaModnaRevija));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return organizatori;

        }





        public static void dodajModnuReviju(ModnaRevijaBasic m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaRevija mr = new FashionWeek.Entiteti.ModnaRevija();

                // mr.IdModneRevije = m.IdModneRevije;
                mr.RedniBroj = m.RedniBroj;
                mr.Naziv = m.Naziv;
                mr.Grad = m.Grad;
                // mr.DatumOdrzavanja=m.DatumOdrzavanja;
                mr.VremeOdrzavanja = m.VremeOdrzavanja;
                mr.ImeJavneLicnosti = m.ImeJavneLicnosti;
                mr.PrezimeJavneLicnosti = m.PrezimeJavneLicnosti;
                mr.ZanimanjeJL = m.ZanimanjeJL;


                s.SaveOrUpdate(mr);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajModnuReviju(ModnaRevijaBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaRevija m = new FashionWeek.Entiteti.ModnaRevija();

                m.Naziv = mr.Naziv;
                m.Grad = mr.Grad;
                m.RedniBroj = mr.RedniBroj;
                m.VremeOdrzavanja = mr.VremeOdrzavanja;
                m.DatumOdrzavanja = mr.DatumOdrzavanja;
                m.ImeJavneLicnosti = mr.ImeJavneLicnosti;
                m.PrezimeJavneLicnosti = mr.PrezimeJavneLicnosti;
                m.ZanimanjeJL = mr.ZanimanjeJL;

                FashionWeek.Entiteti.Organizator o = s.Load<FashionWeek.Entiteti.Organizator>(mr.OrganizatorID.OrganizatorID);
                m.OrganizatorID = o;


                s.Save(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static ModnaRevijaBasic azurirajModnuReviju(ModnaRevijaBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaRevija m = s.Load<FashionWeek.Entiteti.ModnaRevija>(mr.IdModneRevije);

                m.Naziv = mr.Naziv;
                m.Grad = mr.Grad;
                m.RedniBroj = mr.RedniBroj;
                m.VremeOdrzavanja = mr.VremeOdrzavanja;
                m.DatumOdrzavanja = mr.DatumOdrzavanja;
                m.ImeJavneLicnosti = mr.ImeJavneLicnosti;
                m.PrezimeJavneLicnosti = mr.PrezimeJavneLicnosti;
                m.ZanimanjeJL = mr.ZanimanjeJL;


                s.Update(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return mr;
        }


        #endregion

        #region ModnaKuca

        public static void sacuvajModnuKucu(ModnaKucaBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaKuca m = new FashionWeek.Entiteti.ModnaKuca();

                m.Naziv = mr.Naziv;
                m.ImeOsnivaca = mr.ImeOsnivaca;
                m.PrezimeOsnivaca = mr.PrezimeOsnivaca;
                m.Drzava = mr.Drzava;
                m.Grad = mr.Grad;


                FashionWeek.Entiteti.Organizator o = s.Load<FashionWeek.Entiteti.Organizator>(mr.OrganizatorID.OrganizatorID);
                m.OrganizatorID = o;


                s.Save(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static List<ModnaKucaPregled> vratiModneKuce(int id)
        {
            List<ModnaKucaPregled> kuce = new List<ModnaKucaPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ModnaKuca> sveKuce = from o in sesija.Query<FashionWeek.Entiteti.ModnaKuca>() where o.OrganizatorID.OrganizatorID == id select o;

                foreach (FashionWeek.Entiteti.ModnaKuca m in sveKuce)
                {
                    kuce.Add(new ModnaKucaPregled(m.Naziv, m.ImeOsnivaca, m.PrezimeOsnivaca, m.Drzava, m.Grad));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return kuce;

        }

        public static List<ModnaKucaPregled> vratiSveModneKuce()
        {
            List<ModnaKucaPregled> kuce = new List<ModnaKucaPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ModnaKuca> sveKuce = from o in sesija.Query<FashionWeek.Entiteti.ModnaKuca>() select o;

                foreach (FashionWeek.Entiteti.ModnaKuca m in sveKuce)
                {
                    kuce.Add(new ModnaKucaPregled(m.Naziv, m.ImeOsnivaca, m.PrezimeOsnivaca, m.Drzava, m.Grad));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return kuce;

        }

        public static ModnaKucaBasic vratiKucu(string naziv)
        {
            ModnaKucaBasic mrb = new ModnaKucaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaKuca m = s.Load<FashionWeek.Entiteti.ModnaKuca>(naziv);
                mrb = new ModnaKucaBasic(m.Naziv, m.ImeOsnivaca, m.PrezimeOsnivaca, m.Drzava, m.Grad);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return mrb;
        }

        public static void obrisiModnuKucu(string k)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaKuca o = s.Load<FashionWeek.Entiteti.ModnaKuca>(k);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }


        public static ModnaKucaBasic azurirajModnuKucu(ModnaKucaBasic mr)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction transaction = s.BeginTransaction())
                {
                    // Load the entity from the database using the primary key
                    var k = s.Load<FashionWeek.Entiteti.ModnaKuca>(mr.Naziv);
                    if (k == null)
                    {
                        throw new Exception("Modna kuca not found");
                    }

                    // Update the entity's properties
                    k.ImeOsnivaca = mr.ImeOsnivaca;
                    k.Drzava = mr.Drzava;
                    k.Grad = mr.Grad;
                    k.PrezimeOsnivaca = mr.PrezimeOsnivaca;

                    // Save the changes
                    s.Update(k);
                    s.Flush();
                    transaction.Commit();
                }
            }
            catch (StaleObjectStateException ex)
            {
                // Handle concurrency issues
                // log.Error("StaleObjectStateException: ", ex);
                throw;
            }
            catch (Exception ec)
            {
                // Handle other exceptions
                // log.Error("Exception during update: ", ec);
                throw;
            }

            return mr;
        }


        #endregion

        #region Modni Kreator

        public static ModniKreatorBasic azurirajModnogKreatora(ModniKreatorBasic mr)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction transaction = s.BeginTransaction())
                {

                    var k = s.Load<FashionWeek.Entiteti.ModniKreator>(mr.MBR);
                    if (k == null)
                    {
                        throw new Exception("Modni kreator not found");
                    }


                    k.MBR = mr.MBR;
                    k.Pol = mr.Pol;
                    k.ZemljaPorekla = mr.ZemljaPorekla;
                    k.DatumRodjenja = mr.DatumRodjenja;
                    k.Ime = mr.Ime;
                    k.Prezime = mr.Prezime;
                    k.CenaUsluge = mr.CenaUsluge;


                    s.Update(k);
                    s.Flush();
                    transaction.Commit();
                }
            }
            catch (StaleObjectStateException ex)
            {
                // Handle concurrency issues
                // log.Error("StaleObjectStateException: ", ex);
                throw;
            }
            catch (Exception ec)
            {
                // Handle other exceptions
                // log.Error("Exception during update: ", ec);
                throw;
            }

            return mr;
        }

        public static ModniKreatorBasic vratiModnogKreatora(string mbr)
        {
            ModniKreatorBasic pb = new ModniKreatorBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModniKreator o = s.Load<FashionWeek.Entiteti.ModniKreator>(mbr);

                pb = new ModniKreatorBasic(o.MBR, o.Pol, o.DatumRodjenja, o.ZemljaPorekla, o.Ime, o.Prezime, o.CenaUsluge);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static List<ModniKreatorPregled> vratiModneKreatore(string naziv)
        {
            List<ModniKreatorPregled> sviKreatori = new List<ModniKreatorPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ModniKreator> kreatori = from o in sesija.Query<FashionWeek.Entiteti.ModniKreator>() where o.NazivModneKuce.Naziv == naziv select o;

                foreach (FashionWeek.Entiteti.ModniKreator m in kreatori)
                {
                    sviKreatori.Add(new ModniKreatorPregled(m.MBR, m.Pol, m.DatumRodjenja, m.ZemljaPorekla, m.Ime, m.Prezime, m.CenaUsluge));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return sviKreatori;

        }

        public static List<ModniKreatorPregled> vratiSveModneKreatore()
        {
            List<ModniKreatorPregled> sviKreatori = new List<ModniKreatorPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ModniKreator> kreatori = from o in sesija.Query<FashionWeek.Entiteti.ModniKreator>() select o;

                foreach (FashionWeek.Entiteti.ModniKreator m in kreatori)
                {
                    sviKreatori.Add(new ModniKreatorPregled(m.MBR, m.Pol, m.DatumRodjenja, m.ZemljaPorekla, m.Ime, m.Prezime, m.CenaUsluge));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return sviKreatori;

        }

        public static void obrisiModnogKreatora(string k)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModniKreator o = s.Load<FashionWeek.Entiteti.ModniKreator>(k);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        public static List<ModniKreatorPregled> vratiModneKreatoreIzOrganizatora(int org)
        {
            List<ModniKreatorPregled> sviKreatori = new List<ModniKreatorPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ModniKreator> kreatori = from o in sesija.Query<FashionWeek.Entiteti.ModniKreator>() where o.OrganizatorID.OrganizatorID == org select o;

                foreach (FashionWeek.Entiteti.ModniKreator m in kreatori)
                {
                    sviKreatori.Add(new ModniKreatorPregled(m.MBR, m.Pol, m.DatumRodjenja, m.ZemljaPorekla, m.Ime, m.Prezime, m.CenaUsluge));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return sviKreatori;

        }

        public static void sacuvajKreatora(ModniKreatorBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModniKreator m = new FashionWeek.Entiteti.ModniKreator();

                m.MBR = mr.MBR;
                m.Pol = mr.Pol;
                m.DatumRodjenja = mr.DatumRodjenja;
                m.ZemljaPorekla = mr.ZemljaPorekla;
                m.Ime = mr.Ime;
                m.Prezime = mr.Prezime;
                m.CenaUsluge = mr.CenaUsluge;

                FashionWeek.Entiteti.ModnaKuca kuca = s.Load<FashionWeek.Entiteti.ModnaKuca>(mr.NazivModneKuce.Naziv);

                FashionWeek.Entiteti.Organizator organizator = s.Load<FashionWeek.Entiteti.Organizator>(mr.OrganizatorID.OrganizatorID);


                m.NazivModneKuce = kuca;
                m.OrganizatorID = organizator;
                s.Save(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion

        #region Modna Agencija

        public static List<ModnaAgencijaPregled> vratiModneAgencije()
        {
            List<ModnaAgencijaPregled> agencije = new List<ModnaAgencijaPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ModnaAgencija> sveAgencije = from o in sesija.Query<FashionWeek.Entiteti.ModnaAgencija>() select o;

                foreach (FashionWeek.Entiteti.ModnaAgencija m in sveAgencije)
                {
                    agencije.Add(new ModnaAgencijaPregled(m.PIB, m.Naziv, m.DatumOsnivanja, m.Drzava, m.Grad, m.PInternacionalna));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return agencije;

        }

        public static List<ModnaAgencijaPregled> vratiModneAgencije(string id)
        {
            List<ModnaAgencijaPregled> revije = new List<ModnaAgencijaPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ModnaAgencija> sveAgencije = from o in sesija.Query<FashionWeek.Entiteti.ModnaAgencija>() where o.PIB == id select o;

                foreach (FashionWeek.Entiteti.ModnaAgencija m in sveAgencije)
                {
                    revije.Add(new ModnaAgencijaPregled(m.PIB, m.Naziv, m.DatumOsnivanja, m.Drzava, m.Grad, m.PInternacionalna));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return revije;

        }


        public static void sacuvajModnuAgenciju(ModnaAgencijaBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaAgencija m = new FashionWeek.Entiteti.ModnaAgencija();

                m.PIB = mr.PIB;
                m.Naziv = mr.Naziv;
                m.DatumOsnivanja = mr.DatumOsnivanja;
                m.Drzava = mr.Drzava;
                m.Grad = mr.Grad;
                m.PInternacionalna = mr.PInternacionalna;


                s.Save(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static ModnaAgencijaBasic vratiModnuAgenciju(string pib)
        {
            ModnaAgencijaBasic pb = new ModnaAgencijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaAgencija o = s.Load<FashionWeek.Entiteti.ModnaAgencija>(pib);

                pb = new ModnaAgencijaBasic(o.PIB, o.Naziv, o.DatumOsnivanja, o.Drzava, o.Grad, o.PInternacionalna);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }




        public static List<NaziviZemaljaPregled> vratiZemlje(string id)
        {
            List<NaziviZemaljaPregled> zemlje = new List<NaziviZemaljaPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.NaziviZemalja> sveZemlje = from o in sesija.Query<FashionWeek.Entiteti.NaziviZemalja>() where o.Id.Agencija.PIB == id select o;

                foreach (FashionWeek.Entiteti.NaziviZemalja m in sveZemlje)
                {
                    zemlje.Add(new NaziviZemaljaPregled(m.Id));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return zemlje;

        }



        public static void obrisiModnuAgenciju(string k)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaAgencija o = s.Load<FashionWeek.Entiteti.ModnaAgencija>(k);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        public static ModnaAgencijaBasic azurirajModnuAgenciju(ModnaAgencijaBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ModnaAgencija m = s.Load<FashionWeek.Entiteti.ModnaAgencija>(mr.PIB);

                m.Naziv = mr.Naziv;
                m.Grad = mr.Grad;
                m.PIB = mr.PIB;
                m.DatumOsnivanja = mr.DatumOsnivanja;
                m.Drzava = mr.Drzava;
                m.PInternacionalna = m.PInternacionalna;


                s.Update(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return mr;
        }




        #endregion

        #region Manekeni

        public static void sacuvajManekena(CasopisiBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.Casopisi m = new FashionWeek.Entiteti.Casopisi();

                m.Id.NaziviCasopisa = mr.Id.NaziviCasopisi;

                Maneken maneken = new Maneken();
                maneken.MBR = mr.Id.Maneken.MBR;

                m.Id.Maneken = maneken;


                s.Save(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static List<ManekenPregled> vratiSveManekene()
        {
            List<ManekenPregled> manekeni = new List<ManekenPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.Maneken> sviManekeni = from o in sesija.Query<FashionWeek.Entiteti.Maneken>() select o;

                foreach (FashionWeek.Entiteti.Maneken m in sviManekeni)
                {
                    manekeni.Add(new ManekenPregled(m.MBR, m.Pol, m.DatumRodjenja, m.ZemljaPorekla, m.Ime, m.Prezime, m.BojaKose, m.Visina, m.BojaOciju, m.Tezina, m.KonfekcijskiBroj));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return manekeni;

        }

        public static void obrisiManekena(string k)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.Maneken o = s.Load<FashionWeek.Entiteti.Maneken>(k);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        public static List<ManekenPregled> vratiManekene(string pib)
        {
            List<ManekenPregled> manekeni = new List<ManekenPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.Maneken> sviManekeni = from o in sesija.Query<FashionWeek.Entiteti.Maneken>() where o.PIBModneAgencije.PIB == pib select o;

                foreach (FashionWeek.Entiteti.Maneken p in sviManekeni)
                {
                    manekeni.Add(new ManekenPregled(p.MBR, p.Pol, p.DatumRodjenja, p.ZemljaPorekla, p.Ime, p.Prezime, p.BojaKose, p.Visina, p.BojaOciju, p.Tezina, p.KonfekcijskiBroj));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return manekeni;

        }

        public static void sacuvajManekena(ManekenBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.Maneken m = new FashionWeek.Entiteti.Maneken();

                m.MBR = mr.MBR;
                m.Pol = mr.Pol;
                m.DatumRodjenja = mr.DatumRodjenja;
                m.ZemljaPorekla = mr.ZemljaPorekla;
                m.Ime = mr.Ime;
                m.Prezime = mr.Prezime;
                m.BojaKose = mr.BojaKose;
                m.Visina = mr.Visina;
                m.BojaOciju = mr.BojaOciju;
                m.Tezina = mr.Tezina;
                m.KonfekcijskiBroj = mr.KonfekcijskiBroj;

                FashionWeek.Entiteti.ModnaAgencija agencija = s.Load<FashionWeek.Entiteti.ModnaAgencija>(mr.PIBModneAgencije.PIB);

                m.PIBModneAgencije = agencija;

                s.Save(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        #endregion

        #region Nastupa


        public static List<ModnaRevijaPregled> revijeNaKojimaNastupaManeken(string mbr)
        {
            List<ModnaRevijaPregled> revije = new List<ModnaRevijaPregled>();

            try
            {
                using (ISession sesija = DataLayer.GetSession())
                {
                    var query = from o in sesija.Query<FashionWeek.Entiteti.Nastupa>()
                                where o.Id.ManekenNaReviji.MBR == mbr
                                select o;

                    foreach (var nastup in query)
                    {
                        var revija = nastup.Id.NaReviji;

                        var pregled = new ModnaRevijaPregled(
                            revija.IdModneRevije,
                            revija.RedniBroj,
                            revija.Naziv,
                            revija.Grad,
                            revija.DatumOdrzavanja,
                            revija.VremeOdrzavanja,
                            revija.ImeJavneLicnosti,
                            revija.PrezimeJavneLicnosti,
                            revija.ZanimanjeJL);

                        revije.Add(pregled);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return revije;
        }


        public static List<ManekenPregled> manekeniKojiNastupaju(int id)
        {
            List<ManekenPregled> manekeni = new List<ManekenPregled>();

            try
            {
                using (ISession sesija = DataLayer.GetSession())
                {
                    var query = from o in sesija.Query<FashionWeek.Entiteti.Nastupa>()
                                where o.Id.NaReviji.IdModneRevije == id
                                select o;

                    foreach (var nastup in query)
                    {
                        var maneken = nastup.Id.ManekenNaReviji;
                        var pregled = new ManekenPregled(
                            maneken.MBR,

                            maneken.Pol,
                            maneken.DatumRodjenja,
                            maneken.ZemljaPorekla,
                            maneken.Ime,
                            maneken.Prezime,
                            maneken.BojaKose,
                            maneken.Visina,
                            maneken.BojaOciju,
                            maneken.Tezina,

                            maneken.KonfekcijskiBroj);

                        manekeni.Add(pregled);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return manekeni;
        }


        #endregion

        #region Predstavlja

        public static List<ModniKreatorPregled> kreatoriKojiPredstavljaju(int id)
        {
            List<ModniKreatorPregled> kreatori = new List<ModniKreatorPregled>();

            try
            {
                using (ISession sesija = DataLayer.GetSession())
                {
                    var query = from o in sesija.Query<FashionWeek.Entiteti.Predstavlja>()
                                where o.Id.NaModnojReviji.IdModneRevije == id
                                select o;

                    foreach (var predstavlja in query)
                    {
                        var kreator = predstavlja.Id.MKPredstavlja;
                        var pregled = new ModniKreatorPregled(

                            kreator.MBR,
                            kreator.Pol,
                            kreator.DatumRodjenja,
                            kreator.ZemljaPorekla,
                            kreator.Ime,
                            kreator.Prezime,
                            kreator.CenaUsluge

                            );

                        kreatori.Add(pregled);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return kreatori;
        }
        #endregion

        #region Spec gost

        public static List<ModniKreatorPregled> specijalniGost(int id)
        {
            List<ModniKreatorPregled> kreatori = new List<ModniKreatorPregled>();

            try
            {
                using (ISession sesija = DataLayer.GetSession())
                {
                    var query = from o in sesija.Query<FashionWeek.Entiteti.SpecijalniGost>()
                                where o.IDModneRevije.IdModneRevije == id
                                select o;

                    foreach (var predstavlja in query)
                    {
                        var kreator = predstavlja.MBRModniKreator;
                        var pregled = new ModniKreatorPregled(

                            kreator.MBR,
                            kreator.Pol,
                            kreator.DatumRodjenja,
                            kreator.ZemljaPorekla,
                            kreator.Ime,
                            kreator.Prezime,
                            kreator.CenaUsluge

                            );

                        kreatori.Add(pregled);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return kreatori;
        }


        #endregion

        #region NaziviZemalja

        public static void obrisiZemlju(NaziviZemalja z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //FashionWeek.Entiteti.NaziviZemalja o = new FashionWeek.Entiteti.NaziviZemalja();



                FashionWeek.Entiteti.NaziviZemalja o = s.Load<FashionWeek.Entiteti.NaziviZemalja>(z);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions
                Console.WriteLine(ec.Message);
            }
        }


        public static NaziviZemalja DohvatiNaziviZemaljaId(string nazivZemlje)
        {
            ISession s = DataLayer.GetSession();

            var result = s.Query<FashionWeek.Entiteti.NaziviZemalja>()
                          .Where(z => z.Id.Zemlje == nazivZemlje)

                          .FirstOrDefault();

            s.Close();

            return result;
        }

        public static List<NaziviZemaljaPregled> vratiNaziveZemalja(string id)
        {
            List<NaziviZemaljaPregled> zemlje = new List<NaziviZemaljaPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.NaziviZemalja> sveZemlje = from o in sesija.Query<FashionWeek.Entiteti.NaziviZemalja>() where o.Id.Agencija.PIB == id select o;

                foreach (FashionWeek.Entiteti.NaziviZemalja m in sveZemlje)
                {
                    zemlje.Add(new NaziviZemaljaPregled(m.Id));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return zemlje;

        }

        public static void sacuvajZemlje(NaziviZemaljaBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.NaziviZemalja m = new FashionWeek.Entiteti.NaziviZemalja();

                m.Id.Zemlje = mr.Id.Zemlje;
                
                ModnaAgencija agencija = new ModnaAgencija();
                agencija.PIB = mr.Id.Agencija.PIB;

                m.Id.Agencija = agencija;
                

                s.Save(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        #endregion

        #region Imena vlasnika

        public static List<ImenaVlasnikaPregled> vratiVlasnike(string id)
        {
            List<ImenaVlasnikaPregled> vlasnici = new List<ImenaVlasnikaPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.ImenaVlasnika> sviVlasnici = from o in sesija.Query<FashionWeek.Entiteti.ImenaVlasnika>() where o.Id.ModnaKuca.Naziv == id select o;

                foreach (FashionWeek.Entiteti.ImenaVlasnika m in sviVlasnici)
                {
                    vlasnici.Add(new ImenaVlasnikaPregled(m.Id));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return vlasnici;

        }

        #endregion

        #region Casopisi

        public static List<CasopisiPregled> vratiCasopise(string mbr)
        {
            List<CasopisiPregled> casopisi = new List<CasopisiPregled>();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IEnumerable<FashionWeek.Entiteti.Casopisi> sviCasopisi = from o in sesija.Query<FashionWeek.Entiteti.Casopisi>() where o.Id.Maneken.MBR == mbr select o;

                foreach (FashionWeek.Entiteti.Casopisi m in sviCasopisi)
                {
                    casopisi.Add(new CasopisiPregled(m.Id));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return casopisi;

        }


        #endregion

        #region Imena Vlasnika

        public static void sacuvajVlasnika(ImenaVlasnikaBasic mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FashionWeek.Entiteti.ImenaVlasnika m = new FashionWeek.Entiteti.ImenaVlasnika();

                m.Id.ImenaVlasnika = mr.Id.ImenaVlasnika;

                ModnaKuca modnaKuca = new ModnaKuca();
                modnaKuca.Naziv = mr.Id.Kuca.Naziv;

                m.Id.ModnaKuca = modnaKuca;


                s.Save(m);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion


    }
}
