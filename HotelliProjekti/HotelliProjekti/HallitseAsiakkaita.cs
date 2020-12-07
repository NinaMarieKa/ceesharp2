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
                AsiakasData.DataSource = asiakas.HaeAsiakkaat();
                MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakas lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakkaan lisäys epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HallitseAsiakkaita_Load(object sender, EventArgs e)
        {
            AsiakasData.DataSource = asiakas.HaeAsiakkaat();
        }
    }
}
