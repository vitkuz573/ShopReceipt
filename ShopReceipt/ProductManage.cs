namespace ShopReceipt
{
    using System.Runtime.Serialization.Json;

    /// <summary>
    /// The product manage.
    /// </summary>
    public partial class ProductManage : Form
    {
        /// <summary>
        /// The serializer.
        /// </summary>
        private readonly DataContractJsonSerializer serializer;

        /// <summary>
        /// The products.
        /// </summary>
        private List<Product>? products;

        /// <summary>
        /// The stream.
        /// </summary>
        private FileStream stream;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductManage"/> class.
        /// </summary>
        public ProductManage()
        {
            this.InitializeComponent();

            this.serializer = new DataContractJsonSerializer(typeof(List<Product>));
            this.products = new List<Product>();

            this.GetProducts();

            if (this.products != null)
            {
                foreach (var product in this.products)
                {
                    this.ProductsDataGridView.Rows.Add(product.Name, product.Price);
                }
            }

            this.stream.Close();
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
            this.GetProducts();

            this.stream.SetLength(0);

            var product = new Product()
                              {
                                  Name = this.ProductNameTextBox.Text, Price = this.ProductCostNumericUpDown.Value
                              };

            this.products?.Add(product);

            this.serializer.WriteObject(this.stream, this.products);

            this.ProductsDataGridView.Rows.Add(product.Name, product.Price);

            this.stream.Close();
        }

        /// <summary>
        /// The get products.
        /// </summary>
        private void GetProducts()
        {
            this.stream = new FileStream("products.json", FileMode.OpenOrCreate) { Position = 0 };

            if (this.stream.Length > 0)
            {
                this.products = (List<Product>?)this.serializer.ReadObject(this.stream);
            }
        }
    }
}