using COW.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COW.API.Services
{
    interface IMeatService
    {
        IEnumerable<Item> GetChickenItems();
    }
}
