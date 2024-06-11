using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.nUnitTest
{
    public class ProductTests
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            _product = new Product(1, "Product Name", 0.0, 0);
        }

        [TestCase(1)]
        [TestCase(5000)]
        [TestCase(10000)]
        public void ProductID_Test(int productId)
        {
            // Arrange
            // Objects and data have been created

            // Act
            _product.ProductID = productId;

            // Assert
            Assert.That(_product.ProductID, Is.EqualTo(productId));
        }

        [TestCase("Product Name 1")]
        [TestCase("Product Name 2")]
        [TestCase("Product Name 3")]
        public void ProductName_Test(string productName)
        {
            // Arrange
            // Objects and data have been created

            // Act
            _product.ProductName = productName;

            // Assert
            Assert.That(_product.ProductName, Is.EqualTo(productName));
        }

        [TestCase(1.0)]
        [TestCase(2500.0)]
        [TestCase(5000.0)]
        public void ProductPrice_Test(double price)
        {
            // Arrange
            // Objects and data have been created

            // Act
            _product.Price = price;

            // Assert
            Assert.That(_product.Price, Is.EqualTo(price));
        }

        [TestCase(1)]
        [TestCase(50000)]
        [TestCase(100000)]
        public void ProductStock_Test(int stock)
        {
            // Arrange
            // Objects and data have been created

            // Act
            _product.Stock = stock;

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(stock));
        }

        [TestCase(1, 101)]
        [TestCase(50000, 50100)]
        [TestCase(99900, 100000)]
        public void IncreaseStock_Test(int amount, int expected)
        {
            // Arrange
            _product.Stock = 100;

            // Act
            _product.IncreaseStock(amount);

            //Assert
            Assert.That(_product.Stock, Is.EqualTo(expected));
        }

        [TestCase(1, 99)]
        [TestCase(50, 50)]
        [TestCase(100, 0)]
        public void DecreaseStock_Test(int amount, int expected)
        {
            // Arrange
            _product.Stock = 100;

            // Act
            _product.DecreaseStock(amount);

            //Assert
            Assert.That(_product.Stock, Is.EqualTo(expected));
        }

    }
}
