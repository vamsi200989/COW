using COW.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COW.API.Repository
{
    public interface IMeatRepository
    {
       IEnumerable<Item> GetChickenItems();
    }
}
