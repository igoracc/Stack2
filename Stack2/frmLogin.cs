using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == "2022" )
            {
                frmMain form = new frmMain();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong password");
            }




        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnOk.Focus();
            }
        }
    }
}
