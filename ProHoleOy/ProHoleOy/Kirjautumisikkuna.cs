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

namespace ProHoleOy
{
    public partial class Kirjautumisikkuna : Form
    {
        public Kirjautumisikkuna()
        {
            InitializeComponent();
        }

        private void kirjauduBTN_Click(object sender, EventArgs e)
        {
            //Käytetään yhdistä- luokkaa
            YHDISTA tietokantaan = new YHDISTA();
            //Luodaan muuttujia yhdistämistä varten
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();
            // Tehdään kysely
            String kysely = "SELECT * FROM `hallinta` WHERE `Tunnus` = @tns AND `Salasana` = @ssa";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteytta();

            //Lisätään lomakkeelta tiedot muuttujiin @tns ja @ssa
            komento.Parameters.Add("@tns", MySqlDbType.VarChar).Value = kayttajaTB.Text;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salasanaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            //Tarkistetaan löytyykö tunnukset tietokannasta
            if(taulu.Rows.Count > 0)
            {
                //Tämä lomake piiloon ja avataan pääsivu
              
                this.Hide();
                
            }
            // Tarkistetaan onko jompikumpi kenttä tyhjä
            else
            {
                if(kayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjätunnus kirjautuaksesi", "Käyttäjätunnus- kenttä on tyhjä", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(salasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana kirjautuaksesi", "Salasana- kenttä on tyhjä",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Jos tunnusta ei löydy
                else
                {
                    MessageBox.Show("Käyttäjätunnusta tai salasanaa ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
