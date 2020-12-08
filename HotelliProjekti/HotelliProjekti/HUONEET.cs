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

    }
}
