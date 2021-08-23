using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConstructionControl
{
    public partial class Orders : Form
    {
        ORDERSC ordr = new ORDERSC();
        public Orders()
        {
            InitializeComponent();
        }

       
        private void TilauksetTyhjennaBTN_Click(object sender, EventArgs e)
        {
            // Määritetään Tyhjennä kentät- painikkeen toiminnot
            // Defining what happens when Tyhjennä kentät- button is clicked
            TilaajaAsiakasTB.Text = "";
            TilaajaTB.Text = "";
            TilaajanTyonumeroTB.Text = "";
            TilaajaOsoiteTB.Text = "";
            TilaajaPostinumeroTB.Text = "";
            TilaajaToimipaikkaTB.Text = "";
            TilaajaPuhTB.Text = "";
            TilaajaTyoTB.Text = "";
        }

        private void lisaaTilausBTN_Click(object sender, EventArgs e)
        {
            string clientName = TilaajaAsiakasTB.Text;
            string orderer = TilaajaTB.Text;
            int workNumber = Convert.ToInt32(TilaajanTyonumeroTB.Text);
            string orderAddress = TilaajaOsoiteTB.Text;
            int postCode = Convert.ToInt32(TilaajaPostinumeroTB.Text);
            string city = TilaajaToimipaikkaTB.Text;
            int phone = Convert.ToInt32(TilaajaPuhTB.Text);
            string job = TilaajaTyoTB.Text;


            Boolean addOrder = ORDERSC.addOrder(clientName, orderer, workNumber, orderAddress, postCode, city, phone, job);

            if(addOrder)
            {
                TilauksetDGV.DataSource = ORDERSC.getOrders();
                MessageBox.Show("Uusi tilaus lisätty onnistuneesti", "Tilaus lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Tilauksen lisääminen epäonnistui", "Tilausta ei lisätty", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }
    }
}
