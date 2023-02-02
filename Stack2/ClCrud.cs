using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Stack2
{
    public class ClCrud
    {

        private static SqlConnection dbCon = new SqlConnection();
        private static string constr = @"Server=WORKSTATION\SQL;Database=IGIS;User Id = igor; Password=1234567;";
        private Boolean fillStart;

        public void OpenConnection()
        {
            dbCon = new SqlConnection(constr);

            try
            {
                if (dbCon.State != ConnectionState.Open)
                {
                    dbCon.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int ExecuteNonQuerySQL(string cSql)
        {

            if (dbCon.State == ConnectionState.Closed)
                dbCon.Open();

            int i = 0;
            SqlCommand cmd = new SqlCommand(cSql, dbCon);

            i = cmd.ExecuteNonQuery();

            return i;

        }
        public object ExecuteScalarSQL(string cSql)
        {

            if (dbCon.State == ConnectionState.Closed)
                dbCon.Open();

            Object o = new object();

            SqlCommand cmd = new SqlCommand(cSql, dbCon);

            o = cmd.ExecuteScalar();
            return o;

        }


        public DataTable GetDataTableSQL(string cSql)

        {
            if (dbCon.State == ConnectionState.Closed)
                dbCon.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cSql, dbCon);

            da.Fill(dt);
            return dt;


        }

        public string cipher(string table, string format)
        {
            long ciphra = 1;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT MAX ( cipher ) + 1 FROM " + table + " WHERE isnull(deleted,0)=0 ";
            cmd.Connection = dbCon;

            ciphra = Convert.ToInt64(cmd.ExecuteScalar());

            string result = ciphra.ToString("D4");

            return result;

        }

        public DataSet LoadData(string Query) //get data using sql query
        {

            try
            {
                DataSet ds = new DataSet();

                    SqlCommand cmd = new SqlCommand(Query, dbCon);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(ds);
                    }

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long AddEditItem (int modus,long CategoryID, long LanguageID, string Name, string Details, string Tags,string HyperLink, int IsImage = 0 , long ID = 0 )
        {

             long n = 0;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbCon;

            if (modus == 1)
            {


                cmd.CommandText = @"INSERT INTO [dbo].[Items]
                                                       ([CategoryID]
                                                       ,[LanguageID]
                                                       ,[Name]
                                                       ,[Details]
                                                       ,[Tags]
                                                       ,[HyperLink]
                                                       ,[Hidden]
                                                       ,[IsImage])
                                                         VALUES  (

                                                        @CategoryID,
                                                        @LanguageID,
                                                        @Name,
                                                        @Details,
                                                        @Tags,
                                                        @HyperLink,
                                                        0,
                                                        @IsImage
                                                        );

                                    SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];  

            ";

            }
            else
            {

                cmd.CommandText = @"UPDATE  [Items] SET
                                                       [CategoryID] = @CategoryID,
                                                       [LanguageID] = @LanguageID,
                                                       [Name]       = @Name,
                                                       [Details]    = @Details,
                                                       [Tags]       = @Tags,
                                                       [HyperLink]  = @HyperLink,
                                                       [IsImage]    = @IsImage

                                    WHERE ID = @ID 
                        ";

                cmd.Parameters.AddWithValue("@ID", ID);
            }



            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            cmd.Parameters.AddWithValue("@LanguageID", LanguageID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Details", Details);
            cmd.Parameters.AddWithValue("@Tags", Tags);
            cmd.Parameters.AddWithValue("@HyperLink", HyperLink);
            cmd.Parameters.AddWithValue("@IsImage", IsImage);


            try
            {
                if (modus == 1)
                {
                    n = Convert.ToUInt32(cmd.ExecuteScalar());
                }
                else
                {
                    cmd.ExecuteNonQuery();  
                }

               // n = 1;
            }
            catch (Exception)
            {
                n = 0;
                //throw;
            }

            return n;




        }

        public void MessageShow( string messagetxt)
        {
            MessageBox.Show(messagetxt);
        }


        public long UpdateItem( string Details, string Tags,  long ID)
        {
            long n = 1;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbCon;


                cmd.CommandText = @"UPDATE  [Items] SET

                                                       [Details]    = @Details,
                                                       [Tags]       = @Tags

                                    WHERE ID = @ID 
                        ";

                cmd.Parameters.AddWithValue("@ID", ID);


            cmd.Parameters.AddWithValue("@Details", Details);
            cmd.Parameters.AddWithValue("@Tags", Tags);


            try
            {
                    cmd.ExecuteNonQuery();
 
            }
            catch (Exception)
            {
                n = 0;
                //throw;
            }

            return n;

        }

    }
}
