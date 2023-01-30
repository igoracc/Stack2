using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Stack2
{


    public partial class frmMain : Form
    {
        static ClCrud clCrud = new ClCrud();

        string query = "";
        long categoryID=0, ItemId=0;
        long LangId = 0;

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
            query = @" SELECT ID
                      ,Name
                      ,Hidden FROM Categories WHERE isnull(hidden,0)=0 AND LanguageID = " + LangId;

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

            if (bsItems.Count > 0 && bsItems.Position <= dgItems.Rows.Count && bsItems.Position != -1)

            {

                return Convert.ToInt64(dgItems.CurrentRow.Cells[0].Value.ToString());

            }
            else
            {
                return 0;
            }
        }



        private void bsCategories_PositionChanged(object sender, EventArgs e)
        {
            categoryID =getCategoryID();
            getItems(categoryID);
        }

        private void bsItems_PositionChanged(object sender, EventArgs e)
        {
            txtDetails.Clear();
            txtTags.Clear();

            ItemId = GetItemId();
            fillDetailsAboutItem(ItemId);

        }

        private void fillDetailsAboutItem(long ItemID = 0)
        {
            if (ItemID != 0 )
            {
                txtDetails.Text = clCrud.ExecuteScalarSQL("SELECT Details FROM Items WHERE ID = " + ItemId).ToString();
                txtTags.Text = clCrud.ExecuteScalarSQL("SELECT Tags FROM Items WHERE ID = " + ItemId).ToString();
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
            txtDetails.Clear();
            txtTags.Clear();

            ItemId = GetItemId();
            fillDetailsAboutItem(ItemId);
        }

        private void dgCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getCategoryID();
            getItems(categoryID);
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



        }

        private void getItems(long CategoryID = 0,  long findID=0)
        {
            query = @"   SELECT  ID, Name, IsImage from Items WHERE Hidden =  0 AND CategoryID =  " + CategoryID;


                bsItems.DataSource = clCrud.GetDataTableSQL(query);
               
                ItemId = GetItemId();   



        }






    }
}
