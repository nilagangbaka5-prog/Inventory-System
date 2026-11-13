namespace Inventory_System
{
    partial class EditItemForm
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
            lblTitle = new Label();
            lblName = new Label();
            txtItemName = new MaskedTextBox();
            lblCategory = new Label();
            txtCategory = new MaskedTextBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            btnUpdate = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit Item";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(12, 81);
            lblName.Name = "lblName";
            lblName.Size = new Size(77, 19);
            lblName.TabIndex = 1;
            lblName.Text = "Item Name";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(12, 103);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(282, 23);
            txtItemName.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.Location = new Point(12, 139);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 19);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(12, 161);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(282, 23);
            txtCategory.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.Location = new Point(12, 198);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 19);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(12, 220);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 6;
            numPrice.ThousandsSeparator = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10F);
            lblQuantity.Location = new Point(12, 258);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(63, 19);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(12, 280);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(21, 345);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "UPDATE ITEM";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(156, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 44);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(316, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(numPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtItemName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "EditItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Price";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private MaskedTextBox txtItemName;
        private Label lblCategory;
        private MaskedTextBox txtCategory;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Button btnUpdate;
        private Button btnCancel;
    }
}