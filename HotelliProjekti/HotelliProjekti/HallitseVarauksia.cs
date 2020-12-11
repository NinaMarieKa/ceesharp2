using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelliProjekti
{
    public partial class HallitseVarauksia : Form
    {
        public HallitseVarauksia()
        {
            InitializeComponent();
        }
        // Yhdistetään luokkiin
        HUONEET huoneet = new HUONEET();

        VARAUKSET varaukset = new VARAUKSET();

        private void HallitseVarauksia_Load(object sender, EventArgs e)
        {
            // Näyttää huonetyypit
            HuoneenTyyppiCB.DataSource = huoneet.huoneTyyppiLista();
            HuoneenTyyppiCB.DisplayMember = "tyyppi";
            HuoneenTyyppiCB.ValueMember = "idHuonetyyppi";

            // Näyttää huoneen numeron valitun huonetyypin mukaan
            int tyyppi = Convert.ToInt32(HuoneenTyyppiCB.SelectedValue.ToString());
            VarausHuoneenNumeroCB.DataSource = huoneet.huoneTyypinMukaan(tyyppi);
            VarausHuoneenNumeroCB.DisplayMember = "numero";
            VarausHuoneenNumeroCB.ValueMember = "numero";


        }
        // Tyhjennetään kentät
        private void VarausTyhjennaBTN_Click(object sender, EventArgs e)
        {
            VarausAsNumeroTB.Text = "";
            VarausHuoneenNumeroCB.SelectedIndex = 0;
            dateTimeSisaan.Value = DateTime.Now;
            dateTimeUlos.Value = DateTime.Now;

        }

        private void HuoneenTyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Näyttää huoneen numeron valitun huonetyypin mukaan
                int tyyppi = Convert.ToInt32(HuoneenTyyppiCB.SelectedValue.ToString());
                VarausHuoneenNumeroCB.DataSource = huoneet.huoneTyypinMukaan(tyyppi);
                VarausHuoneenNumeroCB.DisplayMember = "numero";
                VarausHuoneenNumeroCB.ValueMember = "numero";

            }
            catch (Exception)
            {
                // ei tee mitään
            }
        }

        // Uusi varaus- painikkeen toiminnot
        private void UusiVarausBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int anumero = Convert.ToInt32(VarausAsNumeroTB.Text);
                int hnumero = Convert.ToInt32(VarausHuoneenNumeroCB.SelectedValue);
                DateTime sisaanKirj = dateTimeSisaan.Value;
                DateTime ulosKirj = dateTimeUlos.Value;

                if (sisaanKirj < DateTime.Now)
                {
                    MessageBox.Show("Sisään kirjautumisajankohta voi olla aikaisintaan tänään", "Tarkista päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ulosKirj < sisaanKirj)
                {
                    MessageBox.Show("Ulos kirjautumisajankohta ei voi olla ennen sisäänkirjautumista", "Tarkista päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Määritetään huoneen vapaus = EI
                    huoneet.huoneEiVapaa(numero);
                    if (varaukset.lisaaVaraus(hnumero, anumero, sisaanKirj, ulosKirj))
                    {

                        MessageBox.Show("Varaus lisätty onnistuneesti", "Varaus lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Varauksen tekeminen epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Varausten muokkaaminen
        private void VarausMuokkaaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int anumero = Convert.ToInt32(VarausAsNumeroTB.Text);
                int hnumero = Convert.ToInt32(VarausHuoneenNumeroCB.SelectedValue);
                DateTime sisaanKirj = dateTimeSisaan.Value;
                DateTime ulosKirj = dateTimeUlos.Value;

                if (sisaanKirj < DateTime.Now)
                {
                    MessageBox.Show("Sisään kirjautumisajankohta voi olla aikaisintaan tänään", "Tarkista päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ulosKirj < sisaanKirj)
                {
                    MessageBox.Show("Ulos kirjautumisajankohta ei voi olla ennen sisäänkirjautumista", "Tarkista päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Määritetään huoneen vapaus = EI
                    huoneet.huoneEiVapaa(numero);
                    if (varaukset.lisaaVaraus(hnumero, anumero, sisaanKirj, ulosKirj))
                    {

                        MessageBox.Show("Varaus lisätty onnistuneesti", "Varaus lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Varauksen tekeminen epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


        

// Ohjelma kaatuu asiakasta lisättäessä, muokattaessa ja poistaessa,
// samaa huoneiden kanssa, varauksissa oli myös ongelmia..
// Salasanojen suolaus ohjelma ladattu, ei vielä käytetty
// Kuinka tehtiin se, että ohjelma luo käyttäjätunnukset ja salasanat automaattisesti?

//ALTER TABLE huoneet add CONSTRAINT fk_tyyppi_id FOREIGN KEY (tyyppi) REFERENCES huone_tyypit (idHuonetyyppi) on UPDATE CASCADE on DELETE CASCADE;
//ALTER TABLE varaukset add CONSTRAINT fk_huoneen_numero FOREIGN KEY (huoneenNumero) REFERENCES huoneet (numero) on UPDATE CASCADE on DELETE CASCADE;
// En onnistunut kolmannessa linkityksessä, tein täysin videon ohjeen mukaan, mutta siltikin jokin virhe