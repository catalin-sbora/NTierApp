﻿using NTierApp.DataAccess.Abstractions;
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
        public Product GetProduct(int id) 
        {
            return productRepository.Get(id);
        }
        public decimal CalculateVAT(Product p)
        {

            return 0.19m * p.Price;

        }

    }
}