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
    public partial class EmployeeForm : Form
    {

        DBCon conn = new DBCon();
        public EmployeeForm()
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

            string id = idInput.Text;

            DataTable dt = conn.Search("SELECT * FROM EMPLOYEES WHERE ID='" + id + "'");

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
            
            DataTable dt = conn.Search("SELECT * FROM EMPLOYEES");

            recordGrid.DataSource = dt;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string id = idInput.Text;
            string name = nameInput.Text;
            string email = emailInput.Text;
            if (conn.UDI("UPDATE EMPLOYEES SET EMAIL='" + email + "', NAME='" + name + "' WHERE ID='" + id + "'"))
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

            string id = idInput.Text;
            if (conn.UDI("DELETE FROM EMPLOYEES WHERE ID = '" + id + "'"))
            {
                MessageBox.Show("Record Deleted!");
            }
            else
            {
                MessageBox.Show("Unable to Delete Record!");

            }
        }

        private void productsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProductForm prodForm = new ProductForm();
            prodForm.Show();
        }

        private void supplierLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SupplierForm supForm = new SupplierForm();
            supForm.Show();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
