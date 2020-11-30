using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjautumislomake
{
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }

        // Tämä sulkee pääikkunan
        private void SuljePaa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Määrittää X:n värin kun hiiri asetetaan sen päälle..
        private void SuljePaa_MouseEnter(object sender, EventArgs e)
        {
            SuljePaa.ForeColor = Color.Red;
        }
        //..ja tämä värin kun hiiri siirretään pois sen päältä
        private void SuljePaa_MouseLeave(object sender, EventArgs e)
        {
            SuljePaa.ForeColor = Color.Black;
        }
    }
}
