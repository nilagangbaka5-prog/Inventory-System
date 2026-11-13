
using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class AddItemForm : Form
    {
        private SupabaseService supabase;

        public AddItemForm()
        {
            InitializeComponent();
        }

        public AddItemForm(SupabaseService service) : this()
        {
            supabase = service;

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtItemName.Text.Trim();
            string category = txtCategory.Text.Trim();

            // VALIDATION
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

            if (supabase == null)
            {
                MessageBox.Show("Supabase connection is missing.");
                return;
            }

            // CREATE PRODUCT
            Product product = new Product
            {
                Name = name,
                Category = category,
                Quantity = (int)numQuantity.Value,
                Price = numPrice.Value
            };

            try
            {
                btnSave.Enabled = false;
                btnSave.Text = "SAVING...";

                // SAVE TO SUPABASE
                await supabase.AddProductAsync(product);

                MessageBox.Show(
                    "Item successfully added!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // CLEAR FIELDS
                txtItemName.Clear();
                txtCategory.Clear();
                numQuantity.Value = 0;
                numPrice.Value = 0;

                txtItemName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save item:\n" + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnSave.Enabled = true;
                btnSave.Text = "SAVE ITEM";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
