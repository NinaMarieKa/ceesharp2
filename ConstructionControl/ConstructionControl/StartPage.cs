using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionControl
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Suljetaan ohjelma, kun tämä ikkuna suljetaan
            //Exit the application when this window is closed
            Application.Exit();
        }

        private void tilauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void työmaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkSites worksites = new WorkSites();
            worksites.ShowDialog();
        }

        private void työntekijätToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.ShowDialog();
        }

        private void alihankkijatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subcontractors sub = new Subcontractors();
            sub.ShowDialog();
        }

        private void laskutusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoicing invc = new Invoicing();
            invc.ShowDialog();
        }
    }
}
