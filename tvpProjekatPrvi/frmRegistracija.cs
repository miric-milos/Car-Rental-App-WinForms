using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tvpProjekatPrvi
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private List<Kupac> Deserijalizuj()
        {
            FileStream fs = new FileStream("Nalozi.bin", FileMode.Open);
            BinaryFormatter binform = new BinaryFormatter();
            List<Kupac> kupci = (List<Kupac>)binform.Deserialize(fs);
            fs.Close();
            return kupci;
        }

        public void Serijalizuj(object o)
        {
            FileStream fs = new FileStream("Nalozi.bin", FileMode.Create);
            BinaryFormatter binform = new BinaryFormatter();
            binform.Serialize(fs, o);
            fs.Flush();
            fs.Close();
        }

        //REGISTRACIJA KORISNIKA(MUSTERIJE)
        private void btnNapraviNalog_Click(object sender, EventArgs e)
        {
            List<Kupac> kupci = new List<Kupac>();
            if (txtKorisnickoIme.Text.Trim().Equals("")
                || txtSifra.Text.Trim().Equals("")
                || !txtJMBG.Text.Length.Equals(13)
                || txtbrTel.Text.Length < 9
                || txtIme.Text.Any(char.IsDigit) || txtIme.Text.Length < 2
                || txtPrezime.Text.Any(char.IsDigit) || txtPrezime.Text.Length < 2
                || txtbrTel.Text.Length < 9)
            {
                MessageBox.Show("Niste ispravno uneli podatke ili niste popunili sva polja!");
            }

            else
            {
                if (!File.Exists("Nalozi.bin"))
                {
                    kupci.Add(new Kupac(Kupac.NovID(kupci), txtSifra.Text, txtKorisnickoIme.Text, txtJMBG.Text, txtbrTel.Text, dateDatumRodj.Value.Date, txtIme.Text, txtPrezime.Text));
                    Serijalizuj(kupci);
                    MessageBox.Show("Nalog uspesno kreiran!");

                }
                else
                {
                    try
                    {
                        kupci = Deserijalizuj();
                        kupci.Add(new Kupac(Kupac.NovID(kupci), txtSifra.Text, txtKorisnickoIme.Text, txtJMBG.Text, txtbrTel.Text, dateDatumRodj.Value.Date, txtIme.Text, txtPrezime.Text));
                        Serijalizuj(kupci);
                        MessageBox.Show("Nalog uspesno kreiran!");
                    }
                    catch
                    {
                        MessageBox.Show("Cuvanje nije uspelo!");
                    }
                }
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogIn();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}