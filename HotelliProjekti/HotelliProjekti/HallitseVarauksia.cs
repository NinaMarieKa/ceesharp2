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
            catch(Exception)
            {
                // ei tee mitään
            }
        }

        private void UusiVarausBTN_Click(object sender, EventArgs e)
        {
            int anumero = Convert.ToInt32(VarausAsNumeroTB.Text);
            int hnumero = Convert.ToInt32(VarausHuoneenNumeroCB.SelectedValue);
            DateTime sisaanKirj = dateTimeSisaan.Value;
            DateTime ulosKirj = dateTimeUlos.Value;

            if(varaukset.lisaaVaraus(hnumero,anumero,sisaanKirj,ulosKirj))
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varaus lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Varauksen tekeminen epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
// Varaus ei näy asiakas- taulussa asiakkaan kohdalla
// Huoneita myös mahdollista varata päällekkäin

//ALTER TABLE huoneet add CONSTRAINT fk_tyyppi_id FOREIGN KEY (tyyppi) REFERENCES huone_tyypit (idHuonetyyppi) on UPDATE CASCADE on DELETE CASCADE;
//ALTER TABLE varaukset add CONSTRAINT fk_huoneen_numero FOREIGN KEY (huoneenNumero) REFERENCES huoneet (numero) on UPDATE CASCADE on DELETE CASCADE;
//