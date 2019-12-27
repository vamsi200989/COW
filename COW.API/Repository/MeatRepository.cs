using COW.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COW.API.Repository
{
    public class MeatRepository : IMeatRepository
    {
        public IEnumerable<Item> GetChickenItems()
        {
            return new List<Item>()
            {
                new Item() {Name = "Leg", Price = 10},
                new Item() {Name = "Thigh", Price = 10},
                new Item() {Name = "Leg", Price = 10},
                new Item() {Name = "Thigh", Price = 10},
                new Item() {Name = "Leg", Price = 10},
                new Item() {Name = "Thigh", Price = 10},
                new Item() {Name = "Leg", Price = 10},
                new Item() {Name = "Thigh", Price = 10},
                new Item() {Name = "Leg", Price = 10},
                new Item() {Name = "Thigh", Price = 10},
                new Item() {Name = "Leg", Price = 10},
                new Item() {Name = "Thigh", Price = 10},
                new Item() {Name = "Leg", Price = 10},
                new Item() {Name = "Thigh", Price = 10}
            };
        }
    }
}
