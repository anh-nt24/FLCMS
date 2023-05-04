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
            qlnd1.BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //anhTrangChu1.BringToFront();
        }

        private void btnkithi_Click(object sender, EventArgs e)
        {
            qlkt2.BringToFront();
        }

        private void btncn_Click(object sender, EventArgs e)
        {
            qlcn2.BringToFront();
        }

        private void btnhocvien_Click(object sender, EventArgs e)
        {
            qlhv2.BringToFront();
        }

        private void qlhv1_Load(object sender, EventArgs e)
        {

        }

        private void btndiemthi_Click(object sender, EventArgs e)
        {
            qldt1.BringToFront();
        }

        private void btnlichhoc_Click(object sender, EventArgs e)
        {
            qlhd1.BringToFront();
        }

        private void btnlh_Click(object sender, EventArgs e)
        {
            qllh1.BringToFront();
        }

        private void btnkhoahoc_Click(object sender, EventArgs e)
        {
            qlkh1.BringToFront();
        }

        private void btngiaovien_Click(object sender, EventArgs e)
        {
            qlgv1.BringToFront();
        }
    }
}
