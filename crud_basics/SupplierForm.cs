using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace crud_basics
{
    public partial class SupplierForm : Form
    {
        DBCon conn = new DBCon();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string email = emailInput.Text;
            string item = itemInput.Text;
            if (conn.UDI("INSERT INTO SUPPLIERS (NAME, EMAIL, ITEM) VALUES('" + name + "','" + email + "','" + item + "')"))
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

            DataTable dt = conn.Search("SELECT * FROM SUPPLIERS WHERE ID='" + id + "'");

            if (dt != null)
            {

                nameInput.Text = dt.Rows[0]["Name"].ToString();
                emailInput.Text = dt.Rows[0]["Email"].ToString();
                itemInput.Text = dt.Rows[0]["Item"].ToString();
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string id = idInput.Text;
            string name = nameInput.Text;
            string email = emailInput.Text;
            string item = itemInput.Text;
            if (conn.UDI("UPDATE SUPPLIERS SET EMAIL='" + email + "', NAME='" + name + "', ITEM='" + item + "' WHERE ID='" + id + "'"))
            {
                MessageBox.Show("Record Added!");
            }
            else
            {
                MessageBox.Show("Unable to Add Record!");

            }

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = conn.View("SELECT * FROM SUPPLIERS");

            recordGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = idInput.Text;
            if (conn.UDI("DELETE FROM SUPPLIERS WHERE ID = '" + id + "'"))
            {
                MessageBox.Show("Record Deleted!");
            }
            else
            {
                MessageBox.Show("Unable to Delete Record!");

            }

        }

        private void productLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProductForm prodForm = new ProductForm();
            prodForm.Show();
        }

        private void employeesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
        }
    }
}
