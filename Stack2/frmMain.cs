﻿using Stack2.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Stack2
{


    public partial class frmMain : Form
    {
        static ClCrud clCrud = new ClCrud();

        string query = "";
        long categoryID=0, ItemId=0;
        long LangId = 0;
        Boolean fillStart = false;
        int image = 0;
        string clipboardText = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clCrud.OpenConnection();

            FillCOmbo();

            getCategories(LangId);

            ItemId = GetItemId();
            fillDetailsAboutItem(ItemId);

            this.WindowState = FormWindowState.Maximized;

            timer1.Enabled = true;


        }

        private void FillCOmbo ()
        {
            query = @" SELECT Naziv from [ProgrammingLanguage] ";

            DataTable dt = new DataTable();
            dt = clCrud.GetDataTableSQL(query);


            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "Naziv";

        }


        private void getCategories(long LangId )
        {
            query = @" SELECT Categories.ID
                      ,Categories.Name
					  FROM Categories 
					  LEFT JOIN Items ON Items.CategoryID = Categories.ID
					  
					  WHERE isnull(Categories.hidden,0)=0  AND isnull(Items.hidden,0)=0 
                            AND Categories.LanguageID = " + LangId + " ";


           /// query = @" SELECT  ID, Name, IsImage from Items WHERE Hidden =  0 AND CategoryID =  " + CategoryID;


            if (chkAllWord.Checked)
            {
                string findWords = txtSearch.Text;


                string[] words = findWords.Split(new char[] { ' ', ',', ';', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    query += " AND Items.Details + Items.Tags + Items.Name LIKE '%" + word + "%'";
                }

            }
            else
            {

                if (chkDetails.Checked)
                {
                    query = query + " AND Items.Details LIKE '%" + txtSearch.Text + "%' ";
                }

            }



            query += " GROUP BY Categories.ID ,Categories.Name ORDER BY Categories.Name";


            bsCategories.DataSource = clCrud.GetDataTableSQL(query);

            categoryID = getCategoryID();
            getItems(categoryID);

        }

        private long getCategoryID ()
        {

            if (bsCategories.Count > 0 && bsCategories.Position <= dgCategory.Rows.Count && bsCategories.Position != -1)
            {

                return Convert.ToInt64(dgCategory.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                return 0;
            }
        }

        private long GetItemId()
        {
            image = 0;
            if (bsItems.Count > 0 && bsItems.Position <= dgItems.Rows.Count && bsItems.Position != -1)

            {

                try
                {
                    image = Convert.ToInt16(dgItems.CurrentRow.Cells[2].Value.ToString());
                }
                catch (Exception)
                {

                   /// throw;
                }

                return Convert.ToInt64(dgItems.CurrentRow.Cells[0].Value.ToString());

            }
            else
            {
                image = 0;
                return 0;
            }
        }



        private void bsCategories_PositionChanged(object sender, EventArgs e)
        {
            //categoryID =getCategoryID();
            //getItems(categoryID);
        }

        private void bsItems_PositionChanged(object sender, EventArgs e)
        {
            //txtDetails.Clear();
            //txtTags.Clear();

            //ItemId = GetItemId();
            //fillDetailsAboutItem(ItemId);

        }

        private void fillDetailsAboutItem(long ItemID = 0)
        {
            if (ItemID != 0 )
            {
                txtDetails.Text = clCrud.ExecuteScalarSQL("SELECT Details FROM Items WHERE ID = " + ItemId).ToString();
                txtTags.Text = clCrud.ExecuteScalarSQL("SELECT Tags FROM Items WHERE ID = " + ItemId).ToString();

                if (image != 0)
                {
                    pictureBox1.Image = clCrud.GetImageFromStavke(ItemID);
                    pictureBox1.BringToFront();
                    showImage.Enabled = true;
                }

                else
                {
                    pictureBox1.SendToBack();
                    showImage.Enabled = false;
                }


            }
            else
            {
                txtDetails.Text = "";
                txtTags.Text = "";
            }

        }

        private void dgCategory_SelectionChanged(object sender, EventArgs e)
        {
            categoryID = getCategoryID();
            getItems(categoryID);
        }

        private void dgItems_SelectionChanged(object sender, EventArgs e)
        {

            ItemId = GetItemId();
            fillDetailsAboutItem(ItemId);
        }

        private void dgCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //getCategoryID();
            //getItems(categoryID);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bsItems_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LangId = Convert.ToInt16(clCrud.ExecuteScalarSQL("SELECT ID FROM [ProgrammingLanguage] WHERE Naziv ='" + comboBox1.Text + "'"));
            getCategories(LangId);


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmEditStav fr = new frmEditStav();

            fr.LanguageID = LangId;
            fr.CategoryId = categoryID;
            fr.modus = 1;

            fr.ShowDialog();

            getItems(categoryID);


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmEditStav fr = new frmEditStav();

            fr.LanguageID = LangId;
            fr.CategoryId = categoryID;
            fr.modus = 2;

            fr.ItemID = ItemId;

            fr.ShowDialog();

            getItems(categoryID);
        }

        private void dgItems_SelectionChanged_1(object sender, EventArgs e)
        {
            ItemId = GetItemId();
            fillDetailsAboutItem(ItemId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillStart = false;
            getItems(categoryID);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(this, e);

        }

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(this, e);
        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(this, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            clCrud.UpdateItem(txtDetails.Text, txtTags.Text, ItemId);

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            string linkDesc = "";

            linkDesc = clCrud.GetValue("HyperLink", "Items", "ID", ItemId.ToString(), "").ToString();


            System.Diagnostics.Process.Start(linkDesc );


        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            frmCategories form = new frmCategories();

            form.LangID = LangId;

            form.ShowDialog();

            getCategories(LangId);

        }

        private void tsBtnImage_Click(object sender, EventArgs e)
        {
            frmEditStav fr = new frmEditStav();

            fr.LanguageID = LangId;
            fr.CategoryId = categoryID;
            fr.modus = 4;

            fr.ShowDialog();

            getItems(categoryID);

        }

        private void txtDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                
                toolStripButton4_Click(this, e);

            }
        }

        private void dgItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgCategory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bsCategories_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (  Clipboard.GetText(TextDataFormat.Text) != clipboardText)
            {
                clipboardText = Clipboard.GetText(TextDataFormat.Text);
                clCrud.InsertClipboardText(clipboardText);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnCLipBoard.Text == "CPB OFF")
            {
                timer1.Enabled = false;
                btnCLipBoard.Text = "CPB ON";

            }
            else
            {
                timer1.Enabled = true;
                btnCLipBoard.Text = "CPB OFF";
            }
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {

            frmImg frm = new frmImg();
            frm.img = pictureBox1.Image;

            frm.ShowDialog();

        }

        private void getItems(long CategoryID = 0,  long findID=0)
        {

            if (chkDetails.Checked || chkAllWord.Checked)
            {
                if(fillStart == false)
                {
                    fillStart = true;
                    getCategories(LangId);

                }


            }


            query = @" SELECT  ID, Name, IsImage from Items WHERE Hidden =  0 AND CategoryID =  " + CategoryID;


            if (chkAllWord.Checked )
            {



                string findWords = txtSearch.Text;


                string[] words = findWords.Split(new char[] { ' ', ',', ';', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    query += " AND Details + Tags + Name LIKE '%" + word + "%'";
                }


            }
            else
            {

                if (chkTags.Checked)
                {
                    if (chkDetails.Checked)
                    {
                        query += " AND Details + Tags + Name LIKE '%" + txtSearch.Text + "%'";
                    }
                    else
                    {
                        query += " AND tags + Name LIKE '%" + txtSearch.Text + "%'";
                    }

                }
                else
                {
                    if (chkDetails.Checked)
                    {
                        query += " AND Details + Name LIKE '%" + txtSearch.Text + "%'";
                    }
                    else
                    {
                        query += " AND Name LIKE '%" + txtSearch.Text + "%'";
                    }

                }

            }



            if (rbAsc.Checked)
            {
                query += " ORDER BY Name";
            }
            else
            {
                query += " ORDER BY DateCreated ";
            }

                bsItems.DataSource = clCrud.GetDataTableSQL(query);
                ItemId = GetItemId();   
        }






    }
}
