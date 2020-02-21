using System.Collections.Generic;
using COW.Model;

namespace COW.Data.Repository
{
    public interface IMeatRepository
    {
       List<Item> GetChickenItems();
    }
}
