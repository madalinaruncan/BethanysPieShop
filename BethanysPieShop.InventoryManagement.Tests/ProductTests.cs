using BethanysPieShop.InventoryManagement.Domain.General;
using BethanysPieShop.InventoryManagement.Domain.ProductManagement;

namespace BethanysPieShop.InventoryManagement.Tests
{
    public class ProductTests
    {
        [Fact]
        public void UseProduct_Reduces_AmountInStock()
        {
            Product product = new RegularProduct(1, "Sugar", "Lorem ipsum", new Domain.General.Price() { ItemPrice = 10, Currency = Currency.Euro }, UnitType.PerKg, 100);
            product.IncreaseStock(100);

            product.UseProduct(20);

            Assert.Equal(80, product.AmountInStock);
        }

        [Fact]
        public void UseProduct_ItemsHigherThanStock_NoChangeToStock()
        {
            Product product = new RegularProduct(1, "Sugar", "Lorem ipsum", new Domain.General.Price() { ItemPrice = 10, Currency = Currency.Euro }, UnitType.PerKg, 100);
            product.IncreaseStock(10);

            product.UseProduct(100);

            Assert.Equal(10, product.AmountInStock);
        }

        [Fact]
        public void UseProduct_Reduces_AmountInStock_StockBelowThershold()
        {
            Product product = new RegularProduct(1, "Sugar", "Lorem ipsum", new Domain.General.Price() { ItemPrice = 10, Currency = Currency.Euro }, UnitType.PerKg, 100);

            int increaseValue = 100;
            product.IncreaseStock(increaseValue);

            product.UseProduct(increaseValue -1);

            Assert.True(product.IsBelowStockThreshold);
        }
    }
}