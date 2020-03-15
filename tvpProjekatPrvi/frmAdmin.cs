using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tvpProjekatPrvi
{
    public partial class frmAdmin : Form
    {

        public frmAdmin()
        {
            InitializeComponent();
        }

        private List<Automobil> DeserijalizujKola()
        {
            FileStream fs = new FileStream("Automobili.bin", FileMode.Open);
            BinaryFormatter binform = new BinaryFormatter();
            List<Automobil> kola = (List<Automobil>)binform.Deserialize(fs);
            fs.Close();
            return kola;
        }

        private List<Ponuda> DeserijalizujPonude()
        {
            FileStream fs = new FileStream("Ponude.bin", FileMode.Open);
            BinaryFormatter binform = new BinaryFormatter();
            List<Ponuda> pon = (List<Ponuda>)binform.Deserialize(fs);
            fs.Close();
            return pon;
        }

        public void Serijalizuj(object o, string s)
        {
            FileStream fs = new FileStream(s + ".bin", FileMode.Create);
            BinaryFormatter binform = new BinaryFormatter();
            binform.Serialize(fs, o);
            fs.Flush();
            fs.Close();
        }

        private void btnDodajAuto_Click(object sender, EventArgs e)
        {
            List<Automobil> kola = new List<Automobil>();
            if (!File.Exists("Automobili.bin"))
            {
                Automobil auto = new Automobil(Automobil.NovID(kola), txtMarka.Text, txtModel.Text, txtPogon.Text, txtMenjac.Text, txtKaroserija.Text, txtGorivo.Text, int.Parse(txtKubikaza.Text), int.Parse(txtBrVrata.Text), int.Parse(txtGodiste.Text));
                kola.Add(auto);
                Serijalizuj(kola, "Automobili");
                MessageBox.Show("Cuvanje uspelo!");
            }
            else
            {
                try
                {

                    kola = DeserijalizujKola();
                    Automobil auto = new Automobil(Automobil.NovID(kola), txtMarka.Text, txtModel.Text, txtPogon.Text, txtMenjac.Text, txtKaroserija.Text, txtGorivo.Text, int.Parse(txtKubikaza.Text), int.Parse(txtBrVrata.Text), int.Parse(txtGodiste.Text));
                    kola.Add(auto);
                    Serijalizuj(kola, "Automobili");
                    MessageBox.Show("Cuvanje uspelo!");
                }
                catch
                {
                    MessageBox.Show("Cuvanje nije uspelo!");
                }
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            if (File.Exists("Automobili.bin"))
            {
                List<Automobil> kola = DeserijalizujKola();
                foreach (var auto in kola)
                {
                    cmbKola.Items.Add(auto.ID + " " + auto.Marka + " " + auto.Model);
                }
            }

            if (File.Exists("Nalozi.bin"))
            {
                FileStream fs = new FileStream("Nalozi.bin", FileMode.Open);
                BinaryFormatter br = new BinaryFormatter();
                List<Kupac> nalozi = (List<Kupac>)br.Deserialize(fs); fs.Close();

                foreach (var nalog in nalozi)
                    cmbNalozi.Items.Add(nalog.IdKupca + " " + nalog.Ime + " " + nalog.Prezime);
            }

            if (File.Exists("Nalozi.bin"))
            {
                FileStream fs = new FileStream("Nalozi.bin", FileMode.Open);
                BinaryFormatter br = new BinaryFormatter();
                List<Kupac> nalozi = (List<Kupac>)br.Deserialize(fs); fs.Close();

                foreach (var nalog in nalozi)
                    cmbNalozi2.Items.Add(nalog.IdKupca + " " + nalog.Ime + " " + nalog.Prezime);
            }


            if (File.Exists("Ponude.bin"))
            {
                List<Ponuda> ponude = DeserijalizujPonude();
                foreach (var p in ponude)
                    cmbPonude.Items.Add("id_" + p.IdAuta);
            }
        }

        private void cmbKola_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Automobil> kola = DeserijalizujKola();
            foreach (var auto in kola)
            {
                if (cmbKola.SelectedItem.Equals(auto.ID + " " + auto.Marka + " " + auto.Model))
                {
                    txtMarka.Text = auto.Marka;
                    txtModel.Text = auto.Model;
                    txtGorivo.Text = auto.Gorivo;
                    txtGodiste.Text = auto.Godiste.ToString();
                    txtMenjac.Text = auto.Menjac;
                    txtKaroserija.Text = auto.Karoserija;
                    txtKubikaza.Text = auto.Kubikaza.ToString();
                    txtPogon.Text = auto.Pogon;
                    txtBrVrata.Text = auto.BrVrata.ToString();
                    txtID.Text = auto.ID.ToString();
                }
            }
        }

        private void btnObrisiAuto_Click(object sender, EventArgs e)
        {
            List<Automobil> kola = DeserijalizujKola();
            try
            {
                for (int i = kola.Count - 1; i >= 0; i--)
                    if (cmbKola.SelectedItem.Equals(kola[i].ID + " " + kola[i].Marka + " " + kola[i].Model))
                        kola.Remove(kola[i]);

                foreach (TextBox txt in grpAuto.Controls.OfType<TextBox>())
                    txt.Clear();
                Serijalizuj(kola, "Automobili");
                cmbKola.Items.Remove(cmbKola.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Auto nije odabran!");
            }
        }

        private List<Rezervacija> DesRez()
        {
            FileStream fs = new FileStream("Rezervacije.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Rezervacija> list = (List<Rezervacija>)bf.Deserialize(fs);
            fs.Close();

            return list;
        }

        private void cmbNalozi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Nalozi.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Kupac> nalozi = (List<Kupac>)bf.Deserialize(fs);
            fs.Close();

            foreach (var nalog in nalozi)
                if (cmbNalozi.SelectedItem.Equals(nalog.IdKupca + " " + nalog.Ime + " " + nalog.Prezime))
                {
                    lbIme.Text = nalog.Ime;
                    lbPrezime.Text = nalog.Prezime;
                    lbBrTel.Text = nalog.BrTel;
                    lbJMBG.Text = nalog.Jmbg;
                    lbDatumRodj.Text = nalog.DatumRodjenja.ToShortDateString();
                    lbUsername.Text = nalog.KorisnickoIme;
                }

        }

        private void btnObrisiNalog_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Nalozi.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Kupac> nalozi = (List<Kupac>)bf.Deserialize(fs);
            fs.Close();
            try
            {
                for (int i = nalozi.Count - 1; i >= 0; i--)
                    if (cmbNalozi.SelectedItem.Equals(nalozi[i].IdKupca + " " + nalozi[i].Ime + " " + nalozi[i].Prezime))
                    {
                        nalozi.Remove(nalozi[i]);
                    }

                foreach (Label lb in grpNalozi.Controls.OfType<Label>())
                    lb.Text = "...";
                Serijalizuj(nalozi, "Nalozi");
                cmbNalozi.Items.Remove(cmbNalozi.SelectedItem);
            }
            catch { MessageBox.Show("Nalog nije odabran"); }

        }

        private void btnNovaPonuda_Click(object sender, EventArgs e)
        {
            DateTime datumOd = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime datumDo = Convert.ToDateTime(dateTimePicker2.Text);


            List<Ponuda> ponude = new List<Ponuda>();
            List<Automobil> kola = DeserijalizujKola();
            try
            {
                if (!File.Exists("Ponude.bin"))
                {
                    ponude.Add(new Ponuda(Ponuda.NovID(ponude), int.Parse(txtID.Text), int.Parse(txtCena.Text), datumOd, datumDo));
                    Serijalizuj(ponude, "Ponude");
                    MessageBox.Show("Ponuda dodata!");

                }
                else
                {
                    ponude = DeserijalizujPonude();
                    ponude.Add(new Ponuda(Ponuda.NovID(ponude), int.Parse(txtID.Text), int.Parse(txtCena.Text), datumOd, datumDo));
                    Serijalizuj(ponude, "Ponude");
                    MessageBox.Show("Ponuda dodata!");
                }
            }
            catch { MessageBox.Show("Neispravan format"); }
        }

        private void txtObrisiPonudu_Click(object sender, EventArgs e)
        {
            List<Ponuda> ponude = DeserijalizujPonude();
            try
            {
                for (int i = ponude.Count - 1; i >= 0; i--)
                    if (cmbPonude.SelectedItem.Equals("id_" + ponude[i].IdAuta))
                        ponude.Remove(ponude[i]);

                Serijalizuj(ponude, "Ponude");
                cmbPonude.Items.Remove(cmbPonude.SelectedItem);
                txtDo.Clear();
                txtOd.Clear();
                lbCenaPoDanu.Text = "0.00";
            }
            catch { MessageBox.Show("Pounda nije odabrana"); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogIn();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void cmbNalozi2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kupac temp = new Kupac();
            Rezervacija tempRez = new Rezervacija();

            FileStream fs = new FileStream("Nalozi.bin", FileMode.Open);
            BinaryFormatter br = new BinaryFormatter();
            List<Kupac> nalozi = (List<Kupac>)br.Deserialize(fs); fs.Close();

            foreach (var nalog in nalozi)
                if (cmbNalozi2.SelectedItem.Equals(nalog.IdKupca + " " + nalog.Ime + " " + nalog.Prezime))
                    temp = nalog;

            List<Rezervacija> listRez = DesRez();
            foreach (var rez in listRez)
                if (rez.IdKupca.Equals(temp.IdKupca))
                    cmbRez.Items.Add(rez.IdAuta + " - " + rez.DatumOd.Date.ToShortDateString()
                         + " - " + rez.DatumDo.Date.ToShortDateString());

            //List<Automobil> kola = DeserijalizujKola();
            //foreach (var auto in kola)
            //    if (tempRez.IdAuta.Equals(auto.ID) && tempRez.IdKupca.Equals(temp.IdKupca))
            //        cmbRez.Items.Add(temp.Ime + " " + temp.Prezime + " - " + auto.Marka + " " + auto.Model);
        }

        private void cmbPonude_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Ponuda> ponude = DeserijalizujPonude();
            foreach (var p in ponude)
                if (cmbPonude.SelectedItem.Equals("id_" + p.IdAuta))
                {
                    txtOd.Text = p.DatumOd.Date.ToShortDateString();
                    txtDo.Text = p.DatumDo.Date.ToShortDateString();
                    lbCenaPoDanu.Text = p.Cena.ToString();
                }
        }

        private void cmbRez_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempIdAuta = 0;
            List<Rezervacija> listRez = DesRez();
            List<Automobil> kola = DeserijalizujKola();
            foreach (var rez in listRez)
                if(cmbRez.SelectedItem.Equals(rez.IdAuta + " - " + rez.DatumOd.Date.ToShortDateString()
                         + " - " + rez.DatumDo.Date.ToShortDateString()))
                {
                    tempIdAuta = rez.IdAuta;
                    lbOd.Text = rez.DatumOd.Date.ToShortDateString();
                    lbDo.Text = rez.DatumDo.Date.ToShortDateString();
                    lbCena.Text = rez.Cena.ToString();
                }

            foreach(var auto in kola)
            {
                if (auto.ID.Equals(tempIdAuta))
                {
                    lbRezIme.Text = auto.Marka;
                    lbModel.Text = auto.Model;
                    lbPogon.Text = auto.Pogon;
                    lbMenjac.Text = auto.Menjac;
                    lbGod.Text = auto.Godiste.ToString();
                    lbKaro.Text = auto.Karoserija;
                    lbKubi.Text = auto.Kubikaza.ToString();
                    lbBrVrata.Text = auto.BrVrata.ToString();
                    lbGorivo.Text = auto.Gorivo;
                }
            }
        }
    }
}