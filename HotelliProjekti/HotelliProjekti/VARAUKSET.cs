using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotelliProjekti
{
    class VARAUKSET
    {
        // Yhdistellään luokkaan Yhdistä
        YHDISTA yht = new YHDISTA();

        public DataTable huoneTyyppiLista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `huone_tyypit`", yht.OtaYhteytta());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;

        }


        // Hakee kaikki varaukset
        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `varaukset`", yht.OtaYhteytta());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        // Funktio uuden varauksen lisäämiseksi
        public bool lisaaVaraus(int hnumero, int anumero, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaaKysely = "INSERT INTO `varaukset`(`huoneenNumero`,`asiakasNumero`, `sisaanKirj`, `ulosKirj`) VALUES (@hno,@ano,@spv,@upv)";
            komento.CommandText = lisaaKysely;
            komento.Connection = yht.OtaYhteytta();


            //@hno,@ano,@spv,@upv
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnumero;
            komento.Parameters.Add("@ano", MySqlDbType.Int32).Value = anumero;
            komento.Parameters.Add("@spv", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@upv", MySqlDbType.Date).Value = ulos;
            

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

        // Funktio valitun varauksen muokkaamiseksi
        public bool muokkaaVarausta(int vnumero, int hnumero, int anumero, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String muokattuKysely = "UPDATE `varaukset` SET `varausNumero`=@vno,`huoneenNumero`=@hno,`asiakasNumero`=@ano,`sisaanKirj`=@spv,`ulosKirj`=@upv WHERE `varausNumero`=@vno";
            komento.CommandText = muokattuKysely;
            komento.Connection = yht.OtaYhteytta();


            //@vno,@hno,@ano,@spv,@upv
            komento.Parameters.Add("@vno", MySqlDbType.Int32).Value = vnumero;
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnumero;
            komento.Parameters.Add("@ano", MySqlDbType.Int32).Value = anumero;
            komento.Parameters.Add("@spv", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@upv", MySqlDbType.Date).Value = ulos;

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

        // Funktio varauksen poistamiseksi
        public bool poistaVaraus(int vnumero)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistaKysely = "DELETE FROM `varaukset` WHERE `varausNumero`=@vno";
            komento.CommandText = poistaKysely;
            komento.Connection = yht.OtaYhteytta();
           

            //@vno
            komento.Parameters.Add("@vno", MySqlDbType.VarChar).Value = vnumero;

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
