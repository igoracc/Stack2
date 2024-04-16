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
    public partial class frmClipboard1 : Form
    {
        ClCrud clCrud = new ClCrud();

        string query = "";
        long categoryID = 0;    

        public long LangID ;

        public frmClipboard1()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            getData( );
            getID();

        }

        private void getData()
        {
            query = @" SELECT  id,datum,text,opis FROM [clipboard]   ";

 
            if (txtSearch.Text !="")
            {
                query = query + " AND text LIKE '%" + txtSearch.Text + "%' ";
            }

            query += "  ORDER BY datum desc ";


            bsCategories.DataSource = clCrud.GetDataTableSQL(query);

            categoryID = getID();

        }


        private long getID()
        {

            if (bsCategories.Count > 0 && bsCategories.Position <= dgCategory.Rows.Count && bsCategories.Position != 0)
            {

                /// txtName.Text = dgCategory.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    return Convert.ToInt64(dgCategory.CurrentRow.Cells[0].Value.ToString());

                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                return 0;
            }
        }

        private void dgCategory_SelectionChanged(object sender, EventArgs e)
        {
            getID();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmEditStav frm = new frmEditStav();

            frm.txtDetails.Text = txtDescriptions.Text;
            frm.ShowDialog();



        }

        private void bsCategories_CurrentChanged(object sender, EventArgs e)
        {

            if (bsCategories.Count > 0 && bsCategories.Position <= dgCategory.Rows.Count && bsCategories.Position != -1)
            {

                txtDescriptions.Text = dgCategory.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                txtDescriptions.Text = "";
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
