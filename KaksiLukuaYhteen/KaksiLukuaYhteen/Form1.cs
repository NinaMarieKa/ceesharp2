using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaksiLukuaYhteen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeYhteenPainike_Click(object sender, EventArgs e)
        {
            int luku1 = 0, luku2 = 0, summa;
            try
            {
                luku1 = int.Parse(Luku1_Tekstilaatikko.Text);
            }
            catch
            {
                VastausLabel.Text = "Anna vain numeroina kokonaislukuja";
                Luku1_Tekstilaatikko.Text = "";
                Luku1_Tekstilaatikko.Focus();

            }
            try
            {
                luku2 = int.Parse(Luku2_Tekstilaatikko.Text);
            }
            catch
            {
                VastausLabel.Text = "Anna vain numeroina kokonaislukuja";
                Luku2_Tekstilaatikko.Text = "";
                Luku2_Tekstilaatikko.Focus();

            }
            summa = luku1 + luku2;
            VastausLabel.Visible = true;
            VastausLabel.Text = ("" + summa);
            
        }
    }
}
