namespace ShopReceipt
{
    /// <summary>
    /// The main.
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            this.InitializeComponent();

            Product.Stream = new FileStream("products.json", FileMode.Open, FileAccess.Read);

            this.ProductSelectComboBox.DataSource = (List<Product>?)Product.Serializer.ReadObject(Product.Stream);
        }

        /// <summary>
        /// The add to check button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AddToCheckButton_Click(object sender, EventArgs e)
        {
            this.ReceiptDataGridView.Rows.Add(
                this.ProductSelectComboBox.Text,
                this.ProductSelectComboBox.SelectedValue);

            decimal totalPrice = 0;

            for (var i = 0; i < this.ReceiptDataGridView.Rows.Count; i++)
            {
                totalPrice += Convert.ToDecimal(this.ReceiptDataGridView.Rows[i].Cells[1].Value);
            }

            this.TotalPriceLabel.Text = "Итого: " + totalPrice + " рублей";
        }

        /// <summary>
        /// The product manage menu item_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ProductManageMenuItem_Click(object sender, EventArgs e)
        {
            Product.Stream.Close();
            new ProductManager().ShowDialog();
        }
    }
}