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
            HuoneenTyyppiCB.DataSource = huoneet.huoneTyyppiLista();
            HuoneenTyyppiCB.DisplayMember = "";
            HuoneenTyyppiCB.ValueMember = "";


        }
    }
}
