
using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Inventory_System
{
    public partial class MainForm : Form
    {
        private SupabaseService supabase;

        // DESIGNER CONSTRUCTOR
        public MainForm()
        {
            InitializeComponent();
        }

        // SUPABASE CONSTRUCTOR
        public MainForm(SupabaseService supabase) : this()
        {
            this.supabase = supabase;
        }

        // LOAD DASHBOARD
        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (supabase == null)
                return;

            await LoadDashboardAsync();
        }

        // GET DATA FROM SUPABASE
        private async Task LoadDashboardAsync()
        {
            try
            {
                var products = await supabase.GetProductsAsync();

                // TOTAL ITEMS
                lblTotalItemsValue.Text =
                    products.Count.ToString();

                // TOTAL QUANTITY
                lblTotalQuantityValue.Text =
                    products.Sum(p => p.Quantity).ToString();

                // TOTAL CATEGORIES
                lblTotalCategoriesValue.Text =
                    products.Select(p => p.Category)
                    .Where(c => !string.IsNullOrWhiteSpace(c))
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .Count().ToString();

                // LOW STOCK (1 TO 5)
                lblLowStockValue.Text =
                    products.Count(p =>
                        p.Quantity > 0 &&
                        p.Quantity <= 5).ToString();

                // STOCK VALUE
                decimal stockValue =
                    products.Sum(p => p.Quantity * p.Price);

                lblStockValueValue.Text =
                    stockValue.ToString(
                        "C2",
                        System.Globalization.CultureInfo.GetCultureInfo("en-PH")
                    );

                // OUT OF STOCK
                lblOutOfStockValue.Text =
                    products.Count(p => p.Quantity == 0).ToString();

                // ITEMS NEED TO RESTOCK
                dgvRestock.Rows.Clear();

                var restockItems =
                    products.Where(p => p.Quantity <= 5).ToList();

                foreach (var product in restockItems)
                {
                    int suggestedRestock =
                        Math.Max(0, 10 - product.Quantity);

                    dgvRestock.Rows.Add(
                        product.Name,
                        product.Quantity,
                        suggestedRestock
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard: " + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // LOGOUT BUTTON
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Close();
        }

        // ADD ITEM BUTTON
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItem = new AddItemForm(supabase);
            addItem.ShowDialog();

            _ = LoadDashboardAsync();
        }

        // VIEW ITEMS BUTTON
        private void btnViewItems_Click_1(object sender, EventArgs e)
        {
            ViewItemsForm viewItems = new ViewItemsForm(supabase);
            viewItems.ShowDialog();

            _ = LoadDashboardAsync();
        }



        // EXISTING DESIGNER EVENTS
        private void pnlTotalItems_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblTotalItemsValue_Click(object sender, EventArgs e)
        {
        }

        private void lblStockValueValue_Click(object sender, EventArgs e)
        {
        }

        private void btnStockMovement_Click_1(object sender, EventArgs e)
        {
            StockMovementForm movementForm =
                new StockMovementForm(supabase);

            movementForm.ShowDialog();

            _ = LoadDashboardAsync();
        }
    }
}
