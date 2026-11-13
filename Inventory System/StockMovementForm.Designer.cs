namespace Inventory_System
{
    partial class StockMovementForm
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
            lblItem = new Label();
            lblType = new Label();
            cmbItem = new ComboBox();
            cmbType = new ComboBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock Movement";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Segoe UI", 12F);
            lblItem.Location = new Point(12, 72);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(86, 21);
            lblItem.TabIndex = 1;
            lblItem.Text = "Select Item";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 12F);
            lblType.Location = new Point(12, 134);
            lblType.Name = "lblType";
            lblType.Size = new Size(121, 21);
            lblType.TabIndex = 2;
            lblType.Text = "Movement Type";
            // 
            // cmbItem
            // 
            cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(12, 96);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(342, 23);
            cmbItem.TabIndex = 3;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(12, 158);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(342, 23);
            cmbType.TabIndex = 4;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F);
            lblQuantity.Location = new Point(12, 200);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 21);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(12, 224);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(161, 23);
            numQuantity.TabIndex = 6;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(44, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 44);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(191, 277);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 44);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // StockMovementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 390);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbType);
            Controls.Add(cmbItem);
            Controls.Add(lblType);
            Controls.Add(lblItem);
            Controls.Add(lblTitle);
            Name = "StockMovementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "z`";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblItem;
        private Label lblType;
        private ComboBox cmbItem;
        private ComboBox cmbType;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Button btnSave;
        private Button btnCancel;
    }
}