using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLCMS
{
    public partial class KiThi : Form
    {
        public KiThi()
        {
            InitializeComponent();
        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {
            txtkt = new DateTimePicker();
            txtkt.Format = DateTimePickerFormat.Custom;
            txtkt.CustomFormat = "HH:mm"; // Only use hours and minutes
            txtkt.ShowUpDown = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
