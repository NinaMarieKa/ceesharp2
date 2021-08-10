using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProHoleOy
{
    class YHDISTA
    {
        private readonly MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=proholeoy");
        // Funktio, jolla otetaan yhteyttä
        public MySqlConnection OtaYhteytta()
       {
        return yhteys;
       }

        // Funktio yhteyden avaamista varten
        public void AvaaYhteys()
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        // Funktio yhteyden sulkemiseksi
        public void SuljeYhteys()
        {
            if(yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }

}
