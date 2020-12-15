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

        // Näyttää huoneen numeron valitun huonetyypin mukaan
        public DataTable huoneTyypinMukaan(int tyyppi)
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huoneet` WHERE `tyyppi`=@tpi and vapaa=Kyllä", yht.OtaYhteytta());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            komento.Parameters.Add("@tpi", MySqlDbType.Int32).Value = tyyppi;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
            // Jokin virhe "unknown column where clause is "Kyllä"", ei avaa sivua.

        }
        // Funktio, joka palauttaa huonetyypit
        public int haeHuoneTyyppi(int numero)
        {
            MySqlCommand komento = new MySqlCommand("SELECT `tyyppi` FROM `huoneet` WHERE numero=@num", yht.OtaYhteytta());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return Convert.ToInt32(taulu.Rows[0][0].ToString());

        }

        // Funktio, joka muuttaa vapaa = EI
       /* public bool huoneEiVapaa(int numero, String KyllaEi)
        {
            MySqlCommand komento = new MySqlCommand("UPDATE `huoneet` SET `vapaa`=`Ei` WHERE `numero`=@num", yht.OtaYhteytta());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;

            yht.AvaaYhteys();

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
        */

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

        // Funktio joka hakee kaikki huoneet
        public DataTable haeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huoneet`", yht.OtaYhteytta());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        // Funktio valitun huoneen muokkaaamiseksi
        public bool muokkaaHuonetta(int numero, int tyyppi, String puhelin, String vapaa)
            {
                MySqlCommand komento = new MySqlCommand();
                String muokattuKysely = "UPDATE `huoneet`SET `tyyppi`= @tpi,`puhelin`= @phn,`vapaa`= @vpa WHERE `number` = @num";
                komento.CommandText = muokattuKysely;
                komento.Connection = yht.OtaYhteytta();
                //komento.Parameters.Add("");

                //@num, @tpi, @phn, @vpa)
                komento.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
                komento.Parameters.Add("@tpi", MySqlDbType.Int32).Value = tyyppi;
                komento.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
                komento.Parameters.Add("@vpa", MySqlDbType.VarChar).Value = vapaa;

                yht.AvaaYhteys();

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

            // Funktio huoneen poistamiseksi
            public bool poistaHuone(int numero)
            {
                MySqlCommand komento = new MySqlCommand();
                String poistaKysely = "DELETE FROM `huoneet` WHERE `numero`=@num";
                komento.CommandText = poistaKysely;
                komento.Connection = yht.OtaYhteytta();
                //komento.Parameters.Add("");

                //@num
                komento.Parameters.Add("@num", MySqlDbType.VarChar).Value = numero;

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
    


