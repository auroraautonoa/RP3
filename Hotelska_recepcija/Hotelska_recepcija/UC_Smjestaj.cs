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
    public partial class UC_Smjestaj : UserControl
    {
        public UC_Smjestaj()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void detalji_Jednokrevetna_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("kliknut");
            Detalji_forma detalji = new Detalji_forma();
            detalji.Show();

        }
    }
}
