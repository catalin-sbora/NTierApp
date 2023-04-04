using NTierApp.DataAccess.Abstractions;
using NTierApp.DataAccess.Model;

namespace NTierApp.Logic
{
    public class ProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository) 
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        { 
            return productRepository.GetAll();
        }

    }
}