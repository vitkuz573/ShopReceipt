namespace ShopReceipt
{
    using System.Runtime.Serialization.Json;

    public partial class ProductManage : Form
    {
        private FileStream _fileStream; 
        private List<Product>? _products;
        private readonly DataContractJsonSerializer _dataContractJsonSerializer;

        public ProductManage()
        {
            InitializeComponent();

            _dataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Product>));
            _products = new List<Product>();

            GetProducts();

            /*ProductsDataGridView.DataSource = _products;*/

            if (_products != null)
            {
                foreach (Product product in _products)
                {
                    ProductsDataGridView.Rows.Add(product.Name, product.Price);
                }
            }

            _fileStream.Close();
        }

        private void GetProducts()
        {
            _fileStream = new FileStream("products.json", FileMode.OpenOrCreate)
            {
                Position = 0
            };

            if (_fileStream.Length > 0)
            {
                _products = (List<Product>?)_dataContractJsonSerializer.ReadObject(_fileStream);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            GetProducts();

            _fileStream.SetLength(0);

            var product = new Product()
            {
                Name = ProductNameTextBox.Text,
                Price = ProductCostNumericUpDown.Value
            };

            _products?.Add(product);

            _dataContractJsonSerializer.WriteObject(_fileStream, _products);

            /*ProductsDataGridView.Refresh();*/

            ProductsDataGridView.Rows.Add(product.Name, product.Price);

            _fileStream.Close();
        }
    }
}
