namespace Inventory_System
{
    partial class AddItemForm
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
            txtName = new Label();
            lblname = new Label();
            txtItemName = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(12, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 40);
            txtName.TabIndex = 0;
            txtName.Text = "\tADD NEW ITEM";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 12F);
            lblname.Location = new Point(12, 87);
            lblname.Name = "lblname";
            lblname.Size = new Size(87, 21);
            lblname.TabIndex = 1;
            lblname.Text = "Item Name";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(12, 111);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(281, 23);
            txtItemName.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(12, 146);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(131, 21);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Product Category";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(12, 170);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(281, 23);
            txtCategory.TabIndex = 4;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F);
            lblQuantity.Location = new Point(12, 209);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 21);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(12, 233);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.Location = new Point(12, 269);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 21);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(12, 293);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 8;
            numPrice.ThousandsSeparator = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(12, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 44);
            btnSave.TabIndex = 9;
            btnSave.Text = "ADD";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(163, 353);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 44);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(305, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numPrice);
            Controls.Add(lblPrice);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtItemName);
            Controls.Add(lblname);
            Controls.Add(txtName);
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Item";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtName;
        private Label lblname;
        private TextBox txtItemName;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}