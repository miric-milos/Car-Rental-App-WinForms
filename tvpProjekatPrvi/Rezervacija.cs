using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tvpProjekatPrvi
{
    [Serializable]
    class Rezervacija
    {
        private int idKupca;
        protected int idAuta;
        protected int cena;
        protected DateTime datumOd;
        protected DateTime datumDo;

        public Rezervacija(int idKupca, int idAuta, int cena, DateTime datumOd, DateTime datumDo)
        {
            this.idKupca = idKupca;
            this.idAuta = idAuta;
            this.cena = cena;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
        }

        public Rezervacija()
        {
            this.idKupca = 0;
            this.idAuta = 0;
            this.cena = 0;
        }

        public Rezervacija(int idAuta, int cena, DateTime datumOd, DateTime datumDo)
        {
            this.idAuta = idAuta;
            this.cena = cena;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
        }

        public int IdKupca { get => idKupca; set => idKupca = value; }
        public int IdAuta { get => idAuta; set => idAuta = value; }
        public int Cena { get => cena; set => cena = value; }
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        public DateTime DatumDo { get => datumDo; set => datumDo = value; }
    }
}
