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


namespace HotelliProjekti
{
    public partial class Kirjautumisikkuna : Form
    {
        public Kirjautumisikkuna()
        {
            InitializeComponent();
        }


        // Määritetään toiminnot Kirjaudu- painikkeelle
        private void KirjauduTastaBTN_Click(object sender, EventArgs e)
        {
            // Käytetään YHDISTA luokkaa, jonka olen luonut
            YHDISTA tietokantaan = new YHDISTA();
            // Luodaan muuttujia yhdistämistä varten
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();
            // Tässä kohtaa tehdään kysely
            String kysely = "SELECT ktunnus, salasana FROM asiakkaat WHERE ktunnus = @kn AND salasana = @ss";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteytta();

            // Tässä kohdassa lisätään lomakkeelta tiedot muuttujiin @kn ja @ss
            komento.Parameters.Add("@kn", MySqlDbType.VarChar).Value = KayttajaKirjauduTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = SalisKirjauduTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            // Seuraavaksi tarkistetaan löytyykö käyttäjä ja salasana tietokannasta
            if(taulu.Rows.Count > 0)
            {
                //Tämä lomake piiloon ja avataan pääsivu
                Paasivu paa = new Paasivu();
                this.Hide();
                paa.Show();
            }
            // Tarkistetaan onko jompikumpi kenttä tyhjä
            else
            {
                if(KayttajaKirjauduTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjänimesi kirjautuaksesi", "Käyttäjänimi- kenttä on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(SalisKirjauduTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasanasi kirjautuaksesi", "Salasana- kenttä on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Jos tunnusta ei löydy, vaikka tiedot on syötetty
                else
                {
                    MessageBox.Show("Käyttäjätunnusta tai salasanaa ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
    }
}
