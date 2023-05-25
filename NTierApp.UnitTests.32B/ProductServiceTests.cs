using NTierApp.DataAccess.Model;
using NTierApp.Logic;

namespace NTierApp.UnitTests._32B
{
    [TestClass]
    public class ProductServiceTests
    {
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
    }
}