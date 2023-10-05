using Microsoft.CodeAnalysis.VisualBasic;

namespace Hells_Tire.Models
{
    public class CartItem
    {
        public long Id { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Total
        {
            get
            { return Quantity * Price; }
        }

        public byte[] Images { get; set; }

        public CartItem() { }

        public CartItem (HellsTireProduct product)
        {
            Id = product.HellsTireProductID;
            ProductName = product.HellsTireProductName;
            Quantity = 1;
            Price = product.HellsTireProductPrice;
            Images = product.HellsTireProductImage;
        }
                
    }
}
