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
        // Yhdistetään luokkaan
        HUONEET huoneet = new HUONEET();
        private void HallitseHuoneita_Load(object sender, EventArgs e)
        {
            try
            {
                HuoneenTyyppiCB.DataSource = huoneet.huoneTyyppiLista();
                HuoneenTyyppiCB.DisplayMember = "tyyppi";
                HuoneenTyyppiCB.ValueMember = "idHuonetyyppi";

                dGVHuoneet.DataSource = huoneet.haeHuoneet();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Uuden huoneen lisääminen
        private void UusiHuoneBTN_Click(object sender, EventArgs e)
        {
            
            
            int tyyppi = Convert.ToInt32(HuoneenTyyppiCB.SelectedValue.ToString());
            string puhelin = HuonePuhelinTB.Text;
            string vapaa = "";


            try
            {
                int numero = Convert.ToInt32(HuoneenNumeroTB.Text);
                if (radioButtonKylla.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if (radioButtonEi.Checked)
                {
                    vapaa = "Ei";
                }
                if (puhelin.Trim().Equals("") || vapaa.Trim().Equals(""))
                {
                    MessageBox.Show("Pakollisia kenttiä täyttämättä", "TYHJIÄ KENTTIÄ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (huoneet.lisaaHuone(numero, tyyppi, puhelin, vapaa))
                {
                    dGVHuoneet.DataSource = huoneet.haeHuoneet();
                    MessageBox.Show("Huone lisätty onnistuneesti", "Huone lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Huoneen muokkaus

       
        private void HuoneMuokkaaBTN_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(HuoneenTyyppiCB.SelectedValue.ToString());
            String puhelin = HuonePuhelinTB.Text;
            String vapaa = ""; 
            
            try
            {
                int numero = Convert.ToInt32(HuoneenNumeroTB.Text);
                if (radioButtonKylla.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if (radioButtonEi.Checked)
                {
                    vapaa = "Ei";
                }
                if (huoneet.muokkaaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    dGVHuoneet.DataSource = huoneet.haeHuoneet();
                    MessageBox.Show("Huonetta muokattu onnistuneesti", "Huonetta muokattu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen muokkaus epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
            
                
        }

        // Huoneen poistaminen
        private void HuonePoistaBTN_Click(object sender, EventArgs e)
        { 
            try
            {
                int numero = Convert.ToInt32(HuoneenNumeroTB.Text);

                if (huoneet.poistaHuone(numero))
                {
                    dGVHuoneet.DataSource = huoneet.haeHuoneet();
                    MessageBox.Show("Huone poistettu onnistuneesti", "Huone poistettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen poistaminen epäonnistui", "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "VIRHE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Kenttien tyhjentäminen
        private void HuoneTyhjennaBTN_Click(object sender, EventArgs e)
        {
            HuoneenNumeroTB.Text = "";
            HuoneenTyyppiCB.SelectedIndex = 0;
            HuonePuhelinTB.Text = "";
            radioButtonKylla.Checked = true;
        }
        
        // Näyttää valitun rivin tekstibokseissa 
        private void dGVHuoneet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneenNumeroTB.Text = dGVHuoneet.CurrentRow.Cells[0].Value.ToString();
            HuoneenTyyppiCB.SelectedValue = dGVHuoneet.CurrentRow.Cells[1].Value;
            HuonePuhelinTB.Text = dGVHuoneet.CurrentRow.Cells[2].Value.ToString();

            string vapaa = dGVHuoneet.CurrentRow.Cells[2].Value.ToString();

            if(vapaa.Equals("Kyllä"))
            {
                radioButtonKylla.Checked = true;
            }
            else if(vapaa.Equals("Ei"))
            {
                radioButtonEi.Checked = true;
            }
        }
    }
}
