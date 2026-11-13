
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class StockMovementForm : Form
    {
        private SupabaseService supabase;
        private List<Product> allProducts = new List<Product>();

        public StockMovementForm()
        {
            InitializeComponent();
        }

        public StockMovementForm(SupabaseService service) : this()
        {
            supabase = service;

            cmbType.Items.Clear();
            cmbType.Items.Add("Stock In");
            cmbType.Items.Add("Stock Out");
            cmbType.SelectedIndex = 0;

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;

            this.Shown += StockMovementForm_Shown;
        }

        // LOAD ITEMS
        private async void StockMovementForm_Shown(
            object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                cmbItem.Enabled = false;

                allProducts = await supabase.GetProductsAsync();

                cmbItem.DataSource = null;
                cmbItem.DataSource = allProducts;
                cmbItem.DisplayMember = "Name";
                cmbItem.ValueMember = "Id";

                if (allProducts.Count == 0)
                {
                    MessageBox.Show("No items found in your inventory.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load items:\n" + ex.Message,
                    "Loading Error"
                );
            }
            finally
            {
                cmbItem.Enabled = true;
            }
        }

        // SAVE STOCK MOVEMENT
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Please select a movement type.");
                return;
            }

            Product selectedProduct =
                (Product)cmbItem.SelectedItem;

            string movementType =
                cmbType.SelectedItem.ToString();

            int quantity = (int)numQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            if (movementType == "Stock Out" &&
                quantity > selectedProduct.Quantity)
            {
                MessageBox.Show(
                    "Not enough stock available. Current stock: " +
                    selectedProduct.Quantity
                );
                return;
            }

            try
            {
                btnSave.Enabled = false;
                btnSave.Text = "SAVING...";

                await supabase.RecordStockMovementAsync(
                    selectedProduct.Id,
                    movementType,
                    quantity
                );

                MessageBox.Show(
                    "Stock movement recorded successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                numQuantity.Value = 1;

                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to record stock movement:\n" + ex.Message,
                    "Movement Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnSave.Enabled = true;
                btnSave.Text = "SAVE MOVEMENT";
            }
        }

        // CANCEL
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
