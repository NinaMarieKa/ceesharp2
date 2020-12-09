using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace HotelliProjekti
{
    /* 
     * Luokka huoneiden hallintaa varten
     * 
     * 
     */
    class HUONEET
    {
        YHDISTA yht = new YHDISTA();
        // Fuktio, joka hakee listan huonetyypeistä
        public DataTable huoneTyyppiLista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huone_tyypit`", yht.OtaYhteytta());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;

        }

        // Funktio uuden huoneen lisäämiseksi
        public bool lisaaHuone(int numero, int tyyppi, String puhelin, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaaKysely = "INSERT INTO `huoneet`(`numero`, `tyyppi`, `puhelin`, `vapaa`) VALUES (@num, @tpi, @phn, @vpa) ";
            komento.CommandText = lisaaKysely;
            komento.Connection = yht.OtaYhteytta();
            

            //@num, @tpi, @phn, @vpa)
            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@tpi", MySqlDbType.Int32).Value = tyyppi;
            komento.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@vpa", MySqlDbType.VarChar).Value = vapaa;
          
            yht.AvaaYhteys();
            // Avataan ja suljetaan yhteys
            if (komento.ExecuteNonQuery() == 1)
            {
                yht.SuljeYhteys();
                return true;

            }
            else
            {
                yht.SuljeYhteys();
                return false;
            }

           }

        }
    }
