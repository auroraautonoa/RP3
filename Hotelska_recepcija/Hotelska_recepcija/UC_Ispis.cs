using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotelska_recepcija
{
    public partial class UC_Ispis : UserControl
    {
        SqlConnection connection;
        string connectionString;
        string str;
        SqlCommand command;
        SqlDataReader reader;

        public void refresh()
        {
            listBox1.Items.Clear();
            connectionString = ConfigurationManager.ConnectionStrings
               ["Hotelska_recepcija.Properties.Settings.BazaConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            connection.Open();
            str = string.Format("SELECT Rezervacija.Id, Osoba.Ime, Osoba.Prezime, Soba.Broj_Sobe FROM Osoba, Rezervacija, Soba WHERE Osoba.Id_rezervacija = Rezervacija.Id AND Rezervacija.Id_soba = Soba.Id");
            command = new SqlCommand(str, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string text = reader["Id"].ToString() + " " + reader["Ime"].ToString() + " " + reader["Prezime"].ToString() + ", Soba br. " + reader["Broj_sobe"].ToString();
                listBox1.Items.Add(text);
            }
            reader.Close();
            connection.Close();

            listBox1.Visible = true;
        }

        public UC_Ispis()
        { 
            InitializeComponent();

            refresh();
        }

        private void izbrisiButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            str = string.Format("DELETE FROM Osoba WHERE Id_rezervacija = {0}", listBox1.SelectedItem.ToString()[0]);
            using (command = new SqlCommand(str, connection))
            {
                int n = command.ExecuteNonQuery();

            }

            str = string.Format("DELETE FROM Rezervacija WHERE Id = {0}", listBox1.SelectedItem.ToString()[0]);
            using (command = new SqlCommand(str, connection))
            {
                int n = command.ExecuteNonQuery(); 

                if (n > 0) MessageBox.Show("Uspjesno izbrisano!");
                else MessageBox.Show("Nesto je poslo po krivu");
            }
            refresh();
            connection.Close(); 
        } 
    }
}
