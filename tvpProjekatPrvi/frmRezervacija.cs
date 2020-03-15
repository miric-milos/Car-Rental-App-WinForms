using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace tvpProjekatPrvi
{
    public partial class frmRezervacija : Form
    {
        public frmRezervacija()
        {
            InitializeComponent();
        }

        private List<Automobil> DeserijalizujListu()
        {
            try
            {
                FileStream fs = new FileStream("Automobili.bin", FileMode.Open);
                BinaryFormatter br = new BinaryFormatter();
                List<Automobil> kola = (List<Automobil>)br.Deserialize(fs);
                fs.Close();

                return kola;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private List<Ponuda> DesPonude()
        {
            FileStream fs = new FileStream("Ponude.bin", FileMode.Open);
            BinaryFormatter br = new BinaryFormatter();
            List<Ponuda> list = (List<Ponuda>)br.Deserialize(fs);
            fs.Close();

            return list;
        }

        //nisam mogao da napravim funkciju

        private void DodajUComboBox(ComboBox cmb, object o)
        {
            if (!cmb.Items.Contains(o))
                cmb.Items.Add(o);
        }

        private void frmRezervacija_Load(object sender, EventArgs e)
        {
            List<Automobil> kola = DeserijalizujListu();
            foreach (var auto in kola)
                DodajUComboBox(cmbMarka, auto.Marka);

            foreach (ComboBox cmb in groupBox1.Controls.OfType<ComboBox>())
                if (cmb.Items.Count.Equals(1))
                    cmb.Text = (cmb.Items[0].ToString());
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            cmbGorivo.Items.Clear();
            cmbKubikaza.Items.Clear();
            cmbKaroserija.Items.Clear();
            cmbPogon.Items.Clear();
            cmbMenjac.Items.Clear();
            cmbBrVrata.Items.Clear();
            cmbGodiste.Items.Clear();


            List<Automobil> kola = DeserijalizujListu();
            foreach (var auto in kola)
                if (cmbMarka.SelectedItem.Equals(auto.Marka))
                    DodajUComboBox(cmbModel, auto.Model);

            foreach (ComboBox cmb in groupBox1.Controls.OfType<ComboBox>())
                if (cmb.Items.Count.Equals(1))
                    cmb.Text = (cmb.Items[0].ToString());

        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGorivo.Items.Clear();
            cmbKubikaza.Items.Clear();
            cmbKaroserija.Items.Clear();
            cmbPogon.Items.Clear();
            cmbMenjac.Items.Clear();
            cmbBrVrata.Items.Clear();
            cmbGodiste.Items.Clear();

            List<Automobil> kola = DeserijalizujListu();
            foreach (var auto in kola)
                if (cmbModel.SelectedItem.Equals(auto.Model))
                    DodajUComboBox(cmbGorivo, auto.Gorivo);

            foreach (ComboBox cmb in groupBox1.Controls.OfType<ComboBox>())
                if (cmb.Items.Count.Equals(1))
                    cmb.Text = (cmb.Items[0].ToString());
        }

        private void cmbGorivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKubikaza.Items.Clear();
            cmbKaroserija.Items.Clear();
            cmbPogon.Items.Clear();
            cmbMenjac.Items.Clear();
            cmbBrVrata.Items.Clear();
            cmbGodiste.Items.Clear();

            List<Automobil> kola = DeserijalizujListu();
            foreach (var auto in kola)
                if (cmbModel.SelectedItem.Equals(auto.Model) && cmbGorivo.SelectedItem.Equals(auto.Gorivo))
                    DodajUComboBox(cmbKubikaza, auto.Kubikaza);

            foreach (ComboBox cmb in groupBox1.Controls.OfType<ComboBox>())
                if (cmb.Items.Count.Equals(1))
                    cmb.Text = (cmb.Items[0].ToString());

        }

        private void cmbKubikaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKaroserija.Items.Clear();
            cmbPogon.Items.Clear();
            cmbMenjac.Items.Clear();
            cmbBrVrata.Items.Clear();
            cmbGodiste.Items.Clear();

            List<Automobil> kola = DeserijalizujListu();
            foreach (var auto in kola)
                if (cmbModel.SelectedItem.Equals(auto.Model) && cmbGorivo.SelectedItem.Equals(auto.Gorivo)
                    && cmbKubikaza.SelectedItem.Equals(auto.Kubikaza))
                    DodajUComboBox(cmbKaroserija, auto.Karoserija);

            foreach (ComboBox cmb in groupBox1.Controls.OfType<ComboBox>())
                if (cmb.Items.Count.Equals(1))
                    cmb.Text = (cmb.Items[0].ToString());

        }

        private void cmbKaroserija_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPogon.Items.Clear();
            cmbMenjac.Items.Clear();
            cmbBrVrata.Items.Clear();
            cmbGodiste.Items.Clear();

            List<Automobil> kola = DeserijalizujListu();
            foreach (var auto in kola)
                if (cmbModel.SelectedItem.Equals(auto.Model)
                    && cmbGorivo.SelectedItem.Equals(auto.Gorivo)
                    && cmbKubikaza.SelectedItem.Equals(auto.Kubikaza)
                    && cmbKaroserija.SelectedItem.Equals(auto.Karoserija))
                    DodajUComboBox(cmbPogon, auto.Pogon);

            foreach (ComboBox cmb in groupBox1.Controls.OfType<ComboBox>())
                if (cmb.Items.Count.Equals(1))
                    cmb.Text = (cmb.Items[0].ToString());

        }

        private void cmbPogon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMenjac.Items.Clear();
            cmbBrVrata.Items.Clear();
            cmbGodiste.Items.Clear();

            List<Automobil> kola = DeserijalizujListu();
            foreach (var auto in kola)
                if (cmbModel.SelectedItem.Equals(auto.Model)
                    && cmbGorivo.SelectedItem.Equals(auto.Gorivo)
                    && cmbKubikaza.SelectedItem.Equals(auto.Kubikaza)
                    && cmbKaroserija.SelectedItem.Equals(auto.Karoserija)
                    && cmbPogon.SelectedItem.Equals(auto.Pogon))
                    DodajUComboBox(cmbMenjac, auto.Menjac);

            foreach (ComboBox cmb in groupBox1.Controls.OfType<ComboBox>())
                if (cmb.Items.Count.Equals(1))
                    cmb.Text = (cmb.Items[0].ToString());

        }

        private void cmbMenjac_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBrVrata.Items.Clear();
            cmbGodiste.Items.Clear();

            List<Automobil> kola = DeserijalizujListu();
            foreach (var auto in kola)
                if (cmbModel.SelectedItem.Equals(auto.Model)
                    && cmbGorivo.SelectedItem.Equals(auto.Gorivo)
                    && cmbKubikaza.SelectedItem.Equals(auto.Kubikaza)
                    && cmbKaroserija.SelectedItem.Equals(auto.Karoserija)
                    && cmbPogon.SelectedItem.Equals(auto.Pogon)
                    && cmbMenjac.SelectedItem.Equals(auto.Menjac))
                    DodajUComboBox(cmbBrVrata, auto.BrVrata);

            foreach (ComboBox cmb in groupBox1.Controls.OfType<ComboBox>())
                if (cmb.Items.Count.Equals(1))
                    cmb.Text = (cmb.Items[0].ToString());

        }

        private void cmbBrVrata_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGodiste.Items.Clear();

            List<Automobil> kola = DeserijalizujListu();
            foreach (var auto in kola)
                if (cmbModel.SelectedItem.Equals(auto.Model)
                    && cmbGorivo.SelectedItem.Equals(auto.Gorivo)
                    && cmbKubikaza.SelectedItem.Equals(auto.Kubikaza)
                    && cmbKaroserija.SelectedItem.Equals(auto.Karoserija)
                    && cmbPogon.SelectedItem.Equals(auto.Pogon)
                    && cmbMenjac.SelectedItem.Equals(auto.Menjac)
                    && cmbBrVrata.SelectedItem.Equals(auto.BrVrata))
                    DodajUComboBox(cmbGodiste, auto.Godiste);

            foreach (ComboBox cmb in groupBox1.Controls.OfType<ComboBox>())
                if (cmb.Items.Count.Equals(1))
                    cmb.Text = (cmb.Items[0].ToString());

        }

        private void UcitajPonudu(Automobil auto)
        {
            List<Ponuda> p = new List<Ponuda>();
            p = DesPonude(); Ponuda temp = new Ponuda();
            foreach (var ponuda in p)
                if (ponuda.IdAuta.Equals(auto.ID))
                    listBox1.Items.Add(ponuda.DatumOd.ToShortDateString() + "  -  "
                         + ponuda.DatumDo.ToShortDateString()
                         + "  Cena po danu: " + ponuda.Cena);
        }

        private Automobil OdabranAuto()
        {
            Automobil tempAuto = new Automobil();
            List<Automobil> kola = DeserijalizujListu();

            foreach (var auto in kola)
            {
                if (cmbMarka.SelectedItem.Equals(auto.Marka)
                        && cmbModel.SelectedItem.Equals(auto.Model)
                        && cmbGorivo.SelectedItem.Equals(auto.Gorivo)
                        && cmbKubikaza.SelectedItem.Equals(auto.Kubikaza)
                        && cmbKaroserija.SelectedItem.Equals(auto.Karoserija)
                        && cmbMenjac.SelectedItem.Equals(auto.Menjac)
                        && cmbBrVrata.SelectedItem.Equals(auto.BrVrata)
                        && cmbGodiste.SelectedItem.Equals(auto.Godiste)
                        && cmbPogon.SelectedItem.Equals(auto.Pogon))
                    tempAuto = auto;
            }
            return tempAuto;
        }

        private Kupac ulogovanNalog()
        {
            FileStream fs = new FileStream("UlogovanNalog.bin", FileMode.Open);
            BinaryFormatter br = new BinaryFormatter();
            Kupac k = (Kupac)br.Deserialize(fs);
            fs.Close();

            return k;
        }

        private void Serijalizuj(object o, string s)
        {
            FileStream fs = new FileStream(s + ".bin", FileMode.Create);
            BinaryFormatter br = new BinaryFormatter();
            br.Serialize(fs, o);
            fs.Flush(); fs.Close();
        }

        private List<Rezervacija> DesRez()
        {
            FileStream fs = new FileStream("Rezervacije.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Rezervacija> list = (List<Rezervacija>)bf.Deserialize(fs);
            fs.Close();

            return list;
        }

        private void btnPrikaziTermine_Click(object sender, EventArgs e)
        {
            DateTime datumOd = Convert.ToDateTime(datePreuzimanje.Text);
            DateTime datumDo = Convert.ToDateTime(dateVracanje.Text);

            //if (pOd < fOd && pDo < fDo)
            //    MessageBox.Show("Termin dostupan!");
            //else MessageBox.Show("Termin nije dostupan!");

            //PRAVI NOVU LISTU ZA PONUDE SA ISTIM VOZILIMA
            List<Ponuda> p = DesPonude();
            List<Ponuda> tempLista = new List<Ponuda>();
            try
            {
                foreach (var ponuda in p)
                    if (ponuda.IdAuta.Equals(OdabranAuto().ID))
                        tempLista.Add(ponuda);

                foreach (var ponuda in tempLista)
                    listBox1.Items.Add(ponuda.DatumOd.Date.ToShortDateString() + " - "
                        + ponuda.DatumDo.Date.ToShortDateString() + " Cena po danu: " + ponuda.Cena);
            }
            catch { MessageBox.Show("Nije odabran auto"); }
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {try
            {
            DateTime datumOd = Convert.ToDateTime(datePreuzimanje.Text);
            DateTime datumDo = Convert.ToDateTime(dateVracanje.Text);
            Ponuda pon = ProveriTermin();
            List<Ponuda> p = DesPonude();
            //if (pOd < fOd && pDo < fDo)
            //    MessageBox.Show("Termin dostupan!");
            //else MessageBox.Show("Termin nije dostupan!");
            
                if (pon.DatumOd > datumOd || pon.DatumDo < datumDo)
                    MessageBox.Show("Termin nije dostupan!");
                else
                {
                    for (int i = p.Count - 1; i >= 0; i--)
                        if (listBox1.SelectedItem.Equals(p[i].DatumOd.Date.ToShortDateString() + " - "
                        + p[i].DatumDo.Date.ToShortDateString() + " Cena po danu: " + p[i].Cena))
                            p.Remove(p[i]);

                    Serijalizuj(p, "Ponude");

                    listBox1.Items.Clear();
                    Serijalizuj(p, "Ponude");
                    List<Rezervacija> listRez = new List<Rezervacija>();
                    if (!File.Exists("Rezervacije.bin"))
                    {
                        listRez.Add(new Rezervacija(ulogovanNalog().IdKupca, OdabranAuto().ID, int.Parse(txtUkupnaCena.Text), datumOd, datumDo));
                        Serijalizuj(listRez, "Rezervacije");
                        MessageBox.Show("Rezervacija prosledjena!\nMozete je ukinuti na prethodnom prozoru.");
                    }
                    else
                    {
                        listRez = DesRez();
                        listRez.Add(new Rezervacija(ulogovanNalog().IdKupca, OdabranAuto().ID, int.Parse(txtUkupnaCena.Text), datumOd, datumDo));
                        Serijalizuj(listRez, "Rezervacije");
                        MessageBox.Show("Rezervacija prosledjena!\nMozete je ukinuti na prethodnom prozoru.");
                    }
                }
            }
            catch { MessageBox.Show("Niste odabrali datum"); }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Form frmNalog = new frmKupac();
            this.Hide();
            frmNalog.ShowDialog();
            this.Close();
        }

        private Ponuda OdgPonuda()
        {
            List<Ponuda> ponude = DesPonude();
            Ponuda temp = new Ponuda();
            foreach (var p in ponude)
                if (p.IdAuta.Equals(OdabranAuto().ID))
                    temp = p;
            return temp;
        }

        private void datePreuzimanje_ValueChanged_1(object sender, EventArgs e)
        {
            txtUkupnaCena.Clear();
            int ukupnaCena = OdgPonuda().Cena * (DateTime.Parse(dateVracanje.Text) - DateTime.Parse(datePreuzimanje.Text)).Days;
            txtUkupnaCena.Text = ukupnaCena.ToString();
        }

        private void dateVracanje_ValueChanged(object sender, EventArgs e)
        {
            txtUkupnaCena.Clear();
            int ukupnaCena = OdgPonuda().Cena * (DateTime.Parse(dateVracanje.Text) - DateTime.Parse(datePreuzimanje.Text)).Days;
            txtUkupnaCena.Text = ukupnaCena.ToString();
        }


        private Ponuda ProveriTermin()
        {
            List<Ponuda> ponude = DesPonude();
            Ponuda tempP = new Ponuda();
            foreach (var p in ponude)
            {
                if (listBox1.SelectedItem.Equals(p.DatumOd.Date.ToShortDateString() + " - "
                    + p.DatumDo.Date.ToShortDateString() + " Cena po danu: " + p.Cena)
                    && p.IdAuta.Equals(OdabranAuto().ID))
                    tempP = p;
            }
            return tempP;
        }
    }
}