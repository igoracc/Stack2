using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Stack2
{
    public partial class frmEditStav : Form
    {

        ClCrud clCrud = new ClCrud();

        public long CtegoryId;
        public long LanguageID;
        public int modus;
        public long ItemID;


        public frmEditStav()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {



            clCrud.AddEditItem(modus, CtegoryId, LanguageID, txtName.Text, txtDetails.Text, txtTags.Text, txtHyperlink.Text,0, ItemID);
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




        }
        private void gatherData(long idStav)
        {
            string sq = string.Format(@"
                              SELECT [Name]
                                      ,[Details]
                                      ,[Tags]
                                      ,[HyperLink]
                                      ,[Hidden]
                                      ,[DateCreated]
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

                ///txtHyperLink.Text = row.Field<string>("HyperLink");


            }




        }


    }


}