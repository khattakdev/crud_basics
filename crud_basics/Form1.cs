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
            int i = sqlCmd.ExecuteNonQuery();

            if(i > 0)
            {
                MessageBox.Show("Record Added!");
            } else
            {
                MessageBox.Show("Unable to Add Record!");
            }

            sqlCon.Close();


        }
    }
}
