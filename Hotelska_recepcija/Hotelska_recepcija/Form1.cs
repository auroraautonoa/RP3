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

        private void VisualizeUC(Control value)
        {
            uC_Onama1.Visible = false;
            uC_Smjestaj1.Visible = false;
            uC_Naslovna1.Visible = false;
            uC_Restorancs1.Visible = false;
            uC_Kontakt1.Visible = false;
            uC_PosebnaPonuda1.Visible = false;

            value.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Controls.Add(uC_Onama1);
            panel2.Controls.Add(uC_Smjestaj1);
            panel2.Controls.Add(uC_Restorancs1);
            panel2.Controls.Add(uC_Naslovna1);
            panel2.Controls.Add(uC_PosebnaPonuda1);
            panel2.Controls.Add(uC_Kontakt1);
            VisualizeUC(uC_Naslovna1);

            panel1.Height = 50;
        }

        private void btn_onama_Click(object sender, EventArgs e)
        {
            VisualizeUC(uC_Onama1);
        }

        private void btn_smjestaj_Click(object sender, EventArgs e)
        {
            VisualizeUC(uC_Smjestaj1);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            VisualizeUC(uC_Naslovna1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VisualizeUC(uC_Naslovna1);
        }

        private void btn_restoran_Click(object sender, EventArgs e)
        {
            VisualizeUC(uC_Restorancs1);
        }

        private void btn_posebnaponuda_Click(object sender, EventArgs e)
        {
            VisualizeUC(uC_PosebnaPonuda1);

        }

        private void btn_kontakt_Click(object sender, EventArgs e)
        {
            VisualizeUC(uC_Kontakt1);
        }
    }
}
