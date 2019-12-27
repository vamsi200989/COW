using COW.API.Repository;
using COW.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COW.API.Services
{
    public class MeatService : IMeatService
    {
        private readonly IMeatRepository meatRepository;

        public MeatService(IMeatRepository meatRepository)
        {
            this.meatRepository = meatRepository;
        }
        public IEnumerable<Item> GetChickenItems()
        {
            return meatRepository.GetChickenItems();
        }
    }
}
