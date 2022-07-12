namespace ShopReceipt
{
    using System.Runtime.Serialization;

    [DataContract]
    internal class Product
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Price")]
        public decimal Price { get; set; }
    }
}
