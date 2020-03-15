using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace tvpProjekatPrvi
{
    [Serializable]
    class Korisnik
    {

        protected int idKupca;
        protected string ime;
        protected string prezime;
        protected string jmbg;
        protected string brTel;
        protected DateTime datumRodjenja;
        protected string sifra;
        protected string korisnickoIme;

        public Korisnik() { }

        public Korisnik(int idKupca, string sifra, string korisnickoIme, string jmbg, string brTel, DateTime datumRodjenja, string ime, string prezime)
        {
            this.idKupca = idKupca;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.brTel = brTel;
            this.datumRodjenja = datumRodjenja;
            this.sifra = sifra;
            this.korisnickoIme = korisnickoIme;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string BrTel { get => brTel; set => brTel = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public int IdKupca { get => idKupca; set => idKupca = value; }
    }
}