using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Hotelska_recepcija
{
    public partial class UC_Kontakt : UserControl
    {
        SqlConnection connection;
        string connectionString;
        string str;
        SqlCommand command;
        SqlDataReader reader;

        public UC_Kontakt()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings
               ["Hotelska_recepcija.Properties.Settings.BazaConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            connection.Open();
            str = string.Format("SELECT Osoba.Ime, Osoba.Prezime, Soba.Broj_Sobe FROM Osoba, Rezervacija, Soba WHERE Osoba.Id_rezervacija = Rezervacija.Id AND Rezervacija.Id_soba = Soba.Id");
            command = new SqlCommand(str, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string text = reader["Ime"].ToString() + " " + reader["Prezime"].ToString() + ", Soba br. " + reader["Broj_sobe"].ToString();

                guest_list.Items.Add(text);
            }
            reader.Close();
            connection.Close();

            guest_list.Visible = true;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
