
namespace crud_basics
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockInput = new System.Windows.Forms.TextBox();
            this.priceabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.recordGrid = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.employeesLink = new System.Windows.Forms.LinkLabel();
            this.supplierLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockLabel.Location = new System.Drawing.Point(84, 181);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(105, 21);
            this.stockLabel.TabIndex = 16;
            this.stockLabel.Text = "Product Stock";
            // 
            // stockInput
            // 
            this.stockInput.Location = new System.Drawing.Point(220, 179);
            this.stockInput.Name = "stockInput";
            this.stockInput.Size = new System.Drawing.Size(167, 23);
            this.stockInput.TabIndex = 15;
            // 
            // priceabel
            // 
            this.priceabel.AutoSize = true;
            this.priceabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceabel.Location = new System.Drawing.Point(84, 127);
            this.priceabel.Name = "priceabel";
            this.priceabel.Size = new System.Drawing.Size(102, 21);
            this.priceabel.TabIndex = 14;
            this.priceabel.Text = "Product Price";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(84, 75);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(97, 21);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Product Title";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(220, 127);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(167, 23);
            this.priceInput.TabIndex = 12;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(220, 77);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(167, 23);
            this.titleInput.TabIndex = 11;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(84, 32);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(83, 21);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "Product ID";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(220, 34);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(167, 23);
            this.idInput.TabIndex = 17;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(189, 456);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 20;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // recordGrid
            // 
            this.recordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordGrid.Location = new System.Drawing.Point(26, 275);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.RowTemplate.Height = 25;
            this.recordGrid.Size = new System.Drawing.Size(434, 162);
            this.recordGrid.TabIndex = 19;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(355, 230);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(252, 230);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(154, 230);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(57, 230);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 21;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // employeesLink
            // 
            this.employeesLink.AutoSize = true;
            this.employeesLink.Location = new System.Drawing.Point(12, 9);
            this.employeesLink.Name = "employeesLink";
            this.employeesLink.Size = new System.Drawing.Size(64, 15);
            this.employeesLink.TabIndex = 25;
            this.employeesLink.TabStop = true;
            this.employeesLink.Text = "Employees";
            this.employeesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.employeesLink_LinkClicked);
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(84, 9);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(50, 15);
            this.supplierLabel.TabIndex = 26;
            this.supplierLabel.TabStop = true;
            this.supplierLabel.Text = "Supplier";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 482);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.employeesLink);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.recordGrid);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.stockInput);
            this.Controls.Add(this.priceabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.titleInput);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox stockInput;
        private System.Windows.Forms.Label priceabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView recordGrid;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.LinkLabel employeesLink;
        private System.Windows.Forms.LinkLabel supplierLabel;
    }
}