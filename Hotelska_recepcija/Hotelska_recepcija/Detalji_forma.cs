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
            SqlDataReader reader = command.ExecuteReader();
            if( reader.Read() )
            {
                string text = reader["Opis"].ToString();
                opisLabel.Text = "\nOPIS: \n";
                opisLabel.Text += text;
                text = reader["Pojedinosti"].ToString();
                opisLabel.Text += "\n\nPOJEDINOSTI: \n";
                opisLabel.Text += text;

                cijenaLabel.Text = reader["Cijena"].ToString() + "kn";
                //label6.Text = Regex.Replace(text, "[.]", "."); 
            }
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
    }
}
