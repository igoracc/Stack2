using FastColoredTextBoxNS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.WebRequestMethods;

namespace Stack2
{
    public partial class frmEditStav : Form
    {

        ClCrud clCrud = new ClCrud();

        public long CategoryId;
        public long LanguageID;
        public int modus;
        public long ItemID;


        public frmEditStav()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("There is no name inserted!!");
                return; 
            }


            if (txtTags.Text == "")
            {
                MessageBox.Show("There is no tags!!");
                return;
            }



            CategoryId = Convert.ToInt64(clCrud.ExecuteScalarSQL("  SELECT ID FROM Categories WHERE name = '" + cboCategory.Text + "' AND Hidden = 0"));

            if (CategoryId == 0 )
            {
                /// CategoryId = Convert.ToInt64( clCrud.ExecuteScalarSQL("INSERT"  );

                MessageBox.Show("There is no category in selected");
                return;

            }

            LanguageID = Convert.ToInt64(clCrud.ExecuteScalarSQL("  SELECT ID FROM ProgrammingLanguage WHERE naziv = '" + cboLang.Text + "'"));


            if (modus != 4)
            {
                if (modus == 1)
                {
                    txtDetails.Text = DateTime.Now.ToString() + "\n" + txtDetails.Text; 
                }
                clCrud.AddEditItem(modus, CategoryId, LanguageID, txtName.Text, txtDetails.Text, txtTags.Text, txtHyperlink.Text, 0, ItemID);

                if (modus == 1)
                {
                    ItemID =Convert.ToInt64(  clCrud.GetValue("MAX(ID)", "Items", "0", "0"));
                }

            }
            else
            {
                clCrud.AddEditItem(modus, CategoryId, LanguageID, txtName.Text, txtDetails.Text, txtTags.Text, txtHyperlink.Text, 0, ItemID, pictureBox1.Image);
            }




            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditStav_Load_1(object sender, EventArgs e)
        {
            
            
            
            
            if (modus == 1)
            {
                this.Text = "New item";
               
            }
            else if (modus == 2)
            {
                this.Text = "Edit item";
                gatherData(ItemID);
            }
            else if (modus == 3)
            {
                this.Text = "Delete item";
                gatherData(ItemID);
            }
            else if (modus == 4)
            {
                try
                {
                    pictureBox1.BringToFront();

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    pictureBox1.Image = Clipboard.GetImage();

                    btnGetImage.Visible = true;
                }
                catch (Exception)
                {
                }



            }


                fillCBOLang(LanguageID);

            fillCBOCategory();

        }


        private void fillCBOLang (long lagnID)
        {
            string query = "";
            query = " SELECT  naziv from ProgrammingLanguage ";

            DataTable dt = new DataTable();
            dt = clCrud.GetDataTableSQL(query);


            cboLang.DataSource = dt;
            cboLang.DisplayMember = "naziv";
            cboLang.ValueMember = "naziv";

            cboLang.SelectedValue = clCrud.ExecuteScalarSQL("SELECT naziv from ProgrammingLanguage WHERE ID =" + lagnID);
        }


        private void fillCBOCategory()
        {
            string query = "";
            query = " SELECT  name from Categories where Hidden = 0 AND LanguageID = " + LanguageID + " order by name ";

            DataTable dt = new DataTable();
            dt = clCrud.GetDataTableSQL(query);


            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Name";

            try
            {
                cboCategory.SelectedValue = clCrud.ExecuteScalarSQL("SELECT name FROM Categories WHERE ID =" + CategoryId);
            }
            catch (Exception)
            {

                ////throw;
            }


        }


        private void gatherData(long idStav)
        {
            string sq = string.Format(@"
                              SELECT [Name]
                                      ,[Details]
                                      ,[Tags]
                                      ,[HyperLink]
                                      ,[Hidden]
                                      ,cast ([DateCreated] as nvarchar) as [DateCreated]
                                      ,[IsImage]
                                  FROM [Items] WHERE ID =  {0}
                              ", idStav);



            DataTable dt = new DataTable();
            dt = clCrud.GetDataTableSQL(sq);

            foreach (DataRow row in dt.Rows)
            {

                txtName.Text = row.Field<string>("Name");

                txtTags.Text = row.Field<string>("Tags");
                txtDetails.Text = row.Field<string>("Details");
                txtHyperlink.Text = row.Field<string>("HyperLink");

                dtDateCreated.Text = row.Field<string>("DateCreated");

                ///txtHyperLink.Text = row.Field<string>("HyperLink");


            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {

            ///SELECT naziv from ProgrammingLanguage WHERE ID =
            ///
            LanguageID = Convert.ToInt32( clCrud.GetValue("ID", "ProgrammingLanguage", "naziv", cboLang.Text, LanguageID.ToString()));

            fillCBOCategory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Clipboard.GetImage();
        }

        private void txtDetails_Load(object sender, EventArgs e)
        {

        }

        private void txtDetails_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Tab)
            {
                button1.Focus();
            }

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTags.Focus();
            }
        }

        private void txtTags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDetails.Focus();
            }
        }

        private void frmEditStav_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }

                if(e.KeyCode == Keys.Control && e.KeyCode == Keys.S)
                {
                    button1_Click(this, e);
                }

        }

    }


}