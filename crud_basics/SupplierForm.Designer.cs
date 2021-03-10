
namespace crud_basics
{
    partial class SupplierForm
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
            this.productLink = new System.Windows.Forms.LinkLabel();
            this.employeesLink = new System.Windows.Forms.LinkLabel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.recordGrid = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productLink
            // 
            this.productLink.AutoSize = true;
            this.productLink.Location = new System.Drawing.Point(103, 11);
            this.productLink.Name = "productLink";
            this.productLink.Size = new System.Drawing.Size(54, 15);
            this.productLink.TabIndex = 56;
            this.productLink.TabStop = true;
            this.productLink.Text = "Products";
            this.productLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.productLink_LinkClicked);
            // 
            // employeesLink
            // 
            this.employeesLink.AutoSize = true;
            this.employeesLink.Location = new System.Drawing.Point(22, 11);
            this.employeesLink.Name = "employeesLink";
            this.employeesLink.Size = new System.Drawing.Size(64, 15);
            this.employeesLink.TabIndex = 55;
            this.employeesLink.TabStop = true;
            this.employeesLink.Text = "Employees";
            this.employeesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.employeesLink_LinkClicked);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(351, 271);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 54;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(248, 271);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 53;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(150, 271);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 52;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(53, 271);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 51;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(185, 497);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 50;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // recordGrid
            // 
            this.recordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordGrid.Location = new System.Drawing.Point(22, 316);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.RowTemplate.Height = 25;
            this.recordGrid.Size = new System.Drawing.Size(434, 162);
            this.recordGrid.TabIndex = 49;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(80, 73);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(87, 21);
            this.idLabel.TabIndex = 48;
            this.idLabel.Text = "Supplier ID";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(216, 75);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(167, 23);
            this.idInput.TabIndex = 47;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(80, 168);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(110, 21);
            this.emailLabel.TabIndex = 44;
            this.emailLabel.Text = "Supplier Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(80, 116);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(114, 21);
            this.nameLabel.TabIndex = 43;
            this.nameLabel.Text = "Supplier Name";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(216, 168);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(167, 23);
            this.emailInput.TabIndex = 42;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(216, 118);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(167, 23);
            this.nameInput.TabIndex = 41;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemLabel.Location = new System.Drawing.Point(84, 219);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(103, 21);
            this.itemLabel.TabIndex = 57;
            this.itemLabel.Text = "Supplier Item";
            // 
            // itemInput
            // 
            this.itemInput.Location = new System.Drawing.Point(216, 219);
            this.itemInput.Name = "itemInput";
            this.itemInput.Size = new System.Drawing.Size(167, 23);
            this.itemInput.TabIndex = 58;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 530);
            this.Controls.Add(this.itemInput);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.productLink);
            this.Controls.Add(this.employeesLink);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.recordGrid);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.nameInput);
            this.Name = "SupplierForm";
            this.Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel productLink;
        private System.Windows.Forms.LinkLabel employeesLink;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView recordGrid;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemInput;
    }
}