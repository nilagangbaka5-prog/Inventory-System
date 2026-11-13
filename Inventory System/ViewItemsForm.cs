
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class ViewItemsForm : Form
    {
        private SupabaseService supabase;
        private List<Product> allProducts = new List<Product>();

        public ViewItemsForm()
        {
            InitializeComponent();
        }

        public ViewItemsForm(SupabaseService service) : this()
        {
            supabase = service;

            btnRefresh.Click += btnRefresh_Click;
            btnSearch.Click += btnSearch_Click;
            btnDelete.Click += btnDelete_Click;
            btnEdit.Click += btnEdit_Click;

            this.Shown += ViewItemsForm_Shown;
        }

        // LOAD PRODUCTS WHEN FORM OPENS
        private async void ViewItemsForm_Shown(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        // GET PRODUCTS FROM SUPABASE
        private async System.Threading.Tasks.Task LoadProductsAsync()
        {
            try
            {
                btnRefresh.Enabled = false;

                allProducts = await supabase.GetProductsAsync();

                DisplayProducts(allProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load products:\n" + ex.Message,
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }

        // DISPLAY PRODUCTS IN DATAGRIDVIEW
        private void DisplayProducts(List<Product> products)
        {
            dgvItems.Rows.Clear();

            foreach (Product product in products)
            {
                dgvItems.Rows.Add(
                    product.Id,
                    product.Name,
                    product.Category,
                    product.Quantity,
                    product.Price.ToString("C2",
                        System.Globalization.CultureInfo.GetCultureInfo("en-PH"))
                );
            }
        }

        // REFRESH BUTTON
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        // SEARCH BUTTON
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            var filteredProducts = allProducts
                .Where(p =>
                    p.Name.Contains(search,
                        StringComparison.OrdinalIgnoreCase) ||
                    p.Category.Contains(search,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();

            DisplayProducts(filteredProducts);
        }

        // DELETE BUTTON
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            string productId =
                dgvItems.SelectedRows[0].Cells["colId"].Value?.ToString();

            string itemName =
                dgvItems.SelectedRows[0].Cells["colName"].Value?.ToString();

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete " + itemName + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                btnDelete.Enabled = false;

                await supabase.DeleteProductAsync(productId);

                MessageBox.Show("Item deleted successfully!");

                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete item:\n" + ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnDelete.Enabled = true;
            }
        }

        // EDIT BUTTON
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to edit.");
                return;
            }

            string productId =
                dgvItems.SelectedRows[0].Cells["colId"].Value?.ToString();

            Product selectedProduct = allProducts
                .FirstOrDefault(p => p.Id == productId);

            if (selectedProduct == null)
            {
                MessageBox.Show("Unable to find the selected item.");
                return;
            }

            EditItemForm editForm =
                new EditItemForm(supabase, selectedProduct);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                _ = LoadProductsAsync();
            }
        }

        private void ViewItemsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
