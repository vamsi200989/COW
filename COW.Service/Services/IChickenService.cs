using System.Collections.Generic;
using System.Threading.Tasks;
using COW.Model;

namespace COW.Service.Services
{
    public interface IChickenService
    {
        Task<List<Item>> GetChickenItems();
    }
}
