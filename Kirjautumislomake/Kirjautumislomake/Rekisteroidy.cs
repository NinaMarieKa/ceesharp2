using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjautumislomake
{
    public partial class Rekisteroidy : Form
    {
        public Rekisteroidy()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SuljeSivuLB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuljeSivuLB_MouseEnter(object sender, EventArgs e)
        {
            SuljeSivuLB.ForeColor = Color.Red;
        }

        private void SuljeSivuLB_MouseLeave(object sender, EventArgs e)
        {
            SuljeSivuLB.ForeColor = Color.Black;
        }

        private void RekisteroidyBT_Click(object sender, EventArgs e)
        {
            // Luodaan muuttujia
            String etunimi = EtunimiTB.Text;
            String sukunimi = SukunimiTB.Text;
            String email = EmailTB.Text;
            String ktunnus = KtunnusTB.Text;
            String salis = SalisTB.Text;
            String vahsalis = VahvistaSalisTB.Text;

            // Tarkistetaan, että textbox tiedot ovat oikein
            if (etunimi == "Nina" && sukunimi == "Kaunisvaara" && email == "nina.kaunisvaara@gmail.com" && ktunnus == "nmkaunisvaara" && salis == "123vantaa" && vahsalis == "123vantaa")
            {
                this.Hide();
                Form1 log = new Form1();
                log.Show();
            }
            // Virheilmoitus, mikäli ne eivät ole
            else
            {
                MessageBox.Show("Tarkista pakolliset kentät", "VIRHE!");

            }
        }
    

        private void RekisteroidyBT_MouseEnter(object sender, EventArgs e)
        {
            RekisteroidyBT.BackColor = Color.Red;
        }

        private void RekisteroidyBT_MouseLeave(object sender, EventArgs e)
        {
            RekisteroidyBT.BackColor = Color.DimGray;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        } 
        
    }
}
