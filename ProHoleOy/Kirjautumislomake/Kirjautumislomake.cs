using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kirjautumislomake
{
    public partial class Kirjautumislomake : Form
    {
        public Kirjautumislomake()
        {
            InitializeComponent();
        }

        private void BTNKirjaudu_Click(object sender, EventArgs e)
        {
            YHDISTA tietokantaan = new YHDISTA();

            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();

            String kysely = "SELECT * FROM `hallinta` WHERE `Tunnus` = @tns AND `Salasana` = @ssa";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteytta();

            komento.Parameters.Add("@tns", MySqlDbType.VarChar).value = TBKayttaja.Text;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).value = TBSalasana.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            // Tarkistetaan löytyykö käyttäjä ja salasana tietokannasta
            if(taulu.Rows.Count > 0)
            {
                Paasivu paa = Paasivu();
                this.Hide();
                paa.Show();
            }
            else
            {
                if(TBKayttaja.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjätunnuksesi kirjautuaksesi", "Käyttäjätunnus- kenttä on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(TBSalasana.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasanasi kirjautuaksesi", "Salasana- kenttä on täyttämättä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Jos tunnusta ei löydy
                else
                {
                    MessageBox.Show("Käyttäjätunnusta tai salasanaa ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
