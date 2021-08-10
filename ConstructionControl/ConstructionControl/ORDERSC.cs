using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ConstructionControl
{

    // Luokka tilausten lisäämiseksi, muokkaamiseksi, hakemiseksi ja poistamiseksi
    // Class for adding, editing, getting and deleting orders

   
    class ORDERSC
    {
        // Function for addind a new order
        // Funktio uuden tilauksen lisäämiseksi
        CONNECT conn = new CONNECT();

        public bool addOrder(String clientName, String orderer, int workNumber, String orderAddress,
        int postCode, String city, int phone, String job)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `tilaukset`(`Asiakkaan nimi`, `Tilaaja`, `Työnumero`, " +
            "`Työmaan osoite`, `Postinumero`, `Paikkakunta`, `Puhelinnumero`, `Tilattu työ`) VALUES (@fnm,@til,@tno,@oso,@pno,@pka,@nro,@tyo)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = clientName;
            command.Parameters.Add("@til", MySqlDbType.VarChar).Value = orderer;
            command.Parameters.Add("@tno", MySqlDbType.Int32).Value = workNumber;
            command.Parameters.Add("@oso", MySqlDbType.VarChar).Value = orderAddress;
            command.Parameters.Add("@pno", MySqlDbType.Int32).Value = postCode;
            command.Parameters.Add("@pka", MySqlDbType.VarChar).Value = city;
            command.Parameters.Add("@nro", MySqlDbType.Int32).Value = phone;
            command.Parameters.Add("@tyo", MySqlDbType.VarChar).Value = job;

            conn.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
  
        }
        public DataTable getOrders()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM tilaukset", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

    }
}
