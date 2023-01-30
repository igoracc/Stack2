using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;

namespace Stack2
{
    public class ClCrud
    {

        private static SqlConnection dbCon = new SqlConnection();
        private static string constr = @"Server=WORKSTATION\SQL;Database=IGIS;User Id = igor; Password=1234567;";

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


    }
}
