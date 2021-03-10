using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace crud_basics
{
    public partial class ProductForm : Form
    {
        DBCon conn = new DBCon();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string title = titleInput.Text;
            string price = priceInput.Text;
            string stock = stockInput.Text;
            if (conn.UDI("INSERT INTO PRODUCTS (TITLE, PRICE, STOCK) VALUES('" + title + "','" + price + "','" + stock + "')"))
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

            DataTable dt = conn.Search("SELECT * FROM PRODUCTS WHERE ID='" + id + "'");

            if (dt != null)
            {

                titleInput.Text = dt.Rows[0]["Title"].ToString();
                priceInput.Text = dt.Rows[0]["Price"].ToString();
                stockInput.Text = dt.Rows[0]["Stock"].ToString();
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string id = idInput.Text;
            string title = titleInput.Text;
            string price = priceInput.Text;
            string stock = stockInput.Text;
            if (conn.UDI("UPDATE PRODUCTS SET TITLE='" + title+ "', PRICE='" + price+ "', STOCK='" + stock + "' WHERE ID='" + id + "'"))
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
            DataSet ds = conn.View("SELECT * FROM PRODUCTS");

            recordGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = idInput.Text;
            if (conn.UDI("DELETE FROM PRODUCTS WHERE ID = '" + id + "'"))
            {
                MessageBox.Show("Record Deleted!");
            }
            else
            {
                MessageBox.Show("Unable to Delete Record!");

            }
        }

        private void employeesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
        }

        private void supplierLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SupplierForm supForm = new SupplierForm();
            supForm.Show();
        }
    }
}
