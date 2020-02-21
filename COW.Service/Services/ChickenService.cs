using System.Collections.Generic;
using System.Threading.Tasks;
using COW.Data.Repository;
using COW.Model;

namespace COW.Service.Services
{
    public class ChickenService : IChickenService
    {
        private readonly IMeatRepository meatRepository;

        public ChickenService(IMeatRepository meatRepository)
        {
            this.meatRepository = meatRepository;
        }
        public Task<List<Item>> GetChickenItems()
        {
            return Task.FromResult(meatRepository.GetChickenItems());
        }
    }
}
