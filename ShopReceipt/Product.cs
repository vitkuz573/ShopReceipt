namespace ShopReceipt
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The product.
    /// </summary>
    [DataContract]
    internal class Product
    {
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
    }
}