namespace ShopReceipt
{
    using System.Runtime.Serialization.Json;

    public partial class Main : Form
    {
        private readonly FileStream fileStream;
        private readonly DataContractJsonSerializer dataContractJsonSerializer;
        private readonly List<Product>? products;

        public Main()
        {
            InitializeComponent();

            fileStream = new FileStream("products.json", FileMode.Open, FileAccess.Read);
            dataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Product>));
            products = (List<Product>?)dataContractJsonSerializer.ReadObject(fileStream);

            ProductSelectComboBox.DataSource = products;
        }

        private void ProductManageMenuItem_Click(object sender, EventArgs e)
        {
            fileStream.Close();
            new ProductManage().ShowDialog();
        }

        private void AddToCheckButton_Click(object sender, EventArgs e)
        {
            ReceiptDataGridView.Rows.Add(ProductSelectComboBox.Text, ProductSelectComboBox.SelectedValue);

            decimal totalPrice = 0;

            for (int i = 0; i < ReceiptDataGridView.Rows.Count; i++)
            {
                totalPrice += Convert.ToDecimal(ReceiptDataGridView.Rows[i].Cells[1].Value);
            }

            TotalPriceLabel.Text = "Итого: " + totalPrice.ToString() + " рублей";
        }
    }
}