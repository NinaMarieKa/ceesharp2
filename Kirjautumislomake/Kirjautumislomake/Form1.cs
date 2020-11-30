using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjautumislomake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KirjauduPainike_Click(object sender, EventArgs e)
        {
            String kayttaja = KayttajaTB.Text;
            String salasana = SalasanaTB.Text;
            if(kayttaja == "nmkaunisvaara" && salasana == "123vantaa")
            {
                this.Hide();
                Paaikkuna paa = new Paaikkuna();
                paa.Show();
                // Siirrytään pääikkunaan mikäli käyttäjätunnus ja salasana on oikein
            }
            else // Mitä tapahtuu kun käyttäjätunnus tai salasana on väärin
            {
                MessageBox.Show("Käyttäjätunnus tai salasana väärin", "VIRHE!");
            }
           
        }
        // Määrittää X:n värin kun hiiri osoitetaan sen päälle..
        private void SuljeIkkuna_MouseEnter(object sender, EventArgs e)
        {
            SuljeIkkuna.ForeColor = Color.Red;
        }
        //.. ja kun se siirretään pois.
        private void SuljeIkkuna_MouseLeave(object sender, EventArgs e)
        {
            SuljeIkkuna.ForeColor = Color.Black;
        }
        // Tämä sulkee ikkunan
        private void SuljeIkkuna_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Määrittää "Kirjaudu" napin värin kun hiiri siirretään sen päälle..
        private void KirjauduPainike_MouseEnter(object sender, EventArgs e)
        {
            KirjauduPainike.BackColor = Color.Red;
        }
        //... ja kun se siirretään pois.
        private void KirjauduPainike_MouseLeave(object sender, EventArgs e)
        {
            KirjauduPainike.BackColor = Color.DimGray;
        }
        // Määrittää rekisteröitymis "napin" värin kun hiiri osoitetaan sen päälle..
        private void SiirryRek_MouseEnter(object sender, EventArgs e)
        {
            SiirryRek.BackColor = Color.Red;
            SiirryRek.ForeColor = Color.White;
        }
        //.. ja kun se siirretään pois.
        private void SiirryRek_MouseLeave(object sender, EventArgs e)
        {
            SiirryRek.BackColor = Color.White;
            SiirryRek.ForeColor = Color.Black;
        }

        // Sulkee kirjautumisikkunan ja avaa rekisteröinti-ikkunan.
        private void SiirryRek_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rekisteroidy rek = new Rekisteroidy();
            rek.Show();
        }
    }
}
