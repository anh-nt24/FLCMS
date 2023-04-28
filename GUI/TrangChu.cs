using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
           
            
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnnguoidung_Click_1(object sender, EventArgs e)
        {
            qlnd2.BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anhTrangChu1.BringToFront();
        }
    }
}
