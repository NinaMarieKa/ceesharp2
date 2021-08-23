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
        ASIAKAS asiakas = new ASIAKAS();


        private void HallitseVarauksia_Load(object sender, EventArgs e)
        {
            // Näyttää huonetyypit
            HuoneenTyyppiCB.DataSource = huoneet.huoneTyyppiLista();
            HuoneenTyyppiCB.DisplayMember = "tyyppi";
            HuoneenTyyppiCB.ValueMember = "idHuonetyyppi";

            // Näyttää vapaan huoneen numeron valitun huonetyypin mukaan
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
            varausNumeroTB.Text = "";
            AsiakasNumeroTB.Text = "";
            VarausHuoneenNumeroCB.SelectedIndex = -1;
            dateTimeSisaan.Value = DateTime.Now;
            dateTimeUlos.Value = DateTime.Now;

        }

        private void HuoneenTyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Näyttää huoneen numeron valitun huonetyypin mukaan
                int tyyppi = HuoneenTyyppiCB.SelectedIndex + 1;
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
            
                int anumero = Convert.ToInt32(AsiakasNumeroTB.Text);
                int hnumero = Convert.ToInt32(VarausHuoneenNumeroCB.SelectedValue.ToString());
                DateTime sisaanKirj = dateTimeSisaan.Value;
                DateTime ulosKirj = dateTimeUlos.Value;

                if (DateTime.Compare(sisaanKirj.Date,DateTime.Now.Date)<0)
                {
                    MessageBox.Show("Sisään kirjautumisajankohta voi olla aikaisintaan tänään", "Tarkista päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DateTime.Compare(ulosKirj.Date,sisaanKirj.Date)<0)
                {
                    MessageBox.Show("Ulos kirjautumisajankohta ei voi olla ennen sisäänkirjautumista", "Tarkista päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (varaukset.lisaaVaraus(hnumero, anumero, sisaanKirj, ulosKirj))
                    {
                        // Määritetään huoneen vapaus = EI
                        huoneet.huoneVapaa(hnumero, "Ei");
                        dataVaraukset.DataSource = varaukset.haeVaraukset();
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
                int vnumero = Convert.ToInt32(varausNumeroTB.Text);
                int anumero = Convert.ToInt32(AsiakasNumeroTB.Text);
                int hnumero = Convert.ToInt32(dataVaraukset.CurrentRow.Cells[1].Value.ToString());
                DateTime sisaanKirj = dateTimeSisaan.Value;
                DateTime ulosKirj = dateTimeUlos.Value;

                if (DateTime.Compare(sisaanKirj.Date, DateTime.Now.Date) < 0)
                {
                    MessageBox.Show("Sisään kirjautumisajankohta voi olla aikaisintaan tänään", "Tarkista päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DateTime.Compare(ulosKirj.Date, sisaanKirj.Date) < 0)
                {
                    MessageBox.Show("Ulos kirjautumisajankohta ei voi olla ennen sisäänkirjautumista", "Tarkista päivämäärä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                 else
                {
               
                    if (varaukset.muokkaaVarausta(vnumero, hnumero, anumero, sisaanKirj, ulosKirj))
                    {
                        // Määritetään huoneen vapaus = EI
                        huoneet.huoneVapaa(hnumero, "Ei");
                        dataVaraukset.DataSource = varaukset.haeVaraukset();
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
           varausNumeroTB.Text = dataVaraukset.CurrentRow.Cells[0].Value.ToString();

            //Hae huoneen numero
            int numero = Convert.ToInt32(dataVaraukset.CurrentRow.Cells[1].Value.ToString());

            // Valitse huoneen tyyppi
            HuoneenTyyppiCB.SelectedValue = huoneet.haeHuoneTyyppi(numero);

            // Valitse huoneen numero
            VarausHuoneenNumeroCB.SelectedValue = numero;

          AsiakasNumeroTB.Text = dataVaraukset.CurrentRow.Cells[2].Value.ToString();
            
            dateTimeSisaan.Value = Convert.ToDateTime(dataVaraukset.CurrentRow.Cells[3].Value);
            dateTimeUlos.Value = Convert.ToDateTime(dataVaraukset.CurrentRow.Cells[4].Value);
        }

        private void VarausPoistaBTN_Click(object sender, EventArgs e)
        {
            try
            {

                int vnumero = Convert.ToInt32(varausNumeroTB.Text);
                int hnumero = Convert.ToInt32(dataVaraukset.CurrentRow.Cells[1].Value.ToString());
                if(varaukset.poistaVaraus(vnumero))
                {
                    dataVaraukset.DataSource = varaukset.haeVaraukset();
                    // Varauksen poiston jälkeen täytyy muuttaa vapaa -> Kyllä
                    huoneet.huoneVapaa(hnumero, "Kyllä");
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


        
