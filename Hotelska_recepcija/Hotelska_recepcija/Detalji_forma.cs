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
    public partial class Detalji_forma : Form
    {
        public Detalji_forma()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Detalji_forma_Load(object sender, EventArgs e)
        {
            label4.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
