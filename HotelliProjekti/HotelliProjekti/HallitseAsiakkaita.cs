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
    public partial class HallitseAsiakkaita : Form
    {
        ASIAKAS asiakas = new ASIAKAS();
        public HallitseAsiakkaita()
        {
            InitializeComponent();
        }

      
        // Tyhjennetään kentät, kun Tyhjennä kentät- painiketta klikataan
        private void AsiakasTyhjennaBTN_Click(object sender, EventArgs e)
        {
            AsiakasIdTB.Text = "";
            AsiakasEtunimiTB.Text = "";
            AsiakasSukunimiTB.Text = "";
            AsiakasOsoiteTB.Text = "";
            AsiakasPostinumeroTB.Text = "";
            AsiakasToimipaikkaTB.Text = "";
            AsiakasKayttajaTB.Text = "";
            AsiakasSalasanaTB.Text = "";

        }

        // Määritetään mitä tapahtuu, kun klikataan Lisää uusi asiakas- painiketta
        private void UusiAsiakasBTN_Click(object sender, EventArgs e)
        {
            String enimi = AsiakasEtunimiTB.Text;
            String snimi = AsiakasSukunimiTB.Text;
            String osoite = AsiakasOsoiteTB.Text;
            String pnumero = AsiakasPostinumeroTB.Text;
            String ptpaikka = AsiakasToimipaikkaTB.Text;
            String ktunnus = AsiakasKayttajaTB.Text;
            String ssana = AsiakasSalasanaTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnumero.Trim().Equals("") || ptpaikka.Trim().Equals("") || ktunnus.Trim().Equals("") || ssana.Trim().Equals(""))
            {
                MessageBox.Show("Pakollisia kenttiä täyttämättä", "TYHJIÄ KENTTIÄ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, osoite, pnumero, ptpaikka, ktunnus, ssana);

                if (lisaaAsiakas)
                {
                    AsiakasData.DataSource = asiakas.haeAsiakkaat();
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakas lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Asiakkaan lisäys epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Haetaan asiakaslista 
        private void HallitseAsiakkaita_Load(object sender, EventArgs e)
        {
            AsiakasData.DataSource = asiakas.haeAsiakkaat();
        }

        // Määritetään mitä tapahtuu, kun klikataan Muokkaa- painiketta
        private void AsiakasMuokkaaBTN_Click(object sender, EventArgs e)
        {
            int asiId;
            String kayttaja = AsiakasKayttajaTB.Text;
            String enimi = AsiakasEtunimiTB.Text;
            String snimi = AsiakasSukunimiTB.Text;
            String osoite = AsiakasOsoiteTB.Text;
            String pnumero = AsiakasPostinumeroTB.Text;
            String ptpaikka = AsiakasToimipaikkaTB.Text;
            String salis = AsiakasSalasanaTB.Text;

            try
            {
                asiId = Convert.ToInt32(AsiakasIdTB.Text);

                if (kayttaja.Trim().Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnumero.Equals("") || ptpaikka.Trim().Equals("") ||  salis.Trim().Equals(""))

                {
                    MessageBox.Show("Pakollisia kenttiä täyttämättä", "TYHJIÄ KENTTIÄ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean lisaaAsiakas = asiakas.muokkaaAsiakasta(asiId, kayttaja, enimi, snimi, osoite, pnumero, ptpaikka, salis);

                    if (lisaaAsiakas)
                    {
                        AsiakasData.DataSource = asiakas.haeAsiakkaat();
                        MessageBox.Show("Asiakasta muokattu onnistuneesti", "Asiakasta muokattu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Asiakkaan muokkaus epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        // Asiakkaan poistaminen
        private void AsiakasPoistaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int asiId = Convert.ToInt32(AsiakasIdTB.Text);
                if (asiakas.poistaAsiakas(asiId))
                {
                    AsiakasData.DataSource = asiakas.haeAsiakkaat();
                    MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakas poistettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AsiakasTyhjennaBTN.PerformClick();
                }

                else
                {
                    MessageBox.Show("Asiakkaan poisto ei onnistunut", "Asiakasta ei poistettu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Näyttää valitun rivin tekstibokseissa
        private void AsiakasData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AsiakasIdTB.Text = AsiakasData.CurrentRow.Cells[0].Value.ToString();
            AsiakasEtunimiTB.Text = AsiakasData.CurrentRow.Cells[1].Value.ToString();
            AsiakasSukunimiTB.Text = AsiakasData.CurrentRow.Cells[2].Value.ToString();
            AsiakasOsoiteTB.Text = AsiakasData.CurrentRow.Cells[3].Value.ToString();
            AsiakasPostinumeroTB.Text = AsiakasData.CurrentRow.Cells[4].Value.ToString();
            AsiakasToimipaikkaTB.Text = AsiakasData.CurrentRow.Cells[5].Value.ToString();
            AsiakasKayttajaTB.Text = AsiakasData.CurrentRow.Cells[6].Value.ToString();
            AsiakasSalasanaTB.Text = AsiakasData.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
