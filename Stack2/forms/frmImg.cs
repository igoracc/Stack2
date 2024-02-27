using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack2.forms
{




    public partial class frmImg : Form
    {
        public   Image img;

        public frmImg()
        {
            InitializeComponent();
        }

        private void frmImg_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = img;

            WindowState = FormWindowState.Maximized;

        }
    }
}
