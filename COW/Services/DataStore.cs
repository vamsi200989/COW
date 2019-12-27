using System;
using System.Collections.Generic;
using System.Text;
using COW.Shared.Models;
using System.Net;
using System.Net.Http;

namespace COW.Services
{
    public class DataStore : IDataStore
    {
        public IList<Item> GetChickenItems()
        {
            var httpClient = new HttpClient();
            httpClient.GetAsync();
        }
    }
}
