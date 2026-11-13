namespace Inventory_System
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            btnLogOut = new Button();
            btnStockMovement = new Button();
            btnViewItems = new Button();
            btnAddItem = new Button();
            btnDashboard = new Button();
            lblLogo = new Label();
            btnTitle = new Label();
            pnlTotalItems = new Panel();
            lblTotalItemsValue = new Label();
            lblTotalItemsTitle = new Label();
            pnlTotalQuantity = new Panel();
            lblTotalQuantityValue = new Label();
            pnlTotalQuantityTitle = new Label();
            pnlTotalCategories = new Panel();
            lblLowStockValue = new Label();
            lblLowStockTitle = new Label();
            pnlLowStock = new Panel();
            lblOutOfStockValue = new Label();
            lblOutOfStockTitle = new Label();
            pnlStockValue = new Panel();
            lblTotalCategoriesValue = new Label();
            lblTotalCategoriesTitle = new Label();
            pnlOutOfStock = new Panel();
            lblStockValueValue = new Label();
            lblStockValueTitle = new Label();
            dgvRestock = new DataGridView();
            colRestockName = new DataGridViewTextBoxColumn();
            colRestockQuantity = new DataGridViewTextBoxColumn();
            colSuggestedRestock = new DataGridViewTextBoxColumn();
            lblRestockTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlTotalItems.SuspendLayout();
            pnlTotalQuantity.SuspendLayout();
            pnlTotalCategories.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlStockValue.SuspendLayout();
            pnlOutOfStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestock).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.ActiveCaption;
            pnlSidebar.Controls.Add(btnLogOut);
            pnlSidebar.Controls.Add(btnStockMovement);
            pnlSidebar.Controls.Add(btnViewItems);
            pnlSidebar.Controls.Add(btnAddItem);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 468);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(3, 421);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(118, 35);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "LOG OUT";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnStockMovement
            // 
            btnStockMovement.FlatAppearance.BorderSize = 0;
            btnStockMovement.FlatStyle = FlatStyle.Flat;
            btnStockMovement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockMovement.Location = new Point(12, 218);
            btnStockMovement.Name = "btnStockMovement";
            btnStockMovement.Size = new Size(163, 45);
            btnStockMovement.TabIndex = 4;
            btnStockMovement.Text = "STOCK MOVEMENT";
            btnStockMovement.UseVisualStyleBackColor = true;
            btnStockMovement.Click += btnStockMovement_Click_1;
            // 
            // btnViewItems
            // 
            btnViewItems.FlatAppearance.BorderSize = 0;
            btnViewItems.FlatStyle = FlatStyle.Flat;
            btnViewItems.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewItems.Location = new Point(3, 182);
            btnViewItems.Name = "btnViewItems";
            btnViewItems.Size = new Size(135, 30);
            btnViewItems.TabIndex = 3;
            btnViewItems.Text = "VIEW ITEMS";
            btnViewItems.UseVisualStyleBackColor = true;
            btnViewItems.Click += btnViewItems_Click_1;
            // 
            // btnAddItem
            // 
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddItem.ForeColor = Color.Black;
            btnAddItem.Location = new Point(12, 138);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(118, 29);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "ADD ITEMS";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.ActiveCaption;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(20, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(118, 31);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(3, 19);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(197, 25);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "INVENTORY SYSTEM";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTitle
            // 
            btnTitle.AutoSize = true;
            btnTitle.BackColor = Color.Transparent;
            btnTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTitle.Location = new Point(225, 19);
            btnTitle.Name = "btnTitle";
            btnTitle.Size = new Size(166, 40);
            btnTitle.TabIndex = 1;
            btnTitle.Text = "Dashboard";
            // 
            // pnlTotalItems
            // 
            pnlTotalItems.BackColor = Color.White;
            pnlTotalItems.Controls.Add(lblTotalItemsValue);
            pnlTotalItems.Controls.Add(lblTotalItemsTitle);
            pnlTotalItems.Location = new Point(259, 90);
            pnlTotalItems.Name = "pnlTotalItems";
            pnlTotalItems.Size = new Size(185, 103);
            pnlTotalItems.TabIndex = 2;
            pnlTotalItems.Paint += pnlTotalItems_Paint;
            // 
            // lblTotalItemsValue
            // 
            lblTotalItemsValue.AutoSize = true;
            lblTotalItemsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalItemsValue.ForeColor = Color.FromArgb(30, 45, 80);
            lblTotalItemsValue.Location = new Point(72, 48);
            lblTotalItemsValue.Name = "lblTotalItemsValue";
            lblTotalItemsValue.Size = new Size(38, 45);
            lblTotalItemsValue.TabIndex = 1;
            lblTotalItemsValue.Text = "0";
            lblTotalItemsValue.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalItemsValue.Click += lblTotalItemsValue_Click;
            // 
            // lblTotalItemsTitle
            // 
            lblTotalItemsTitle.AutoSize = true;
            lblTotalItemsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalItemsTitle.ForeColor = Color.FromArgb(36, 87, 167);
            lblTotalItemsTitle.Location = new Point(47, 10);
            lblTotalItemsTitle.Name = "lblTotalItemsTitle";
            lblTotalItemsTitle.Size = new Size(94, 19);
            lblTotalItemsTitle.TabIndex = 0;
            lblTotalItemsTitle.Text = "TOTAL ITEMS";
            lblTotalItemsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotalQuantity
            // 
            pnlTotalQuantity.BackColor = Color.White;
            pnlTotalQuantity.Controls.Add(lblTotalQuantityValue);
            pnlTotalQuantity.Controls.Add(pnlTotalQuantityTitle);
            pnlTotalQuantity.Location = new Point(468, 90);
            pnlTotalQuantity.Name = "pnlTotalQuantity";
            pnlTotalQuantity.Size = new Size(185, 103);
            pnlTotalQuantity.TabIndex = 3;
            // 
            // lblTotalQuantityValue
            // 
            lblTotalQuantityValue.AutoSize = true;
            lblTotalQuantityValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalQuantityValue.ForeColor = Color.FromArgb(30, 45, 80);
            lblTotalQuantityValue.Location = new Point(73, 48);
            lblTotalQuantityValue.Name = "lblTotalQuantityValue";
            lblTotalQuantityValue.Size = new Size(38, 45);
            lblTotalQuantityValue.TabIndex = 1;
            lblTotalQuantityValue.Text = "0";
            // 
            // pnlTotalQuantityTitle
            // 
            pnlTotalQuantityTitle.AutoSize = true;
            pnlTotalQuantityTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlTotalQuantityTitle.ForeColor = Color.FromArgb(36, 87, 167);
            pnlTotalQuantityTitle.Location = new Point(37, 12);
            pnlTotalQuantityTitle.Name = "pnlTotalQuantityTitle";
            pnlTotalQuantityTitle.Size = new Size(118, 17);
            pnlTotalQuantityTitle.TabIndex = 0;
            pnlTotalQuantityTitle.Text = "TOTAL QUANTITY";
            pnlTotalQuantityTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotalCategories
            // 
            pnlTotalCategories.BackColor = Color.White;
            pnlTotalCategories.Controls.Add(lblLowStockValue);
            pnlTotalCategories.Controls.Add(lblLowStockTitle);
            pnlTotalCategories.Location = new Point(676, 90);
            pnlTotalCategories.Name = "pnlTotalCategories";
            pnlTotalCategories.Size = new Size(185, 103);
            pnlTotalCategories.TabIndex = 4;
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.AutoSize = true;
            lblLowStockValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockValue.ForeColor = Color.FromArgb(30, 45, 80);
            lblLowStockValue.Location = new Point(76, 48);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(38, 45);
            lblLowStockValue.TabIndex = 2;
            lblLowStockValue.Text = "0";
            lblLowStockValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockTitle.ForeColor = Color.FromArgb(36, 87, 167);
            lblLowStockTitle.Location = new Point(52, 11);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(87, 17);
            lblLowStockTitle.TabIndex = 1;
            lblLowStockTitle.Text = "LOW STOCK ";
            lblLowStockTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.Controls.Add(lblOutOfStockValue);
            pnlLowStock.Controls.Add(lblOutOfStockTitle);
            pnlLowStock.Location = new Point(259, 218);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(185, 103);
            pnlLowStock.TabIndex = 5;
            // 
            // lblOutOfStockValue
            // 
            lblOutOfStockValue.AutoSize = true;
            lblOutOfStockValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutOfStockValue.ForeColor = Color.FromArgb(30, 45, 80);
            lblOutOfStockValue.Location = new Point(72, 52);
            lblOutOfStockValue.Name = "lblOutOfStockValue";
            lblOutOfStockValue.Size = new Size(38, 45);
            lblOutOfStockValue.TabIndex = 2;
            lblOutOfStockValue.Text = "0";
            lblOutOfStockValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOutOfStockTitle
            // 
            lblOutOfStockTitle.AutoSize = true;
            lblOutOfStockTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutOfStockTitle.ForeColor = Color.FromArgb(36, 87, 167);
            lblOutOfStockTitle.Location = new Point(40, 14);
            lblOutOfStockTitle.Name = "lblOutOfStockTitle";
            lblOutOfStockTitle.Size = new Size(101, 17);
            lblOutOfStockTitle.TabIndex = 1;
            lblOutOfStockTitle.Text = "OUT OF STOCK";
            lblOutOfStockTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlStockValue
            // 
            pnlStockValue.BackColor = Color.White;
            pnlStockValue.Controls.Add(lblTotalCategoriesValue);
            pnlStockValue.Controls.Add(lblTotalCategoriesTitle);
            pnlStockValue.Location = new Point(468, 218);
            pnlStockValue.Name = "pnlStockValue";
            pnlStockValue.Size = new Size(185, 103);
            pnlStockValue.TabIndex = 6;
            // 
            // lblTotalCategoriesValue
            // 
            lblTotalCategoriesValue.AutoSize = true;
            lblTotalCategoriesValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCategoriesValue.ForeColor = Color.FromArgb(30, 45, 80);
            lblTotalCategoriesValue.Location = new Point(73, 52);
            lblTotalCategoriesValue.Name = "lblTotalCategoriesValue";
            lblTotalCategoriesValue.Size = new Size(38, 45);
            lblTotalCategoriesValue.TabIndex = 2;
            lblTotalCategoriesValue.Text = "0";
            lblTotalCategoriesValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCategoriesTitle
            // 
            lblTotalCategoriesTitle.AutoSize = true;
            lblTotalCategoriesTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCategoriesTitle.ForeColor = Color.FromArgb(36, 87, 167);
            lblTotalCategoriesTitle.Location = new Point(27, 14);
            lblTotalCategoriesTitle.Name = "lblTotalCategoriesTitle";
            lblTotalCategoriesTitle.Size = new Size(128, 17);
            lblTotalCategoriesTitle.TabIndex = 1;
            lblTotalCategoriesTitle.Text = "TOTAL CATEGORIES";
            lblTotalCategoriesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOutOfStock
            // 
            pnlOutOfStock.BackColor = Color.White;
            pnlOutOfStock.Controls.Add(lblStockValueValue);
            pnlOutOfStock.Controls.Add(lblStockValueTitle);
            pnlOutOfStock.Location = new Point(676, 218);
            pnlOutOfStock.Name = "pnlOutOfStock";
            pnlOutOfStock.Size = new Size(185, 103);
            pnlOutOfStock.TabIndex = 6;
            // 
            // lblStockValueValue
            // 
            lblStockValueValue.AutoSize = true;
            lblStockValueValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockValueValue.ForeColor = Color.FromArgb(30, 45, 80);
            lblStockValueValue.Location = new Point(76, 52);
            lblStockValueValue.Name = "lblStockValueValue";
            lblStockValueValue.Size = new Size(38, 45);
            lblStockValueValue.TabIndex = 2;
            lblStockValueValue.Text = "0";
            lblStockValueValue.TextAlign = ContentAlignment.MiddleCenter;
            lblStockValueValue.Click += lblStockValueValue_Click;
            // 
            // lblStockValueTitle
            // 
            lblStockValueTitle.AutoSize = true;
            lblStockValueTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockValueTitle.ForeColor = Color.FromArgb(36, 87, 167);
            lblStockValueTitle.Location = new Point(46, 14);
            lblStockValueTitle.Name = "lblStockValueTitle";
            lblStockValueTitle.Size = new Size(93, 17);
            lblStockValueTitle.TabIndex = 1;
            lblStockValueTitle.Text = "STOCK VALUE";
            lblStockValueTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvRestock
            // 
            dgvRestock.AllowUserToAddRows = false;
            dgvRestock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRestock.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 45, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRestock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRestock.ColumnHeadersHeight = 30;
            dgvRestock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRestock.Columns.AddRange(new DataGridViewColumn[] { colRestockName, colRestockQuantity, colSuggestedRestock });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 240, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRestock.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRestock.EnableHeadersVisualStyles = false;
            dgvRestock.GridColor = Color.Gainsboro;
            dgvRestock.Location = new Point(259, 365);
            dgvRestock.MultiSelect = false;
            dgvRestock.Name = "dgvRestock";
            dgvRestock.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRestock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRestock.RowHeadersVisible = false;
            dgvRestock.RowTemplate.Height = 35;
            dgvRestock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRestock.Size = new Size(602, 65);
            dgvRestock.TabIndex = 7;
            // 
            // colRestockName
            // 
            colRestockName.HeaderText = "Item Name";
            colRestockName.Name = "colRestockName";
            colRestockName.ReadOnly = true;
            // 
            // colRestockQuantity
            // 
            colRestockQuantity.HeaderText = "Current Stock";
            colRestockQuantity.Name = "colRestockQuantity";
            colRestockQuantity.ReadOnly = true;
            // 
            // colSuggestedRestock
            // 
            colSuggestedRestock.HeaderText = "Suggested Restock";
            colSuggestedRestock.Name = "colSuggestedRestock";
            colSuggestedRestock.ReadOnly = true;
            // 
            // lblRestockTitle
            // 
            lblRestockTitle.AutoSize = true;
            lblRestockTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRestockTitle.Location = new Point(259, 341);
            lblRestockTitle.Name = "lblRestockTitle";
            lblRestockTitle.Size = new Size(139, 21);
            lblRestockTitle.TabIndex = 8;
            lblRestockTitle.Text = "Need Restocking";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(886, 468);
            Controls.Add(lblRestockTitle);
            Controls.Add(dgvRestock);
            Controls.Add(pnlOutOfStock);
            Controls.Add(pnlStockValue);
            Controls.Add(pnlLowStock);
            Controls.Add(pnlTotalCategories);
            Controls.Add(pnlTotalQuantity);
            Controls.Add(pnlTotalItems);
            Controls.Add(btnTitle);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory System";
            Load += MainForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlTotalItems.ResumeLayout(false);
            pnlTotalItems.PerformLayout();
            pnlTotalQuantity.ResumeLayout(false);
            pnlTotalQuantity.PerformLayout();
            pnlTotalCategories.ResumeLayout(false);
            pnlTotalCategories.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlStockValue.ResumeLayout(false);
            pnlStockValue.PerformLayout();
            pnlOutOfStock.ResumeLayout(false);
            pnlOutOfStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblLogo;
        private Button btnLogOut;
        private Button btnStockMovement;
        private Button btnViewItems;
        private Button btnAddItem;
        private Button btnDashboard;
        private Label btnTitle;
        private Panel pnlTotalItems;
        private Panel pnlTotalQuantity;
        private Panel pnlTotalCategories;
        private Panel pnlLowStock;
        private Panel pnlStockValue;
        private Panel pnlOutOfStock;
        private Label lblTotalItemsValue;
        private Label lblTotalItemsTitle;
        private Label lblTotalQuantityValue;
        private Label pnlTotalQuantityTitle;
        private Label lblLowStockValue;
        private Label lblLowStockTitle;
        private Label lblOutOfStockValue;
        private Label lblOutOfStockTitle;
        private Label lblTotalCategoriesValue;
        private Label lblTotalCategoriesTitle;
        private Label lblStockValueValue;
        private Label lblStockValueTitle;
        private DataGridView dgvRestock;
        private Label lblRestockTitle;
        private DataGridViewTextBoxColumn colRestockName;
        private DataGridViewTextBoxColumn colRestockQuantity;
        private DataGridViewTextBoxColumn colSuggestedRestock;
    }
}