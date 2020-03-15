using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tvpProjekatPrvi
{
    [Serializable]
    class Automobil
    {
        static public int NovID(List<Automobil> a)
        {
            Random rnd = new Random();
            var br = rnd.Next(1000, 9000);
            foreach (var id in a)
            {
                if (br.Equals(id.id))
                {
                    br = NovID(a);
                    return br;
                }
            }
            return br;
        }


        string marka;
        string model;
        string pogon;
        string menjac;
        string karoserija;
        string gorivo;
        int kubikaza;
        int brVrata;
        int godiste;
        int id;
        bool rezervisan;

        public Automobil() { }

        public Automobil(int id ,string marka, string model, string pogon, string menjac, string karoserija, string gorivo, int kubikaza,int brVrata, int godiste)
        {
            this.id = id;
            this.Marka = marka;
            this.Model = model;
            this.Pogon = pogon;
            this.Menjac = menjac;
            this.Karoserija = karoserija;
            this.Kubikaza = kubikaza;
            this.Gorivo = gorivo;
            this.BrVrata = brVrata;
            this.Godiste = godiste;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Pogon { get => pogon; set => pogon = value; }
        public string Menjac { get => menjac; set => menjac = value; }
        public string Karoserija { get => karoserija; set => karoserija = value; }
        public string Gorivo { get => gorivo; set => gorivo = value; }
        public int Kubikaza { get => kubikaza; set => kubikaza = value; }
        public int BrVrata { get => brVrata; set => brVrata = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public int ID { get => id; set => id = value; }
        public bool Rezervisan { get => rezervisan; set => rezervisan = value; }
    }
}
