namespace ShopReceipt
{
    /// <summary>
    /// The product manage.
    /// </summary>
    public partial class ProductManager : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductManager"/> class.
        /// </summary>
        public ProductManager()
        {
            this.InitializeComponent();

            if (Product.GetAll().Count != 0)
            {
                foreach (var product in Product.GetAll())
                {
                    this.ProductsDataGridView.Rows.Add(product.Name, product.Price);
                }
            }

            Product.Stream.Close();
        }

        /// <summary>
        /// The add product button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var products = Product.GetAll();

            Product.Stream.SetLength(0);

            var product = new Product()
                              {
                                  Name = this.ProductNameTextBox.Text, Price = this.ProductCostNumericUpDown.Value
                              };

            products?.Add(product);

            Product.Serializer.WriteObject(Product.Stream, products);

            this.ProductsDataGridView.Rows.Add(product.Name, product.Price);

            Product.Stream.Close();
        }
    }
}