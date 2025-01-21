using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Moq;
using TPA_lectii;

namespace TestProject
{
    public class ShoppingCartTest
    {
        [Fact]
        public void GetProductById_ShouldBeUsedOnce()
        {
            var productRepositoryMock = new Mock<IProductRepository>();
            var shoppingCart = new ShoppingCart(productRepositoryMock.Object);
            var productId = 1;
            shoppingCart.AddToCart(productId);
            productRepositoryMock.Verify(p => p.GetProductById(productId),Times.Once);
        }
        [Fact]
        public void CalculateTotal_ShouldReturnPriceOfItem()
        {
            var productRepositoryMock = new Mock<IProductRepository>();
            var shopingCart = new ShoppingCart(productRepositoryMock.Object);
            var product = new Product
            {
                Price = 12345,
            };
            var productId = 1;
            productRepositoryMock.Setup(p => p.GetProductById(productId)).Returns(product);

            shopingCart.AddToCart(productId);
            var result = shopingCart.CalculateTotal();

            Assert.Equal(12345, result);

        }
    }
}
