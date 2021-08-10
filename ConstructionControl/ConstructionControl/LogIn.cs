using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionControl
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void kirjauduBTN_Click(object sender, EventArgs e)
        {
            // Yhdistetään luokkaan CONNECT
            // Connecting to the CONNECT- class

            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `hallinta` WHERE `Käyttäjätunnus`=@ktu AND `Salasana` =@ssa";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttajaTB.Text;
            command.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salasanaTB.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Jos käyttäjätunnus ja salasana on kirjoitettu
            // If the username and password are typed

            if(table.Rows.Count > 0)
            {
                //Show the StartPage
                //Näytetään pääsivu
                this.Hide();
                StartPage spage = new StartPage();
                spage.Show();
            }
            else
            {
                // Jos käyttäjätunnus- kenttä on tyhjä
                // If username- textbox is empty
                if (kayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjätunnus kirjautuaksesi", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Jos salasana- kenttä on tyhjä
                // If password- textbox is empty
                else if (salasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana kirjautuaksesi", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Jos salasana tai käyttäjätunnus on väärin
                // If the username or password is wrong
                else
                {
                    MessageBox.Show("Käyttäjätunnus tai salasana on väärin", "Väärä käyttäjätunnus tai salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
