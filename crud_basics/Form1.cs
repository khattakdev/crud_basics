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

        DBCon conn = new DBCon("Data Source=DESKTOP-URS2I8O;Initial Catalog=crud;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string email = emailInput.Text;
            if (conn.UDI("INSERT INTO EMPLOYEES (NAME, EMAIL) VALUES('" + name + "','" + email + "')"))
            {
                MessageBox.Show("Record Added!");
            }
            else
            {
                MessageBox.Show("Unable to Add Record!");

            }


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            string name = nameInput.Text;

            DataTable dt = conn.Search("SELECT * FROM EMPLOYEES WHERE NAME='" + name + "'");

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
            
            DataSet ds = conn.View("SELECT * FROM EMPLOYEES");

            recordGrid.DataSource = ds.Tables[0].DefaultView;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string email = emailInput.Text;
            if (conn.UDI("UPDATE EMPLOYEES SET EMAIL='" + email + "' WHERE NAME='" + name + "'"))
            {
                MessageBox.Show("Record Added!");
            }
            else
            {
                MessageBox.Show("Unable to Add Record!");

            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            if (conn.UDI("DELETE FROM EMPLOYEES WHERE NAME = '" + name + "'"))
            {
                MessageBox.Show("Record Deleted!");
            }
            else
            {
                MessageBox.Show("Unable to Delete Record!");

            }
        }
    }
}
