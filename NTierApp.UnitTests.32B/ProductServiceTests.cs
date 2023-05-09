using NTierApp.DataAccess.Model;
using NTierApp.Logic;
using Moq;
using NTierApp.DataAccess.Abstractions;

namespace NTierApp.UnitTests._32B
{
    [TestClass]
    public class ProductServiceTests
    {

        private Mock<IProductRepository> productRepositoryMock = new Mock<IProductRepository>();

        [TestInitialize]
        public void InitializeTests()
        {
            Product existingProduct = new Product
            {
                Id = 1,
                Category = "TestCategory",
                Description = "Test",
                Name = "Test",
                Price = 100
            };
            Product existingProduct2 = new Product
            {
                Id = 2,
                Category = "TestCategory",
                Description = "Test",
                Name = "Test",
                Price = 100
            };
            productRepositoryMock.Setup(pr => pr.Get(1)).Returns(existingProduct);
            productRepositoryMock.Setup(pr => pr.Get(2)).Returns(existingProduct2);
        }


        [TestMethod]
        public void CalculateVAT_Returns_NineteenPercentFromProductPrice()
        {
            //AAA
            //Arrange
            //preparing the data for testing
            Product p = new Product()
            {
                Id = 1,
                Category = "asdasda",
                Description = "Test",
                Name = "Test",
                Price = 100.0m
            };

            ProductService service = new ProductService(null);

            //Act
            //execute the code to be tested
            var calculatedVAT = service.CalculateVAT(p);

            //Assert
            //verify the result to comply with the expected value/s
            Assert.AreEqual(19.0m, calculatedVAT);
        }

        [TestMethod]
        public void GetProduct_Returns_CorrectProductWithGivenId()
        { 
            //arrange
            ProductService service = new ProductService(productRepositoryMock.Object);
            //act
            var product = service.GetProduct(1);
            
            //assert
            Assert.IsNotNull(product);
            Assert.AreEqual(1, product.Id);
            Assert.AreEqual("Test", product.Name);
        }
    }
}