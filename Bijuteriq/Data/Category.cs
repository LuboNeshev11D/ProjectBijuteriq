﻿namespace Bijuteriq.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RegDate { get; set; }
        public ICollection<Product> Products { get; set; }//1:M
       
    }
}