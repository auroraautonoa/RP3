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
    public partial class Rezervacija : Form
    {
        public int brojOsoba;
        public DateTime date1, date2;

        SqlConnection connection;
        string connectionString;
        string str;
        SqlCommand command;
        SqlDataReader reader;
        public Rezervacija(int broj_osoba, List<int> free_rooms, DateTime date1, DateTime date2)
        {
            this.brojOsoba = broj_osoba;
            this.date1 = date1;
            this.date2 = date2;
            
            InitializeComponent();

            List<TextBox> txt = new List<TextBox>();
            List<Label> labels = new List<Label>();

            for (int i = 0; i < broj_osoba; ++i)
            {
                TextBox ime = new TextBox(); 
                TextBox prezime = new TextBox();
                TextBox oib = new TextBox();

                Label imeL = new Label();
                Label prezimeL = new Label();
                Label oibL = new Label();

                ime.Name = String.Format("Osoba_{0}_Ime", i + 1);
                prezime.Name = String.Format("Osoba_{0}_Prezime", i + 1);
                oib.Name = String.Format("Osoba_{0}_OIB", i + 1);

                ime.Location = new Point(35 + i * 200, 100);
                prezime.Location = new Point(35 + i * 200, 175);
                oib.Location = new Point(35 + i * 200, 250);

                imeL.Location = new Point(35 + i * 200, 85);
                prezimeL.Location = new Point(35 + i * 200, 160);
                oibL.Location = new Point(35 + i * 200, 235);

                imeL.Text = String.Format("Osoba {0} Ime:", i + 1);
                prezimeL.Text = String.Format("Osoba {0} Prezime:", i + 1);
                oibL.Text = String.Format("Osoba {0} OIB:", i + 1);

                txt.Add(ime);
                txt.Add(prezime);
                txt.Add(oib);

                labels.Add(imeL);
                labels.Add(prezimeL);
                labels.Add(oibL);
            }

            foreach (var el in txt)
                this.Controls.Add(el);
            foreach (var el in labels)
                this.Controls.Add(el);
            foreach (var el in free_rooms)
                SobaBox.Items.Add(el);
        }

        private void Rezervacija_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            int id = 0;

            DateTime danas = DateTime.Today;

            string sDate = date1.ToString("yyyy-MM-dd");
            string eDate = date2.ToString("yyyy-MM-dd");
            string today = danas.ToString("yyyy-MM-dd");

            connectionString = ConfigurationManager.ConnectionStrings
                ["Hotelska_recepcija.Properties.Settings.BazaConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            connection.Open();
            str = string.Format("SELECT Id FROM Soba WHERE Broj_sobe = {0}", SobaBox.GetItemText(SobaBox.SelectedItem));
            command = new SqlCommand(str, connection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                id = (int)reader["Id"];
            }

            reader.Close();

            str = string.Format("INSERT INTO [dbo].[Rezervacija] ([Id_soba], [Datum_rezervacije], [Datum_poc], [Datum_kraj]) VALUES (@id, @datr, @datpoc, @datkraj)");
            using (command = new SqlCommand(str, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@datr", today);
                command.Parameters.AddWithValue("@datpoc", sDate);
                command.Parameters.AddWithValue("@datkraj", eDate);

                int n = command.ExecuteNonQuery();

            }

            str = string.Format("SELECT Id FROM Rezervacija ORDER BY Id DESC"); 

            command = new SqlCommand(str, connection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                id = (int)reader["Id"];
            }

            reader.Close();

            for (int i = 0; i < brojOsoba; ++i) 
            {
                str = string.Format("INSERT INTO [dbo].[Osoba] ([Id_rezervacija], [Ime], [Prezime], [OIB]) VALUES (@id, @ime, @prez, @oib)");
                using (command = new SqlCommand(str, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@ime", this.Controls["Osoba_" + (i + 1).ToString() + "_Ime"].Text);
                    command.Parameters.AddWithValue("@prez", this.Controls["Osoba_" + (i + 1).ToString() + "_Prezime"].Text);
                    command.Parameters.AddWithValue("@oib", this.Controls["Osoba_" + (i + 1).ToString() + "_OIB"].Text);

                    int n = command.ExecuteNonQuery(); 

                    if (n > 0) MessageBox.Show("Uspjesno rezervirano!");
                    else MessageBox.Show("Nesto je poslo po krivu"); 
                }
            }

            connection.Close();

        }
        private void SobaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
