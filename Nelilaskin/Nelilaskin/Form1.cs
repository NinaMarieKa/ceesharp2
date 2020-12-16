using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelilaskin
{
    public partial class Form1 : Form
    {
        double arvo = 0;
        string toimitus = "";
        bool toimitus_klikattu = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        // Toiminto näppäimelle 1
        private void numYksi_Click(object sender, EventArgs e)
        {
            if ((tulosBoksi.Text == "0")|| (toimitus_klikattu))
                tulosBoksi.Clear();
            toimitus_klikattu = false;
           

            tulosBoksi.Text = tulosBoksi.Text + "1";
        }

        // Toiminto näppäimelle 2
        private void numKaksi_Click(object sender, EventArgs e)
        {
            if ((tulosBoksi.Text == "0")|| (toimitus_klikattu))
                tulosBoksi.Clear();
            toimitus_klikattu = false;

            tulosBoksi.Text = tulosBoksi.Text + "2";
        }

        // Toiminto näppäimelle 3
        private void numKolme_Click(object sender, EventArgs e)
        {
            if ((tulosBoksi.Text == "0")|| (toimitus_klikattu))
                tulosBoksi.Clear();
            toimitus_klikattu = false;

            tulosBoksi.Text = tulosBoksi.Text + "3";
        }

        // Toiminto näppäimelle 4
        private void numNeljä_Click(object sender, EventArgs e)
        {
            if ((tulosBoksi.Text == "0")|| (toimitus_klikattu))
                tulosBoksi.Clear();
            toimitus_klikattu = false;

            tulosBoksi.Text = tulosBoksi.Text + "4";
        }

        // Toiminto näppäimelle 5
        private void numViisi_Click(object sender, EventArgs e)
        {
            if ((tulosBoksi.Text == "0")|| (toimitus_klikattu))
                tulosBoksi.Clear();
            toimitus_klikattu = false;

            tulosBoksi.Text = tulosBoksi.Text + "5";
        }

        // Toiminto näppäimelle 6
        private void numKuusi_Click(object sender, EventArgs e)
        {
            if ((tulosBoksi.Text == "0")|| (toimitus_klikattu))
                tulosBoksi.Clear();
            toimitus_klikattu = false;

            tulosBoksi.Text = tulosBoksi.Text + "6";
        }

        // Toiminto näppäimelle 7
        private void numSeiska_Click(object sender, EventArgs e)
        {
            if ((tulosBoksi.Text == "0")|| (toimitus_klikattu))
                tulosBoksi.Clear();
            toimitus_klikattu = false;

            tulosBoksi.Text = tulosBoksi.Text + "7";
        }

        // Toiminto näppäimelle 8
        private void numKasi_Click(object sender, EventArgs e)
        {
            if ((tulosBoksi.Text == "0")||(toimitus_klikattu))
                tulosBoksi.Clear();
            toimitus_klikattu = false;

            tulosBoksi.Text = tulosBoksi.Text + "8";
        }

        // Toiminto näppäimelle 9
        private void numYsi_Click(object sender, EventArgs e)
        {
            if ((tulosBoksi.Text == "0")||(toimitus_klikattu))
                tulosBoksi.Clear();
            toimitus_klikattu = false;

            tulosBoksi.Text = tulosBoksi.Text + "9";
        }

        private void nappiPiste_Click(object sender, EventArgs e)
        {
            if (tulosBoksi.Text == "0")
                tulosBoksi.Clear();
            toimitus_klikattu = false;

            tulosBoksi.Text = tulosBoksi.Text + ".";
        }

        private void nappiCe_Click(object sender, EventArgs e)
        {
            tulosBoksi.Text = "0";
        }

        private void toimitus_klik(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            toimitus = b.Text;
            arvo = Double.Parse(tulosBoksi.Text);
            toimitus_klikattu = true;
            laskuToimitus.Text = arvo + " " + toimitus;
        }

        private void nappiTulos_Click(object sender, EventArgs e)
        {
            
            laskuToimitus.Text = "";
            switch (toimitus)
            {
                case "+":
                    tulosBoksi.Text = (arvo + Double.Parse(tulosBoksi.Text)).ToString();
                    break;
                case "-":
                    tulosBoksi.Text = (arvo - Double.Parse(tulosBoksi.Text)).ToString();
                    break;
                case "*":
                    tulosBoksi.Text = (arvo * Double.Parse(tulosBoksi.Text)).ToString();
                    break;
                case "/":
                    tulosBoksi.Text = (arvo / Double.Parse(tulosBoksi.Text)).ToString();
                    break;
                default:
                    break;

            }// tähän loppuu switch
            
        }

        private void nappiC_Click(object sender, EventArgs e)
        {
            tulosBoksi.Text = "0";
            arvo = 0;
        }

      
    }
}
