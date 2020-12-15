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

            //Näyttää kaikki varaukset
            dataVaraukset.DataSource = varaukset.haeVaraukset();


        }
        // Tyhjennetään kentät
        private void VarausTyhjennaBTN_Click(object sender, EventArgs e)
        {
            VarausNumeroTB.Text = "";
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
                int numero = Convert.ToInt32(VarausHuoneenNumeroCB.SelectedValue);
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
                
                    if (varaukset.lisaaVaraus(numero, anumero, sisaanKirj, ulosKirj))
                    {
                        // Määritetään huoneen vapaus = EI
                        // huoneet.huoneEiVapaa(numero, KyllaEi);
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
                int vnumero = Convert.ToInt32(VarausNumeroTB.Text);
                int anumero = Convert.ToInt32(VarausAsNumeroTB.Text);
                int numero = Convert.ToInt32(VarausHuoneenNumeroCB.SelectedValue);
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
               
                    if (varaukset.muokkaaVarausta(vnumero,numero, anumero, sisaanKirj, ulosKirj))
                    {
                        // Määritetään huoneen vapaus = EI
                       // huoneet.huoneEiVapaa(numero, KyllaEi);
                        MessageBox.Show("Varausta muokattu onnistuneesti", "Varausta muokattu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Varauksen muokkaaminen epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataVaraukset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VarausNumeroTB.Text = dataVaraukset.CurrentRow.Cells[0].Value.ToString();

            //Hae huoneen numero
            int hnumero = Convert.ToInt32(dataVaraukset.CurrentRow.Cells[1].Value.ToString());

            // Valitse huoneen tyyppi
            HuoneenTyyppiCB.SelectedValue = huoneet.haeHuoneTyyppi(hnumero);

            // Valitse huoneen numero
            VarausHuoneenNumeroCB.SelectedValue = hnumero;

            VarausAsNumeroTB.Text = dataVaraukset.CurrentRow.Cells[2].Value.ToString();
            
            
        }

        private void VarausPoistaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int vnumero = Convert.ToInt32(VarausNumeroTB.Text);
                if(varaukset.poistaVaraus(vnumero))
                {
                    dataVaraukset.DataSource = varaukset.haeVaraukset();
                    // Varauksen poiston jälkeen täytyy muuttaa vapaa -> Kyllä
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Varaus poistettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


        

// Ongelmia asiakasta lisättäessä, muokattaessa ja poistaessa,
//
// "You have an error in your SQL syntax; check the manual that corresponds to
// your MariaDB server version for the righ syntax to use near "WHERE Ktunnus= " at line 1"
//
// Ongelmia myös huoneiden kanssa, varauksissa oli myös ongelmia..
// Salasanojen suolaus ohjelma ladattu, ei vielä käytetty

//ALTER TABLE huoneet add CONSTRAINT fk_tyyppi_id FOREIGN KEY (tyyppi) REFERENCES huone_tyypit (idHuonetyyppi) on UPDATE CASCADE on DELETE CASCADE;
//ALTER TABLE varaukset add CONSTRAINT fk_huoneen_numero FOREIGN KEY (huoneenNumero) REFERENCES huoneet (numero) on UPDATE CASCADE on DELETE CASCADE;
// En onnistunut kolmannessa linkityksessä, tein täysin videon ohjeen mukaan, mutta siltikin jokin virhe