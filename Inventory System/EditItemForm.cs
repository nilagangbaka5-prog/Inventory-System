
using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class EditItemForm : Form
    {
        private SupabaseService supabase;
        private Product selectedProduct;

        // DESIGNER CONSTRUCTOR
        public EditItemForm()
        {
            InitializeComponent();
        }

        // CONSTRUCTOR WITH PRODUCT DATA
        public EditItemForm(SupabaseService service, Product product)
            : this()
        {
            supabase = service;
            selectedProduct = product;

            // Display existing product information
            txtItemName.Text = product.Name;
            txtCategory.Text = product.Category;
            numQuantity.Value = product.Quantity;
            numPrice.Value = product.Price;

            // Connect buttons
            btnUpdate.Click += btnUpdate_Click;
            btnCancel.Click += btnCancel_Click;
        }

        // UPDATE ITEM
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtItemName.Text.Trim();
            string category = txtCategory.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter an item name.");
                txtItemName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please enter a category.");
                txtCategory.Focus();
                return;
            }

            try
            {
                btnUpdate.Enabled = false;
                btnUpdate.Text = "UPDATING...";

                selectedProduct.Name = name;
                selectedProduct.Category = category;
                selectedProduct.Quantity = (int)numQuantity.Value;
                selectedProduct.Price = numPrice.Value;

                await supabase.UpdateProductAsync(selectedProduct);

                MessageBox.Show(
                    "Item updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update item:\n" + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnUpdate.Enabled = true;
                btnUpdate.Text = "UPDATE ITEM";
            }
        }

        // CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
