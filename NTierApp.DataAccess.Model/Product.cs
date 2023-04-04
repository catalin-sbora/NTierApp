﻿namespace NTierApp.DataAccess.Model
{
    public class Product: ModelEntity
    {        
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}