using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace crud_basics
{
    class DBCon
    {

        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAdapter;
        public DBCon()
        {
            sqlCon = new SqlConnection("Data Source=DESKTOP-URS2I8O;Initial Catalog=crud;Integrated Security=True");
        }
        public DBCon(string conn)
        {
            sqlCon = new SqlConnection(conn);
        }

        public bool UDI(string query)
        {
            sqlCmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();
            bool hasAffectedRow = sqlCmd.ExecuteNonQuery() > 0;
            sqlCon.Close();

            if (hasAffectedRow)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public DataTable Search(string query)
        {

            sqlCon.Open();
            sqlAdapter = new SqlDataAdapter(query, sqlCon);
            DataTable dt = new DataTable();

            sqlAdapter.Fill(dt);
            sqlCon.Close();

            if (dt != null)
            {
                return dt;

            }
            else
            {
                return null;
            }
        }

        public DataSet View(string query)
        {
            sqlCon.Open();
            sqlAdapter = new SqlDataAdapter(query, sqlCon);
            DataSet ds = new DataSet();

            sqlAdapter.Fill(ds, "Employees");
            sqlCon.Close();

            if (ds != null)
            {
                return ds;
            }
            else
            {
                return null;
            }
        }
    }
}
