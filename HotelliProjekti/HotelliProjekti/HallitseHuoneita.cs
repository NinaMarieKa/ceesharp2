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
    public partial class HallitseHuoneita : Form
    {
        public HallitseHuoneita()
        {
            InitializeComponent();
        }

        HUONEET huoneet = new HUONEET();
        private void HallitseHuoneita_Load(object sender, EventArgs e)
        {
            try
            {
                HuoneenTyyppiCB.DataSource = huoneet.huoneTyyppiLista();
                HuoneenTyyppiCB.DisplayMember = "tyyppi";
                HuoneenTyyppiCB.ValueMember = "idHuonetyyppi";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UusiHuoneBTN_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HuoneenNumeroTB.Text);
            int tyyppi = Convert.ToInt32(HuoneenTyyppiCB.Text);
            string puhelin = HuonePuhelinTB.Text;

            if(huoneet.lisaaHuone(numero, tyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huone lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huoneen lisäys epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void HuoneMuokkaaBTN_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HuoneenNumeroTB.Text);
            int tyyppi = Convert.ToInt32(HuoneenTyyppiCB.SelectedValue.ToString());
            String puhelin = HuonePuhelinTB.Text;
            String vapaa = ""; 
             
            if(radioButtonKylla.Checked)
            {
                vapaa = "KYLLÄ";
            }
            else if(radioButtonEi.Checked)
            {
                vapaa = "EI";
            }
            if (huoneet.muokkaaHuonetta(numero,tyyppi,puhelin,vapaa))
            {
                MessageBox.Show("Huonetta muokattu onnistuneesti", "Huonetta muokattu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huoneen muokkaus epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void HuonePoistaBTN_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HuoneenNumeroTB.Text);

            if (huoneet.poistaHuone(numero))
            {
                MessageBox.Show("Huone poistettu onnistuneesti", "Huone poistettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huoneen poistaminen epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HuoneTyhjennaBTN_Click(object sender, EventArgs e)
        {
            HuoneenNumeroTB.Text = "";
            HuoneenTyyppiCB.SelectedIndex = 0;
            HuonePuhelinTB.Text = "";
        }
        
        // Näyttää valitun rivin tekstibokseissa 
        private void dGVHuoneet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneenNumeroTB.Text = dGVHuoneet.CurrentRow.Cells[0].Value.ToString();
            HuoneenTyyppiCB.SelectedValue = dGVHuoneet.CurrentRow.Cells[1].Value;
            HuonePuhelinTB.Text = dGVHuoneet.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
