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
    public partial class Paasivu : Form
    {
        public Paasivu()
        {
            InitializeComponent();
        }
        // Tämä sulkee ohjelman, kun ikkuna suljetaan
        private void SuljePaasivuLB_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void SuljePaasivuLB_MouseEnter(object sender, EventArgs e)
        {
            SuljePaasivuLB.ForeColor = Color.Black;
        }

        private void SuljePaasivuLB_MouseLeave(object sender, EventArgs e)
        {
            SuljePaasivuLB.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Määritetään, se että mitä tapahtuu kun klikataan kohdasta Hallitse asiakkaita
        private void asiakkaidenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallitseAsiakkaita hallitseA = new HallitseAsiakkaita();
            hallitseA.Show();
        }

        private void varaustenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallitseVarauksia hallitseV = new HallitseVarauksia();
            hallitseV.Show();
        }

        private void huoneidenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallitseHuoneita hallitseH = new HallitseHuoneita();
            hallitseH.Show();
        }
    }
}
