using System;
using System.Collections.Generic;
using COW.Model;

namespace COW.Data.Repository
{
    public class MeatRepository : IMeatRepository
    {
        public List<Item> GetChickenItems()
        {
            return new List<Item>()
            {
                new Item()
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Chicken Wings",
                    Price = 90,
                    ImageUrl = "https://flutter.github.io/assets-for-api-docs/assets/widgets/owl.jpg"

                },
                new Item()
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Whole Chicken",
                    Price = 100,
                    ImageUrl = "https://flutter.github.io/assets-for-api-docs/assets/widgets/owl.jpg"
                },
            };
        }
    }
}
