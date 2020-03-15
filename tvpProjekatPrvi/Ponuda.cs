using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tvpProjekatPrvi
{
    [Serializable]
    class Ponuda : Rezervacija
    {
        static public int NovID(List<Ponuda> p)
        {
            Random rnd = new Random();
            var br = rnd.Next(1000, 9000);
            foreach (var id in p)
            {
                if (br.Equals(id.idPonude))
                {
                    br = NovID(p);
                    return br;
                }
            }
            return br;
        }

        private int idPonude;

        public Ponuda(int idPonude, int idAuta, int cena, DateTime datumOd, DateTime datumDo) : base(idAuta, cena, datumOd, datumDo)
        {
            IdPonude = idPonude;
            IdAuta = idAuta;
            Cena = cena;
            DatumOd = datumOd;
            DatumDo = datumDo;
        }

        public Ponuda()    { }

        public int IdAuta { get; set; }
        public int Cena { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int IdPonude { get => idPonude; set => idPonude = value; }
    }
}