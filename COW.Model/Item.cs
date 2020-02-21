using System;

namespace COW.Model
{
    public class Item
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }

    }
}
