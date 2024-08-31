using FastColoredTextBoxNS;
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
    public partial class frmCategories : Form
    {
        ClCrud clCrud = new ClCrud();

        string query = "";
        long categoryID = 0;    

        public long LangID ;

        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {

            fillCBOLang();

            getCategories(LangID );


        }

        private void getCategories(long LangId)
        {
            query = @" SELECT Categories.ID
                      ,Categories.Name
					  FROM Categories 
					  WHERE isnull(Categories.hidden,0)=0   ";



            if (txtSearch.Text != "")
            {
                query = query + " AND Categories.Name LIKE '%" + txtSearch.Text + "%' ";
            }



            query += "  ORDER BY Categories.Name ";


            bsCategories.DataSource = clCrud.GetDataTableSQL(query);

            categoryID = getCategoryID();

        }


        private void fillCBOLang()
        {
            string query = "";
            query = " SELECT  naziv from ProgrammingLanguage ";

            DataTable dt = new DataTable();
            dt = clCrud.GetDataTableSQL(query);


            cboLang.DataSource = dt;
            cboLang.DisplayMember = "naziv";
            cboLang.ValueMember = "naziv";

            cboLang.SelectedValue = clCrud.ExecuteScalarSQL("SELECT naziv from ProgrammingLanguage WHERE ID =" + LangID);
        }
        private long getCategoryID()
        {

            if (bsCategories.Count > 0 && bsCategories.Position <= dgCategory.Rows.Count && bsCategories.Position != -1)
            {

                txtName.Text = dgCategory.CurrentRow.Cells[1].Value.ToString();

                return Convert.ToInt64(dgCategory.CurrentRow.Cells[0].Value.ToString());

            }
            else
            {
                return 0;
            }
        }

        private void dgCategory_SelectionChanged(object sender, EventArgs e)
        {
            getCategoryID();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            LangID = Convert.ToInt64(clCrud.ExecuteScalarSQL("  SELECT ID FROM ProgrammingLanguage WHERE naziv = '" + cboLang.Text + "'"));




            string cmdtext = "INSERT INTO Categories (Name,hidden, LanguageID) VALUES ('" + txtName.Text + "' , 0, "+ LangID + " )";

            clCrud.ExecuteNonQuerySQL(cmdtext);

            getCategories(LangID);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCategories(LangID);
        }
    }
}
