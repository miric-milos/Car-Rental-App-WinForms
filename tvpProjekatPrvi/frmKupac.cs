using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tvpProjekatPrvi
{
    public partial class frmKupac : Form
    {

        public frmKupac()
        {
            InitializeComponent();
        }

        //DESERIJALIZACIJA DATOTEKE KOJA SADRZI INFO. O PRIJAVLJENOM KORISNIKU
        private Kupac ulogovanNalog()
        {
            try
            {
                FileStream fb = new FileStream("UlogovanNalog.bin", FileMode.Open);
                BinaryFormatter br = new BinaryFormatter();

                Kupac k = (Kupac)br.Deserialize(fb);
                fb.Close();
                return k;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void frmKupac_Load_1(object sender, EventArgs e)
        {
            lbID.Text = "ID: " + ulogovanNalog().IdKupca.ToString();
            lbIme.Text = ulogovanNalog().Ime;
            lbPrezime.Text = ulogovanNalog().Prezime;
            lbBrTel.Text = ulogovanNalog().BrTel;
            lbJMBG.Text = ulogovanNalog().Jmbg;
            lbDatumRodjenja.Text = ulogovanNalog().DatumRodjenja.ToShortDateString();

            List<Automobil> kola = DesAuto();
            List<Rezervacija> tempList = new List<Rezervacija>();
            List<Rezervacija> listRez = new List<Rezervacija>();
            if (File.Exists("Rezervacije.bin"))
            {
                listRez = DesRez();
            }


            foreach (var rez in listRez)
            {
                if (rez.IdKupca.Equals(ulogovanNalog().IdKupca))
                    cmbRez.Items.Add(rez.IdAuta + " - " + rez.DatumOd.Date.ToShortDateString()
                         + " - " + rez.DatumDo.Date.ToShortDateString());
            }
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            Form frmRezervacija = new frmRezervacija();
            this.Hide();
            frmRezervacija.ShowDialog();
            this.Close();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogIn();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private List<Automobil> DesAuto()
        {
            FileStream fs = new FileStream("Automobili.bin", FileMode.Open);
            BinaryFormatter br = new BinaryFormatter();
            List<Automobil> l = (List<Automobil>)br.Deserialize(fs);
            fs.Close();

            return l;
        }

        private List<Rezervacija> DesRez()
        {
            FileStream fs = new FileStream("Rezervacije.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Rezervacija> list = (List<Rezervacija>)bf.Deserialize(fs);
            fs.Close();

            return list;
        }

        private void Serijalizuj(object o, string s)
        {
            FileStream fs = new FileStream(s + ".bin", FileMode.Create);
            BinaryFormatter br = new BinaryFormatter();
            br.Serialize(fs, o);
            fs.Flush(); fs.Close();
        }


        private void cmbRez_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Automobil> kola = DesAuto();
            List<Rezervacija> listRez = DesRez();
            int tempAutoId = 0;


            foreach (var rez in listRez)
                if (cmbRez.SelectedItem.Equals(rez.IdAuta + " - " + rez.DatumOd.Date.ToShortDateString()
                         + " - " + rez.DatumDo.Date.ToShortDateString()) && ulogovanNalog().IdKupca.Equals(rez.IdKupca))
                {
                    label9.Text = rez.DatumOd.Date.ToShortDateString();
                    label8.Text = rez.DatumDo.Date.ToShortDateString();
                    label7.Text = rez.Cena.ToString() + " RSD";
                    tempAutoId = rez.IdAuta;
                }


            foreach (var auto in kola)
                if (tempAutoId.Equals(auto.ID))
                {
                    lbmarka.Text = auto.Marka;
                    lbmodel.Text = auto.Model;
                    lbMenjac.Text = auto.Menjac;
                    lbKub.Text = auto.Kubikaza.ToString();
                    lbKaro.Text = auto.Karoserija;
                    lbPogon.Text = auto.Pogon;
                    lbGod.Text = auto.Godiste.ToString();
                    lbBrVrat.Text = auto.BrVrata.ToString();
                    lbgorivo.Text = auto.Gorivo;
                }

        }

        private void btnObrisiRez_Click(object sender, EventArgs e)
        {
            List<Rezervacija> listRez = DesRez();
            try
            {
                for (int i = listRez.Count - 1; i >= 0; i--)
                    if (cmbRez.SelectedItem.Equals(listRez[i].IdAuta + " - " + listRez[i].DatumOd.Date.ToShortDateString()
                             + " - " + listRez[i].DatumDo.Date.ToShortDateString()) && listRez[i].IdKupca.Equals(ulogovanNalog().IdKupca))
                        listRez.Remove(listRez[i]);

                foreach (Label lb in groupBox2.Controls.OfType<Label>())
                {
                    lb.Text = "...";
                }


                cmbRez.Items.Remove(cmbRez.SelectedItem);
                Serijalizuj(listRez, "Rezervacije");
                MessageBox.Show("Rezervacija obrisana.");
            }
            catch { MessageBox.Show("Niste odabrali rezervaciju"); }
        }
    }
}