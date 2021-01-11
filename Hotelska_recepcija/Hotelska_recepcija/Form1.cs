using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelska_recepcija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Height = 50;
            uC_Naslovna1.Show();

            uC_Onama1.Hide();
            uC_Smjestaj1.Hide();
            uC_Restorancs1.Hide();
            uC_PosebnaPonuda1.Hide();
            uC_Kontakt1.Hide();
        }

        private void btn_onama_Click(object sender, EventArgs e)
        {
            uC_Onama1.Show();

            uC_Naslovna1.Hide();
            uC_Smjestaj1.Hide();
            uC_Restorancs1.Hide();
            uC_PosebnaPonuda1.Hide();
            uC_Kontakt1.Hide();
        }

        private void btn_smjestaj_Click(object sender, EventArgs e)
        {
            uC_Smjestaj1.Show();

            uC_Naslovna1.Hide();
            uC_Onama1.Hide();
            uC_Restorancs1.Hide();
            uC_PosebnaPonuda1.Hide();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            uC_Naslovna1.Show();

            uC_Onama1.Hide();
            uC_Smjestaj1.Hide();
            uC_Restorancs1.Hide();
            uC_PosebnaPonuda1.Hide();
            uC_Kontakt1.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_restoran_Click(object sender, EventArgs e)
        {
            uC_Restorancs1.Show();

            uC_Naslovna1.Hide();
            uC_Onama1.Hide();
            uC_Smjestaj1.Hide();
            uC_PosebnaPonuda1.Hide();
            uC_Kontakt1.Hide();
        }

        private void btn_posebnaponuda_Click(object sender, EventArgs e)
        {
            uC_PosebnaPonuda1.Show();

            uC_Naslovna1.Hide();
            uC_Onama1.Hide();
            uC_Smjestaj1.Hide();
            uC_Restorancs1.Hide();
            uC_Kontakt1.Hide();

        }

        private void btn_kontakt_Click(object sender, EventArgs e)
        {
            uC_Kontakt1.Show();

            uC_Naslovna1.Hide();
            uC_Onama1.Hide();
            uC_Smjestaj1.Hide();
            uC_Restorancs1.Hide();
            uC_PosebnaPonuda1.Hide();
        }
    }
}
