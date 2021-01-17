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
    public partial class Detalji_forma : Form
    {
        SqlConnection connection;
        string connectionString;
        string str;
        public int index;
        SqlCommand command;
        SqlDataReader reader;
        public Detalji_forma(int index)
        {
            InitializeComponent();
            this.index = index;
            connectionString = ConfigurationManager.ConnectionStrings
                ["Hotelska_recepcija.Properties.Settings.BazaConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            connection.Open();
            str = string.Format("SELECT * FROM VrstaSobe WHERE Id={0}",index);
            command = new SqlCommand(str, connection);
            reader = command.ExecuteReader();
            if( reader.Read() )
            {
                string text = reader["Opis"].ToString();
                opisLabel.Text = "\nOPIS: \n";
                opisLabel.Text += text;
                text = reader["Pojedinosti"].ToString();
                opisLabel.Text += "\n\nPOJEDINOSTI: \n";
                opisLabel.Text += text;

                cijenaLabel.Text = reader["Cijena"].ToString() + "kn";
                broj_osoba.Maximum = (int)reader["Broj_osoba"];
                broj_osoba.Minimum = 1;
                //label6.Text = Regex.Replace(text, "[.]", "."); 
            }
            reader.Close();
            
        }

        private void btn_Rezerviraj_Click(object sender, EventArgs e)
        {
            int k;
            List<int> taken_rooms = new List<int>();
            string date1 = date_prijava.Value.ToString("yyyyMMdd");
            string date2 = datum_odjava.Value.ToString("yyyyMMdd");
            str = string.Format("SELECT Soba.Broj_sobe FROM Soba, Rezervacija WHERE Soba.Id_VrstaSobe = {0} AND Rezervacija.Id_Soba = Soba.Id AND Rezervacija.Datum_poc <= '{2}' AND '{1}' <= Rezervacija.Datum_kraj", index, date1, date2);
            command = new SqlCommand(str, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                taken_rooms.Add((int)reader["Broj_sobe"]);             
            }

            reader.Close();

            List<int> free_rooms = new List<int>();

            str = string.Format("SELECT Broj_Sobe FROM Soba WHERE Id_VrstaSobe = {0}", index);
            command = new SqlCommand(str, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                k = 0;
                foreach (var el in taken_rooms)
                {
                    if (el == (int)reader["Broj_sobe"]) k = 1;
                }
                if (k == 0) free_rooms.Add((int)reader["Broj_sobe"]);
            }

            reader.Close();

            if (free_rooms.Count > 0) { 
                label6.Text = "";
                Rezervacija rezervacija = new Rezervacija((int)broj_osoba.Value, free_rooms, date_prijava.Value, datum_odjava.Value);
                rezervacija.Show();
            }
            else label6.Text += "Nema slobodnih soba za odabrane datume.";
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (connection = new SqlConnection(connectionString))
        }

        private void Detalji_forma_Load(object sender, EventArgs e)
        {
            label4.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cijenaLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datum_odjava_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_prijava_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
