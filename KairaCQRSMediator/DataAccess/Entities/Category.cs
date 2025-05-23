﻿namespace KairaCQRSMediator.DataAccess.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public IList<Product> Products { get; set; }
    }
}
