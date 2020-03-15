using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace tvpProjekatPrvi
{
    [Serializable]
    class Kupac : Korisnik
    {
        static public int NovID(List<Kupac> k)
        {
            Random rnd = new Random();
            var br = rnd.Next(1000, 9000);
            foreach (var id in k)
            {
                if (br.Equals(id.IdKupca))
                {
                    br = NovID(k);
                    return br;
                }
            }
            return br;
        }

        public Kupac() { }

        public Kupac(int idKupca ,string sifra, string korisnickoIme, string jmbg, string brTel, DateTime datumRodjenja, string ime, string prezime) : base(idKupca,sifra, korisnickoIme, jmbg, brTel, datumRodjenja, ime, prezime)
        {
            Sifra = sifra;
            KorisnickoIme = korisnickoIme;
            Jmbg = jmbg;
            BrTel = brTel;
            DatumRodjenja = datumRodjenja;
            Ime = ime;
            Prezime = prezime;
            IdKupca = idKupca;
        }
    }
}