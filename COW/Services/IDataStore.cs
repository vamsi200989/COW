using System;
using System.Collections.Generic;
using System.Text;
using COW.Shared.Models;

namespace COW.Services
{
    public interface IDataStore
    {
        IList<Item> GetChickenItems();
    }
}
