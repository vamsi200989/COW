using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using COW.Shared.Models;

namespace COW.Services
{
    public interface IDataStore
    {
        Task<IList<Item>> GetChickenItems();
    }
}
