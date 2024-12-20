﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            query = @" SELECT  TOP 50 id,datum,text as Tekst,opis FROM [clipboard]   ";

 
            if (txtSearch.Text !="")
            {
                query = query + " WHERE  text LIKE '%" + txtSearch.Text + "%' ";
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

            frm.modus = 1;
            frm.txtDetails.Text = txtDescriptions.Text;
            frm.ShowDialog();


            // ovdje bi bilo dobro nekad napraviti vezu stavke i cpb elementa


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

        private void dgCategory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;    
        }

        private void dgCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is clicked
            {
                DataGridViewRow row = dgCategory.Rows[e.RowIndex];
                string text = row.Cells["Tekst"].Value.ToString(); // Replace "ColumnName" with the actual column name in your DataGridView
                txtDescriptions.Text = text; // Display the text in the TextBox
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getData();
            }
        }

        private void frmClipboard1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
                this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmEditStav frm = new frmEditStav();

            frm.modus = 1;
            frm.txtDetails.Text = txtDescriptions.Text;
            frm.ShowDialog();

            if (frm.ItemID!=0)
            {

                clCrud.ExecuteNonQuerySQL("UPDATE [clipboard] SET ItemID = " + frm.ItemID + " WHERE ID = " + dgCategory.CurrentRow.Cells[0].Value.ToString() );



            }


        }
    }
}
