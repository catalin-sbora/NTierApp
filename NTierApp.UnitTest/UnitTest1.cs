using NTierApp.DataAccess.Model;
using NTierApp.Logic;

namespace NTierApp.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductService_CalculateVAT_Returns_CorrectVATValue()
        {
            //arrange
            Product p = new Product()
            {
                Id = 1,
                Category = "Cat",
                Name = "Test",
                Description = "Test",
                Price = 100
            };
            ProductService ps = new ProductService(null);
            
            //act
            var calculatedVat = ps.CalculateVAT(p);

            //assert
            Assert.AreEqual(19m, calculatedVat);
        }
    }
}