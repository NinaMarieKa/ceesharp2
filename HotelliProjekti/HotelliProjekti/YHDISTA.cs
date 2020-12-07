using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelliProjekti
{
    /*
     * Tämä luokka luo yhteyden tämän ohjelman ja MySQL:n välille
     */
    class YHDISTA
    {
        private readonly MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=hotelli");
        // Funktio yhteyden ottamista varten
        public MySqlConnection OtaYhteytta()
        {
            return yhteys;
        }
        // Alla funktio yhteyden avaamista varten
        public void AvaaYhteys()
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        // Tässä funktio yhteyden sulkemista varten
        public void SuljeYhteys()
        {
            if(yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
