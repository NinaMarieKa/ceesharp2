using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitustehtavat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EtusivuPainike_Click(object sender, EventArgs e)
        {
            String etunimi = TekstiLaatikko.Text;
            ViestiLabel.Text = "Hei " + etunimi + ", oikein hyvää viikkoa sinulle!";
            ViestiLabel.Visible = true;

        }
    }
}
