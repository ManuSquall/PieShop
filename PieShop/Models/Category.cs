﻿namespace PieShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public System.Collections.Generic.List<Pie> Pies { get; set; }
    }
}
