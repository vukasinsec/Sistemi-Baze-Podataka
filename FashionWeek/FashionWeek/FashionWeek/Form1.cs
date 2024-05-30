using FashionWeek.Entiteti;
using NHibernate;
using FashionWeek;
using ProdavnicaIgracaka;
using System.Text;
using NHibernate.Linq;

namespace FashionWeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void cmdModnaAgencija_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaAgencija agencija = await session.LoadAsync<ModnaAgencija>("888888888");

                    if (agencija.PInternacionalna == 1)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Nazivi zemalja:");
                        foreach (NaziviZemalja nazivZemlje in agencija.NaziviZemalja)
                        {
                            sb.AppendLine(nazivZemlje.Id.Zemlje);
                        }
                        MessageBox.Show(sb.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Agencija nije internacionalna.");
                    }
                    MessageBox.Show($"Modna Agencija sa ID: 2 \"{agencija.Naziv}\" je pronađena.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.FormatExceptionMessage());
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }
        }

        private async void cmdDodajModnuAgenciju_Click(object sender, EventArgs e)
        {

            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {

                    DateTime datumOsnivanja = DateTime.Parse("13-MAY-24");

                    ModnaAgencija agencija = new()
                    {
                        PIB = "888888888",
                        Naziv = "TestZemlje",
                        DatumOsnivanja = datumOsnivanja,
                        Drzava = "Italija",
                        Grad = "Rim",
                        //    PDomaca = 0,
                        PInternacionalna = 1,
                        NaziviZemalja = new List<NaziviZemalja>()


                    };

                    NaziviZemalja zemlja1 = new NaziviZemalja { Id = new NaziviZemaljaId { Agencija = agencija, Zemlje = "Madjarska" } };
                    NaziviZemalja zemlja2 = new NaziviZemalja { Id = new NaziviZemaljaId { Agencija = agencija, Zemlje = "Hrvatska" } };
                    NaziviZemalja zemlja3 = new NaziviZemalja { Id = new NaziviZemaljaId { Agencija = agencija, Zemlje = "Crna Gora" } };

                    agencija.NaziviZemalja.Add(zemlja1);
                    agencija.NaziviZemalja.Add(zemlja2);
                    agencija.NaziviZemalja.Add(zemlja3);

                    //await session?.SaveAsync(p);
                    await session.SaveOrUpdateAsync(agencija);
                    await session.FlushAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }


        }

        private async void cmdDodajManekena_Click(object sender, EventArgs e)
        {

            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();



                if (session != null)
                {
                    DateTime datumOsnivanja = DateTime.Parse("13-MAY-24");

                    ModnaAgencija agencija = new()
                    {
                        PIB = "000000002",
                        Naziv = "Test za Dodaj ManekenaPIB",
                        DatumOsnivanja = datumOsnivanja,
                        Drzava = "Srbija",
                        Grad = "Nis",
                        PInternacionalna = 0


                    };

                    await session.SaveAsync(agencija);
                    await session.FlushAsync();

                    DateTime datumRodjenja = DateTime.Parse("13-APR-24");

                    Maneken maneken = new()
                    {
                        MBR = "1633343353333",
                        Pol = 'Z',
                        DatumRodjenja = datumRodjenja,
                        ZemljaPorekla = "Bugarska",
                        Ime = "Teodora",
                        Prezime = "Dzehverovic",
                        // TipOsobe = "Balerina",
                        BojaKose = "plava",
                        Visina = 190,
                        BojaOciju = "zelena",
                        Tezina = 55,
                        KonfekcijskiBroj = "S",
                        //    PIBModneAgencije = agencija,


                    };

                    //  agencija.Manekeni.Add(maneken);

                    //   await session.SaveAsync(agencija);
                    //await session.SaveOrUpdateAsync(maneken);
                    // await session.FlushAsync();

                    maneken.PIBModneAgencije = agencija;

                    await session.SaveOrUpdateAsync(maneken);
                    await session.FlushAsync();

                    StringBuilder sb = new();
                    sb.AppendLine($"Upisana je agencija sa podacima:");
                    sb.AppendLine(agencija.ToFormattedString());
                    sb.AppendLine();
                    sb.AppendLine($"Takođe, upisan je i maneken ove agencije sa podacima:");
                    sb.AppendLine(maneken.ToFormattedString());

                    MessageBox.Show(sb.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }



        }

        private async void cmdOneToManyMA_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaAgencija p = await session.LoadAsync<ModnaAgencija>("123456789");

                    StringBuilder sb = new();

                    sb.AppendLine($"ModnaAgencija sa PIDom: 123456789 naziva: {p.Naziv} ima manekene:");

                    foreach (Maneken o in p.Manekeni)
                    {
                        sb.AppendLine($"  Maneken MBR: {o.MBR}");
                    }

                    MessageBox.Show(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }
        }

        private async void cmdManyToOneMA_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Maneken o = await session.LoadAsync<Maneken>("2222222222222");

                    MessageBox.Show($"Maneken sa MBR: 2222222222222 i pripada agenciji: {o.PIBModneAgencije?.Naziv ?? ""}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }
        }

        private async void cmdUcitajModnuKucu_Click(object sender, EventArgs e)
        {

            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaKuca mk = await session.LoadAsync<ModnaKuca>("Elegance Couture");
                    MessageBox.Show($"Modna kuca sa datim nazivom je iz   \"{mk.Grad}\".");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.FormatExceptionMessage());
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }
        }

        private async void cmdDodajModnuKucu_Click(object sender, EventArgs e)
        {

            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {

                    // DateTime datumOsnivanja = DateTime.Parse("13-MAY-24");

                    ModnaKuca modnakuca = new()
                    {

                        Naziv = "NovaModnaKuca",
                        ImeOsnivaca = "Jovan",
                        PrezimeOsnivaca = "Jovic",
                        Drzava = "Srbija",
                        Grad = "Sombor",


                    };

                    //await session?.SaveAsync(p);
                    await session.SaveOrUpdateAsync(modnakuca);
                    await session.FlushAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

        }

        private async void cmdDodajModnogKreatora_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {





                    //await session?.SaveAsync(p);
                    // await session.SaveOrUpdateAsync(mk);
                    await session.FlushAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }


        }

        private async void cmdUcitajManekena_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Maneken m = await session.LoadAsync<Maneken>("1111111111111");
                    MessageBox.Show($"Maneken sa MBR prosledjenim \"{m.Pol}\" je pronađen.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.FormatExceptionMessage());
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

        }

        private async void cmdManekenNastupa_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaRevija mr = await session.LoadAsync<ModnaRevija>(3);

                    StringBuilder sb = new();
                    sb.AppendLine($"Na modnoj reviji sa ID: 3 nastupaju manekeni:");

                    foreach (Maneken m in mr.Manekeni)
                    {
                        sb.AppendLine(m.ToFormattedString());
                    }

                    MessageBox.Show(sb.ToString());

                    Maneken mm = await session.LoadAsync<Maneken>("1111111111111");

                    sb.Clear();
                    sb.AppendLine($"Maneken sa datim MBR i Imenom: {mm.Ime} nastupa na reviji:");

                    foreach (ModnaRevija r in mm.ModneRevijeManekeni)
                    {
                        sb.AppendLine(r.ToFormattedString());
                    }

                    MessageBox.Show(sb.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }
        }

        private async void cmdKucaKreator_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaKuca mkk = await session.LoadAsync<ModnaKuca>("Trendy Fashion");

                    StringBuilder sb = new();
                    sb.AppendLine($"Modna kuca sa nazivom: 2 ima modne kreatore:");

                    foreach (ModniKreator m in mkk.ModniKreatori)
                    {
                        sb.AppendLine(m.ToFormattedString());
                    }

                    MessageBox.Show(sb.ToString());

                    ModniKreator mk = await session.LoadAsync<ModniKreator>("1234567890123");



                    sb.Clear();
                    sb.AppendLine($"Modni kreator sa datim MBR i Imenom: {mk.Ime} je iz modne kuce: {mk.NazivModneKuce.Naziv}");

                    MessageBox.Show(sb.ToString());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

        }

        private async void cmdSpecijalniGostVeza_Click(object sender, EventArgs e)
        {

            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaRevija mr = await session.LoadAsync<ModnaRevija>(3);

                    StringBuilder sb = new();
                    sb.AppendLine($"Modna revija sa ID: 3 ima goste:");

                    foreach (SpecijalniGost s in mr.GostiNaModnojReviji)
                    {
                        sb.AppendLine($"{s.MBRModniKreator.Ime} {s.MBRModniKreator.Prezime}");
                    }

                    MessageBox.Show(sb.ToString());

                    ModniKreator mk = await session.LoadAsync<ModniKreator>("1234567890123");



                    sb.Clear();
                    sb.AppendLine($"Modni kreator sa datim MBR i Imenom: {mk.Ime} je gost na modnoj reviji: ");

                    foreach (SpecijalniGost s1 in mk.GostNaModnojReviji)
                    {
                        sb.AppendLine(s1.IDModneRevije.ToFormattedString());
                    }

                    MessageBox.Show(sb.ToString());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }


        }

        private async void cmdModniKreatorPredstavlja_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaRevija mr = await session.LoadAsync<ModnaRevija>(3);

                    StringBuilder sb = new();
                    sb.AppendLine($"Na modnoj reviji sa ID: 3 predstavljaju modni kreatori:");

                    foreach (ModniKreator mk in mr.ModniKreatori)
                    {
                        sb.AppendLine(mk.ToFormattedString());
                    }

                    MessageBox.Show(sb.ToString());

                    ModniKreator mm = await session.LoadAsync<ModniKreator>("1234567890123");

                    sb.Clear();
                    sb.AppendLine($"Modni kreator sa datim MBR i Imenom: {mm.Ime} predstavlja na reviji:");

                    foreach (ModnaRevija r in mm.ModneRevijeMK)
                    {
                        sb.AppendLine(r.ToFormattedString());
                    }

                    MessageBox.Show(sb.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

        }

        private async void cmdManekenCasopisi_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Maneken o = await session.LoadAsync<Maneken>("2222222222222");

                    StringBuilder sb = new StringBuilder();
                    foreach (Casopisi casopis in o.UcasopisimaManeken)
                    {
                        sb.AppendLine(casopis.Id.NaziviCasopisa);



                    }
                    MessageBox.Show($"Maneken sa MBR: 6789012345678 je na casopisima: {sb.ToString()}");

                }
                else
                {
                    MessageBox.Show("Maneken nije pronađen.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

        }

        private async void cmdCasopisManeken_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    // Napravite upit za entitet "Casopis" koristeći svojstvo "NazivCasopisa" kao filter
                    Casopisi c = await session.QueryOver<Casopisi>()
                                              .Where(casopis => casopis.Id.NaziviCasopisa == "Elle")
                                              .SingleOrDefaultAsync();

                    if (c != null)
                    {
                        // Učitajte Manekena koji pripada ovom Casopisu
                        await NHibernateUtil.InitializeAsync(c.Id.Maneken);

                        // Prikazujemo informacije o Manekenu
                        MessageBox.Show($"Casopis Vogue na naslovnoj ima manekena: {c.Id.Maneken.Ime}");
                    }
                    else
                    {
                        MessageBox.Show("Casopis 'Vogue' nije pronađen.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }
        }

        private async void cmdKucaVlasnici_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaKuca mk = await session.LoadAsync<ModnaKuca>("Trendy Fashion");

                    StringBuilder sb = new StringBuilder();
                    foreach (ImenaVlasnika iv in mk.Vlasnici)
                    {
                        sb.AppendLine(iv.Id.ImenaVlasnika);

                    }
                    MessageBox.Show($"Modna kuca Glamour style i vlasnik: {sb.ToString()}");

                }
                else
                {
                    MessageBox.Show("Modna kuca nije pronađena.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

        }

        private async void orgRevija_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Organizator o = await session.LoadAsync<Organizator>(3);

                    StringBuilder sb = new();

                    sb.AppendLine($"Organizator sa Id-jem: 3 organizuje modne revije:");

                    foreach (ModnaRevija mr in o.ModneRevije)
                    {
                        sb.AppendLine($"  Modna revija: {mr.Naziv}");
                    }

                    MessageBox.Show(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }
        }

        private async void cmdRevOrganizator_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaRevija mr = await session.LoadAsync<ModnaRevija>(3);

                    MessageBox.Show($"Modna revija id:9 organizovana od strane organizatora sa id-jem: {mr.OrganizatorID.OrganizatorID}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }
        }

        private async void cmdDodajReviju_Click(object sender, EventArgs e)
        {

            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();



                if (session != null)
                {
                    DateTime datumOsnivanja = DateTime.Parse("13-MAY-24");

                    Organizator org = new()
                    {
                        Kolekcija = "prolece",
                        PrvaModnaRevija = 'y'


                    };

                    await session.SaveAsync(org);
                    await session.FlushAsync();

                    DateTime datumRodjenja = DateTime.Parse("13-APR-24");

                    ModnaRevija mr = new()
                    {
                        RedniBroj = 3,
                        Naziv = "NovaModnaRevija",
                        Grad = "Nis",
                        DatumOdrzavanja = datumOsnivanja,
                        VremeOdrzavanja = 20,
                        ImeJavneLicnosti = "Lena",
                        PrezimeJavneLicnosti = "Lenic",
                        ZanimanjeJL = "glumica",
                        OrganizatorID = org


                    };

                    //  agencija.Manekeni.Add(maneken);

                    //   await session.SaveAsync(agencija);
                    //await session.SaveOrUpdateAsync(maneken);
                    // await session.FlushAsync();

                    mr.OrganizatorID = org;

                    await session.SaveOrUpdateAsync(mr);
                    await session.FlushAsync();

                    StringBuilder sb = new();
                    sb.AppendLine($"Upisan je org sa podacima:");
                    sb.AppendLine(org.ToFormattedString());
                    sb.AppendLine();
                    sb.AppendLine($"Takođe, upisana je i revija ovog org sa podacima:");
                    sb.AppendLine(mr.ToFormattedString());

                    MessageBox.Show(sb.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

        }

        private void cmdProba1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Maneken> manekeni = s.QueryOver<Maneken>()
                                                .Where(p => p.MBR == "1111111111111")
                                                .List<Maneken>();
                if (manekeni != null && manekeni.Count > 0)
                {
                    Maneken maneken = (Maneken)manekeni[0];

                    StringBuilder manekenInfo = new StringBuilder();
                    manekenInfo.AppendLine($"MBR: {maneken.MBR}");
                    manekenInfo.AppendLine($"Ime: {maneken.Ime}");
                    manekenInfo.AppendLine($"Prezime: {maneken.Prezime}");
                    manekenInfo.AppendLine($"Visina: {maneken.Visina}");
                    manekenInfo.AppendLine($"Tezina: {maneken.Tezina}");
                    //   manekenInfo.AppendLine($"Datum rođenja: {maneken.DatumRodjenja.ToString("dd.MM.yyyy")}");

                    // Prikazujemo informacije o manekenu
                    MessageBox.Show(manekenInfo.ToString(), "Informacije o manekenu");
                }
                else
                {
                    MessageBox.Show("Maneken sa zadatim MBR nije pronađen.", "Obaveštenje");
                }



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdProba2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Maneken o = s.Get<Maneken>("3333333333333");

                if (o != null)
                {
                    MessageBox.Show(o.PIBModneAgencije.Naziv);
                }
                else
                {
                    MessageBox.Show("Ne postoji ");
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdProba3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Maneken");

                IList<Maneken> manekeni = q.List<Maneken>();

                foreach (Maneken m in manekeni)
                {
                    MessageBox.Show(m.Ime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdProba4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Odeljenja koja nemaju info pult
                IQuery q = s.CreateQuery("from ModnaAgencija as o where o.PInternacionalna = 1");

                IList<ModnaAgencija> ma = q.List<ModnaAgencija>();

                foreach (ModnaAgencija o in ma)
                {
                    MessageBox.Show(o.Naziv + " " + o.Drzava);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdGrupisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select ma.Grad, count(ma) from ModnaAgencija ma "
                                        + " group by ma.Grad ");

                //za slucaj da upit vraca visestruku vrednost
                IList<object[]> result = q.List<object[]>();

                foreach (object[] r in result)
                {
                    string tip = (string)r[0];
                    // Int64 kase = (Int64)r[1];
                    long broj = (long)r[1];

                    MessageBox.Show(tip + " " + broj.ToString() + " ");
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdProba5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<ModnaAgencija> ma = s.QueryOver<ModnaAgencija>()
                                                .Where(x => x.Grad == "Nis")

                                                .List<ModnaAgencija>();

                foreach (ModnaAgencija o in ma)
                {
                    MessageBox.Show(o.Naziv);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private async void cmdObrisi_Click(object sender, EventArgs e)
        {

            ISession session = null;

            try
            {
                // Dobavljanje matičnog broja iz baze podataka
                session = DataLayer.GetSession();
                string maticniBroj = await session.Query<ModniKreator>()
                                                   .Where(k => k.MBR == "1234567890124")
                                                   .Select(k => k.MBR) // Pretpostavka: MBR se nalazi u polju Nešto
                                                   .FirstOrDefaultAsync();

                // Provera da li je matični broj prazan ili null
                if (string.IsNullOrEmpty(maticniBroj))
                {
                    MessageBox.Show("Nije moguće dobiti matični broj modnog kreatora iz baze.");
                    return;
                }

                using (ITransaction transaction = session.BeginTransaction())
                {
                    // Dobavljanje entiteta na osnovu matičnog broja
                    var kreator = await session.Query<ModniKreator>()
                                               .Where(k => k.MBR == maticniBroj)
                                               .FirstOrDefaultAsync();

                    if (kreator != null)
                    {
                        await session.DeleteAsync(kreator);
                        await transaction.CommitAsync();
                        MessageBox.Show("Modni kreator je uspešno obrisan.");
                    }
                    else
                    {
                        MessageBox.Show("Modni kreator sa datim matičnim brojem ne postoji.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja modnog kreatora: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        private async void cmdUcitajReviju_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    ModnaRevija revija = await session.LoadAsync<ModnaRevija>(3);


                    MessageBox.Show($"Modna revija ima organizatora {revija.OrganizatorID.OrganizatorID}");
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Organizatori:");
                    foreach (ModniKreator o in revija.OrganizatorID.ModniKreatori)
                    {
                        sb.AppendLine(o.Ime);
                    }
                    MessageBox.Show(sb.ToString());





                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.FormatExceptionMessage());
                MessageBox.Show(ex.FormatExceptionMessage());
            }
            finally
            {
                session?.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
