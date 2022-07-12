namespace ShopReceipt
{
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;

    /// <summary>
    /// The product.
    /// </summary>
    [DataContract]
    internal class Product
    {
        /// <summary>
        /// Gets the serializer.
        /// </summary>
        public static DataContractJsonSerializer Serializer { get; } =
            new DataContractJsonSerializer(typeof(List<Product>));

        /// <summary>
        /// Gets or sets the stream.
        /// </summary>
        public static FileStream Stream { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [DataMember(Name = "Price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<Product>? GetAll()
        {
            Stream.Close();
            var products = new List<Product>();

            Stream = new FileStream("products.json", FileMode.OpenOrCreate) { Position = 0 };

            if (Stream.Length > 0)
            {
                products = (List<Product>?)Serializer.ReadObject(Stream);
            }

            return products;
        }
    }
}