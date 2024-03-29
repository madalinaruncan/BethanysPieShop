using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.InventoryManagement.Domain.ProductManagement
{
    public partial class Product
    {
        public static int StockThreshold = 5;

        public static void ChangeStockThreshold(int newStockThreshold)
        {
            if (newStockThreshold > 0)
            {
                StockThreshold = newStockThreshold;
            }
        }

        protected string CreateSimpleProductRepresentation()
        {
            return $"Product {id} ({name})";
        }

        protected void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void UpdateLowStock()
        {
            if (AmountInStock < StockThreshold)
            {
                IsBelowStockThreshold = true;
            }
        }
    }
}
