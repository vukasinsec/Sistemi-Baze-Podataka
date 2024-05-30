using FashionWeek.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FashionWeek
{

    #region Osoba
    public class OsobaBasic
    {
        public string MBR { get; set; }
        public char Pol { get; set; }
        
        public DateTime DatumRodjenja { get; set; }
        public string ZemljaPorekla { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public OsobaBasic(string ombr, char p, DateTime dr, string zp,string i,string pr)
        {
            this.MBR = ombr;
            this.Pol = p;
            this.DatumRodjenja = dr;
            this.ZemljaPorekla = zp;
            this.Ime = i;
            this.Prezime = pr;
        }
        public OsobaBasic()
        {
           
        }
    }
    public class ManekenBasic : OsobaBasic
    {
        public string BojaKose;
        public int Visina;
        public string BojaOciju;
        public float Tezina;
        public string KonfekcijskiBroj;
        public ModnaAgencijaBasic PIBModneAgencije;
        public virtual IList<ModnaRevijaBasic> ModneRevijeManekeni { get; set; }
        public virtual IList<NastupaBasic> NastupaManeken { get; set; }
        public virtual IList<CasopisiBasic> UcasopisimaManeken { get; set; }

        //da li treba i liste???
        public ManekenBasic()
        {
            ModneRevijeManekeni = new List<ModnaRevijaBasic>();
            NastupaManeken = new List<NastupaBasic>();
            UcasopisimaManeken = new List<CasopisiBasic>();

        }
        public ManekenBasic(string ombr, char p, DateTime dr, string zp, string i, string pr,string bk, int visina, string bojaOciju, float tezina, string konfekcijskiBroj) : base(ombr, p, dr, zp, i, pr)
        {
            Visina = visina;
            BojaOciju = bojaOciju;
            Tezina = tezina;
            KonfekcijskiBroj = konfekcijskiBroj;
            BojaKose = bk;
        }


    }



    public class ModniKreatorBasic: OsobaBasic
    {
        public int CenaUsluge;
        public OrganizatorBasic OrganizatorID;
        public ModnaKucaBasic NazivModneKuce;

        public virtual IList<SpecijalniGostBasic>? GostNaModnojReviji { get; set; } = [];

        public virtual IList<ModnaRevijaBasic> ModneRevijeMK { get; set; }

        public virtual IList<PredstavljaBasic> PredstavljaMK { get; set; }
        //kao za nastupa
        //liste
        public ModniKreatorBasic()
        {
            GostNaModnojReviji = new List<SpecijalniGostBasic>();
            ModneRevijeMK = new List<ModnaRevijaBasic>();
            PredstavljaMK= new List<PredstavljaBasic>();

        }
        public ModniKreatorBasic(string ombr, char p, DateTime dr, string zp, string i, string pr, int cenaUsluge) : base(ombr, p, dr, zp, i, pr)
        {
            CenaUsluge = cenaUsluge;
            
        }
    }

   
    public class OsobaPregled
    {
        public string MBR { get; set; }
        public char Pol { get; set; }

        public DateTime DatumRodjenja { get; set; }
        public string ZemljaPorekla { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        //da li treba virtual???
        public OsobaPregled(string ombr, char p, DateTime dr, string zp, string i, string pr)
        {
            this.MBR = ombr;
            this.Pol = p;
            this.DatumRodjenja = dr;
            this.ZemljaPorekla = zp;
            this.Ime = i;
            this.Prezime = pr;
        }

        public OsobaPregled()
        {
        }
       
    }
    public class ManekenPregled : OsobaPregled
    {
        public string BojaKose;
        public int Visina;
        public string BojaOciju;
        public float Tezina;
        public string KonfekcijskiBroj;
        public ModnaAgencijaBasic PIBModneAgencije;
        public ManekenPregled(string ombr, char p, DateTime dr, string zp, string i, string pr,string BojaKosee, int visina, string bojaOciju, float tezina, string konfekcijskiBroj) : base(ombr, p, dr, zp, i, pr)
        {
            Visina = visina;
            BojaOciju = bojaOciju;
            Tezina = tezina;
            KonfekcijskiBroj = konfekcijskiBroj;
            BojaKose = BojaKosee;
        }

        public ManekenPregled() { }
    }

    public class ModniKreatorPregled : OsobaPregled
    {
        public int CenaUsluge;
        public OrganizatorBasic OrganizatorID;
        public ModnaKucaBasic NazivModneKuce;

        public ModniKreatorPregled(string ombr, char p, DateTime dr, string zp, string i, string pr, int cenaUsluge) : base(ombr, p, dr, zp, i, pr)
        {
            CenaUsluge = cenaUsluge;
            

        }
        public ModniKreatorPregled() { }
    }

  

    #endregion

    #region ModnaAgencija
    public class ModnaAgencijaPregled
    {
        public string PIB;
        public string Naziv;
        public DateTime DatumOsnivanja;
        public string Drzava;

        public string Grad;
        // public  int? PDomaca;
        public int PInternacionalna;

        public ModnaAgencijaPregled()
        {

        }
        public ModnaAgencijaPregled(string pib,string naziv,DateTime d,string drz,string gr,int f)
        {
            this.PIB = pib;
            this.Naziv = naziv;
            this.DatumOsnivanja= d;
            this.Drzava = drz;
            this.Grad = gr;
            this.PInternacionalna = f;
        }
    }

    public class ModnaAgencijaBasic
    {
        public string PIB;
        public string Naziv;
        public DateTime DatumOsnivanja;
        public string Drzava;

        public string Grad;
        // public  int? PDomaca;
        public int PInternacionalna;

        public virtual IList<NaziviZemaljaBasic> NaziviZemalja { get; set; }

        public virtual IList<ManekenBasic> Manekeni { get; set; }

        public ModnaAgencijaBasic()
        {
            NaziviZemalja = new List<NaziviZemaljaBasic>();
            Manekeni=new List<ManekenBasic>();
          
        }
        public ModnaAgencijaBasic(string pib, string naziv, DateTime d, string drz, string gr, int f)
        {
            this.PIB = pib;
            this.Naziv = naziv;
            this.DatumOsnivanja = d;
            this.Drzava = drz;
            this.Grad = gr;
            this.PInternacionalna = f;
        }
    }


    #endregion

    #region ModnaRevija

    public class ModnaRevijaPregled
    {
        public int IdModneRevije;
        public int RedniBroj;
        public string Naziv;
        public string Grad;
        public DateTime DatumOdrzavanja;
        public int VremeOdrzavanja;
        public string ImeJavneLicnosti;
        public string PrezimeJavneLicnosti;
        public string ZanimanjeJL;
        public  OrganizatorBasic OrganizatorID;
    

        public ModnaRevijaPregled()
        {

        }
        public ModnaRevijaPregled(int idModneRevije,int rb,string n,string g,DateTime d,int v,string i,string p,string z)
        {
            this.IdModneRevije = idModneRevije;
            this.Naziv= n;
            this.RedniBroj= rb;
            this.Grad= g;
            this.DatumOdrzavanja= d;
            this.VremeOdrzavanja = v;
            this.ImeJavneLicnosti= i;
            this.PrezimeJavneLicnosti = p;
            this.ZanimanjeJL= z;
        }
        /*
        public ModnaRevijaPregled(int idModneRevije, int redniBroj, string? naziv, string? grad, DateTime datumOdrzavanja, int vremeOdrzavanja, string? imeJavneLicnosti, string? prezimeJavneLicnosti, string? zanimanjeJL)
        {
            IdModneRevije = idModneRevije;
            this.RedniBroj = redniBroj;
            Naziv = naziv;
            Grad = grad;
            this.DatumOdrzavanja = datumOdrzavanja;
            this.VremeOdrzavanja = vremeOdrzavanja;
            ImeJavneLicnosti = imeJavneLicnosti;
            PrezimeJavneLicnosti = prezimeJavneLicnosti;
            ZanimanjeJL = zanimanjeJL;
        }
        */
    }

    public class ModnaRevijaBasic
    {
        public int IdModneRevije;
        public int RedniBroj;
        public string Naziv;
        public string Grad;
        public DateTime DatumOdrzavanja;
        public int VremeOdrzavanja;
        public string ImeJavneLicnosti;
        public string PrezimeJavneLicnosti;
        public string ZanimanjeJL;
        public OrganizatorBasic OrganizatorID;

        public virtual IList<ManekenBasic> Manekeni { get; set; }
        public virtual IList<ModniKreatorBasic> ModniKreatori { get; set; }

        public virtual IList<PredstavljaBasic> PredstavljajuMK { get; set; }

        public virtual IList<NastupaBasic> NastupajuManekeni { get; set; } = [];
        public virtual IList<SpecijalniGostBasic> GostiNaModnojReviji { get; set; } = [];
        public object Value { get; }

        public ModnaRevijaBasic()
        {
            Manekeni = new List<ManekenBasic>();
            ModniKreatori= new List<ModniKreatorBasic>();
            PredstavljajuMK = new List<PredstavljaBasic>();
            NastupajuManekeni= new List<NastupaBasic>();
            GostiNaModnojReviji=new List<SpecijalniGostBasic>();
        }
        public ModnaRevijaBasic(int idModneRevije, int rb, string n, string g, DateTime d, int v, string i, string p, string z)
        {
            this.IdModneRevije = idModneRevije;
            this.Naziv = n;
            this.RedniBroj = rb;
            this.Grad = g;
            this.DatumOdrzavanja = d;
            this.VremeOdrzavanja = v;
            this.ImeJavneLicnosti = i;
            this.PrezimeJavneLicnosti = p;
            this.ZanimanjeJL = z;
        }

        public ModnaRevijaBasic(int id)
        {
            IdModneRevije = id;
        }
    }

   
    #endregion

    #region ModnaKuca
    public class ModnaKucaPregled
    {
        public string Naziv;
        public string ImeOsnivaca;
        public string PrezimeOsnivaca;
        public string Drzava;
        public string Grad;
        public OrganizatorBasic OrganizatorID;


        public ModnaKucaPregled()
        {

        }
        public ModnaKucaPregled(string n,string io,string po,string d,string g)
        {
            this.Naziv= n;
            this.ImeOsnivaca= io;
            this.PrezimeOsnivaca = po;
            this.Drzava= d;
            this.Grad= g;
        }

    }

    public class ModnaKucaBasic
    {
        public string Naziv;
        public string ImeOsnivaca;
        public string PrezimeOsnivaca;
        public string Drzava;
        public string Grad;
        public OrganizatorBasic OrganizatorID;
        
        public virtual IList<ModniKreatorBasic> ModniKreatori { get; set; }

        public virtual IList<ImenaVlasnikaBasic> Vlasnici { get; set; }
        public ModnaKucaBasic()
        {
            ModniKreatori= new List<ModniKreatorBasic>();
            Vlasnici= new List<ImenaVlasnikaBasic>();
        }
        public ModnaKucaBasic(string n, string io, string po, string d, string g)
        {
            this.Naziv = n;
            this.ImeOsnivaca = io;
            this.PrezimeOsnivaca = po;
            this.Drzava = d;
            this.Grad = g;
        }

    }

    #endregion

    #region Nastupa
    public class NastupaPregled
    {
        public NastupaId Id;
       
        public NastupaPregled()
        {

        }

        public NastupaPregled(NastupaId id)
        {
            this.Id = id;
            
        }
            
    }

    public class NastupaBasic
    {
        public NastupaIdBasic Id;
       

        public NastupaBasic()
        {

        }

        public NastupaBasic(NastupaIdBasic id)
        {
            this.Id = id;
            
        }

    }
    public class NastupaIdBasic
    {
        public  ManekenBasic ManekenNaReviji { get; set; }
        public  ModnaRevijaBasic NaReviji { get; set; }

        public NastupaIdBasic()
        {

        }

    }

    #endregion

    #region Predstavlja
    public class PredstavljaPregled
    {
        public PredstavljaId Id;

        public PredstavljaPregled()
        {

        }

        public PredstavljaPregled(PredstavljaId id)
        {
            this.Id = id;

        }

    }

    public class PredstavljaBasic
    {
        public PredstavljaIdBasic Id;


        public PredstavljaBasic()
        {

        }

        public PredstavljaBasic(PredstavljaIdBasic id)
        {
            this.Id = id;

        }

    }
    public class PredstavljaIdBasic
    {
        public ModniKreatorBasic MKPredstavlja { get; set; }
        public ModnaRevijaBasic NaModnojReviji { get; set; }

        public PredstavljaIdBasic()
        {

        }

    }

    #endregion

    #region Organizator
    public class OrganizatorPregled 
    {
        public int OrganizatorID;
        public string Kolekcija;
        public char PrvaModnaRevija;
        
        public OrganizatorPregled()
        {

        }
        public OrganizatorPregled(int id,string k,char r)
        {
            this.OrganizatorID = id;
            this.Kolekcija = k;
            this.PrvaModnaRevija = r;
        }
    }
    public class OrganizatorBasic
    {
        public int OrganizatorID;
        public string Kolekcija;
        public char PrvaModnaRevija;

        public virtual IList<ModnaRevijaBasic> ModneRevije { get; set; }
        public virtual IList<ModnaKucaBasic> ModneKuce { get; set; }
        public virtual IList<ModniKreatorBasic> ModniKreatori { get; set; }

        public OrganizatorBasic()
        {
            ModneRevije= new List<ModnaRevijaBasic>();
            ModneKuce= new List<ModnaKucaBasic>();
            ModniKreatori= new List<ModniKreatorBasic>();

        }
        public OrganizatorBasic(int id, string k, char r)
        {
            this.OrganizatorID = id;
            this.Kolekcija = k;
            this.PrvaModnaRevija = r;
        }
    }


    #endregion

    #region SpecijalniGost
    public class SpecijalniGostPregled 
    {
        public int IDGosta;
        public ModniKreatorBasic MBRModniKreator;
        public ModnaRevijaBasic IDModneRevije;
       

        public SpecijalniGostPregled()
        {

        }

        public SpecijalniGostPregled(int id,ModniKreatorBasic mk,ModnaRevijaBasic mr)
        {
            this.IDGosta = id;
            this.MBRModniKreator= mk;
            this.IDModneRevije = mr;
        }

    }

    public class SpecijalniGostBasic 
    {
        public int IDGosta;
        public ModniKreatorBasic MBRModniKreator;
        public ModnaRevijaBasic IDModneRevije;

        public SpecijalniGostBasic()
        {

        }

        public SpecijalniGostBasic(int id, ModniKreatorBasic mk, ModnaRevijaBasic mr)
        {
            this.IDGosta = id;
            this.MBRModniKreator = mk;
            this.IDModneRevije = mr;
        }

    }

    #endregion

    #region Casopisi
    public class CasopisiPregled
    {
        public CasopisiId Id;

        public CasopisiPregled()
        {

        }

        public CasopisiPregled(CasopisiId id)
        {
            this.Id = id;

        }

    }

    public class CasopisiBasic
    {
        public CasopisiIdBasic Id;


        public CasopisiBasic()
        {

        }

        public CasopisiBasic(CasopisiIdBasic id)
        {
            this.Id = id;

        }

    }
    public class CasopisiIdBasic
    {
        private string? v;

        public ManekenBasic Maneken { get; set; }
        public string NaziviCasopisi { get; set; }
        //da li treba ovaj string da se doda u konstruktor???
        public CasopisiIdBasic()
        {

        }

        public CasopisiIdBasic(ManekenBasic maneken, string? v)
        {
            Maneken = maneken;
            this.NaziviCasopisi = v;
        }
    }

    #endregion

    #region ImenaVlasnika 
    public class ImenaVlasnikaPregled
    {
        public ImenaVlasnikaId Id;

        public ImenaVlasnikaPregled()
        {

        }

        public ImenaVlasnikaPregled(ImenaVlasnikaId id)
        {
            this.Id = id;

        }

    }

    public class ImenaVlasnikaBasic
    {
        public ImenaVlasnikaIdBasic Id;


        public ImenaVlasnikaBasic()
        {

        }

        public ImenaVlasnikaBasic(ImenaVlasnikaIdBasic id)
        {
            this.Id = id;

        }

      

        public ModnaKucaBasic Kuca { get; }
        public string? V { get; }
    }
    public class ImenaVlasnikaIdBasic
    {
        public ModnaKucaBasic ModnaKuca { get; set; }
        public string ImenaVlasnika { get; set; }
        public ModnaKucaBasic Kuca { get; }
        public string? V { get; }

        //da li treba ovaj string da se doda u konstruktor???
        public ImenaVlasnikaIdBasic()
        {

        }

        public ImenaVlasnikaIdBasic(ModnaKucaBasic kuca, string? v)
        {
            Kuca = kuca;
            ImenaVlasnika = v;
        }
    }
    #endregion

    #region NaziviZemalja
    public class NaziviZemaljaPregled
    {
        public NaziviZemaljaId Id;

        public NaziviZemaljaPregled()
        {

        }

        public NaziviZemaljaPregled(NaziviZemaljaId id)
        {
            this.Id = id;

        }

    }

    public class NaziviZemaljaBasic
    {
        public NaziviZemaljaIdBasic Id;

        public NaziviZemaljaBasic() { }
       

        public NaziviZemaljaBasic(NaziviZemaljaIdBasic id)
        {
            this.Id = id;

        }

    }
    public class NaziviZemaljaIdBasic
    {
        private string? v;

        public ModnaAgencijaBasic Agencija { get; set; }
        public string Zemlje { get; set; }
        //da li treba ovaj string da se doda u konstruktor???
        public NaziviZemaljaIdBasic(string z)
        {
            Zemlje = z;

        }

        public NaziviZemaljaIdBasic(ModnaAgencijaBasic agencija, string? v)
        {
            Agencija = agencija;
            this.Zemlje = v;
        }
        //public NaziviZemaljaIdBasic(string pib) {
        // Agencija.PIB = pib;
        //}
        //public NaziviZemaljaIdBasic() { }

    }



    #endregion


}
