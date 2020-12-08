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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AsiakasTyhjennaBTN_Click(object sender, EventArgs e)
        {
            AsiakasEtunimiTB.Text = "";
            AsiakasSukunimiTB.Text = "";
            AsiakasOsoiteTB.Text = "";
            AsiakasPostinumeroTB.Text = "";
            AsiakasToimipaikkaTB.Text = "";
            AsiakasKayttajaTB.Text = "";
            AsiakasSalasanaTB.Text = "";

        }

        private void UusiAsiakasBTN_Click(object sender, EventArgs e)
        {
            String enimi = AsiakasEtunimiTB.Text;
            String snimi = AsiakasSukunimiTB.Text;
            String osoite = AsiakasOsoiteTB.Text;
            String pnumero = AsiakasPostinumeroTB.Text;
            String ptpaikka = AsiakasToimipaikkaTB.Text;
            String kayttaja = AsiakasKayttajaTB.Text;
            String salis = AsiakasSalasanaTB.Text;

            if(enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnumero.Trim().Equals("") || ptpaikka.Trim().Equals("") || kayttaja.Trim().Equals("") || salis.Trim().Equals(""))
            {
                MessageBox.Show("Pakollisia kenttiä täyttämättä", "TYHJIÄ KENTTIÄ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, osoite, pnumero, ptpaikka, kayttaja, salis);

            if(lisaaAsiakas)
            {
                AsiakasData.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakas lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakkaan lisäys epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HallitseAsiakkaita_Load(object sender, EventArgs e)
        {
            AsiakasData.DataSource = asiakas.haeAsiakkaat();
        }

        private void AsiakasMuokkaaBTN_Click(object sender, EventArgs e)
        {
            String enimi = AsiakasEtunimiTB.Text;
            String snimi = AsiakasSukunimiTB.Text;
            String osoite = AsiakasOsoiteTB.Text;
            String pnumero = AsiakasPostinumeroTB.Text;
            String ptpaikka = AsiakasToimipaikkaTB.Text;
            String kayttaja = AsiakasKayttajaTB.Text;
            String salis = AsiakasSalasanaTB.Text;

            try
            {

                if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnumero.Equals("") || ptpaikka.Trim().Equals("") || kayttaja.Trim().Equals("") || salis.Trim().Equals(""))

                {
                    MessageBox.Show("Pakollisia kenttiä täyttämättä", "TYHJIÄ KENTTIÄ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Boolean lisaaAsiakas = asiakas.muokkaaAsiakasta(enimi, snimi, osoite, pnumero, ptpaikka, kayttaja, salis);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsiakasData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AsiakasEtunimiTB.Text = AsiakasData.CurrentRow.Cells[0].Value.ToString();
            AsiakasSukunimiTB.Text = AsiakasData.CurrentRow.Cells[1].Value.ToString();
            AsiakasOsoiteTB.Text = AsiakasData.CurrentRow.Cells[2].Value.ToString();
            AsiakasPostinumeroTB.Text = AsiakasData.CurrentRow.Cells[3].Value.ToString();
            AsiakasToimipaikkaTB.Text = AsiakasData.CurrentRow.Cells[4].Value.ToString();
            AsiakasKayttajaTB.Text = AsiakasData.CurrentRow.Cells[5].Value.ToString();
            AsiakasSalasanaTB.Text = AsiakasData.CurrentRow.Cells[6].Value.ToString();

        }

        private void AsiakasKayttajaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AsiakasPoistaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                String ktunnus = AsiakasKayttajaTB.Text;
                if (asiakas.poistaAsiakas(ktunnus))
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
    }
}
