using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProducts
{
    public class Products
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Products(string productName, decimal price, string brand, DateTime manufacturingDate, DateTime expiryDate)
        {
            ProductName = productName;
            Price = price;
            Brand = brand;
            ManufacturingDate = manufacturingDate;
            ExpiryDate = expiryDate;
        }

        public override string ToString()
        {
            return $"Product Name: {ProductName}\nPrice: {Price}\nBrand: {Brand}\nManufacturing Date: {ManufacturingDate.ToShortDateString()}\nExpiry Date: {ExpiryDate.ToShortDateString()}";
        }
    }

}