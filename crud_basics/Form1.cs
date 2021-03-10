using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_basics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string email = emailInput.Text;
            string conn = "Data Source=DESKTOP-URS2I8O;Initial Catalog=crud;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(conn);
            string query = "INSERT INTO EMPLOYEES (NAME, EMAIL) VALUES('" + name + "','" + email + "')";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();

            if (sqlCmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Record Added!");
            }
            else
            {
                MessageBox.Show("Unable to Add Record!");
            }

            sqlCon.Close();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            string name = nameInput.Text;
            string conn = "Data Source=DESKTOP-URS2I8O;Initial Catalog=crud;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(conn);
            string query = "SELECT * FROM EMPLOYEES WHERE NAME='" + name + "'";
            sqlCon.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlCon);
            DataTable dt = new DataTable();

            sqlAdapter.Fill(dt);
            sqlCon.Close();

            if (dt != null)
            {

                nameInput.Text = dt.Rows[0]["Name"].ToString(); 
                emailInput.Text = dt.Rows[0]["Email"].ToString();
            }
            else
            {
                MessageBox.Show("Record not found.");
            }

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string conn = "Data Source=DESKTOP-URS2I8O;Initial Catalog=crud;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(conn);
            string query = "SELECT * FROM EMPLOYEES";
            sqlCon.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlCon);
            DataSet ds = new DataSet();

            sqlAdapter.Fill(ds, "Employees");
            recordGrid.DataSource = ds.Tables["Employees"].DefaultView;

            sqlCon.Close();

            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string email = emailInput.Text;
            string conn = "Data Source=DESKTOP-URS2I8O;Initial Catalog=crud;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(conn);
            string query = "UPDATE EMPLOYEES SET EMAIL='" + email + "' WHERE NAME='" + name + "'";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();

            if (sqlCmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Record Updated!");
            }
            else
            {
                MessageBox.Show("Unable to Update Record!");
            }

            sqlCon.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string email = emailInput.Text;
            string conn = "Data Source=DESKTOP-URS2I8O;Initial Catalog=crud;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(conn);
            string query = "DELETE FROM EMPLOYEES WHERE NAME='" + name + "'";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();

            if (sqlCmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Record Deleted!");
            }
            else
            {
                MessageBox.Show("Unable to Delete Record!");
            }

            sqlCon.Close();
        }
    }
}
