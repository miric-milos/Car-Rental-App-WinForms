using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tvpProjekatPrvi
{
    public partial class frmLogIn : Form
    {

        public frmLogIn()
        {
            InitializeComponent();
        }

        void UlogujKupca(Kupac k)
        {
            Form frmKupac = new frmKupac();
            frmKupac.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form frmAdmin = new frmAdmin();
            Form frmKupac = new frmKupac();
            string[] adminKredencijali = File.ReadAllLines("login_admin.txt");

            if (rdbtnAdmin.Checked)
            {
                if (txtKorisnickoIme.Text.Equals(adminKredencijali[0]) && txtSifra.Text.Equals(adminKredencijali[1]))
                {
                    this.Hide();
                    frmAdmin.ShowDialog();
                    this.Close();
                }
                else
                {
                    txtKorisnickoIme.BackColor = Color.Red;
                    txtSifra.BackColor = Color.Red;
                }
            }
            else
            {
                txtKorisnickoIme.ForeColor = Color.Red;
                txtSifra.BackColor = Color.Red;
                //DESERIJALIZACIJA FAJLA IMENOVANOG PO USERNAME-U KORISNIKA I KORISCENJE ISTOG ZA PRIJAVU
                FileStream fb = new FileStream("Nalozi.bin", FileMode.Open);
                BinaryFormatter br = new BinaryFormatter();

                List<Kupac> kupci = (List<Kupac>)br.Deserialize(fb);
                fb.Close();
                foreach (var k in kupci)
                {
                    if (k.Sifra.Equals(txtSifra.Text.Trim()) && k.KorisnickoIme.Equals(txtKorisnickoIme.Text.Trim()))
                    {
                        FileStream loginStream = new FileStream("UlogovanNalog.bin", FileMode.Create);
                        BinaryFormatter binform = new BinaryFormatter();

                        binform.Serialize(loginStream, k);
                        loginStream.Flush();
                        loginStream.Close();
                        this.Hide();
                        frmKupac.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
        private void btnRegistruj_Click(object sender, EventArgs e)
        {
            Form frmReg = new frmRegistracija();
            this.Hide();
            frmReg.ShowDialog();
            this.Close();
        }
    }
}


