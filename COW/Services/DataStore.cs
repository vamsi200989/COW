using System;
using System.Collections.Generic;
using System.Text;
using COW.Shared.Models;
using System.Net;
using System.Net.Http;
using Xamarin.Essentials;
using System.Threading.Tasks;
using System.Text.Json;

namespace COW.Services
{
    public class DataStore : IDataStore
    {
        public static string IPAddress = DeviceInfo.Platform == DevicePlatform.Android ? "10.0.2.2" : "localhost";
        public static string BackendUrl = $"http://{IPAddress}:5000";
        public HttpClient client;
        public DataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{BackendUrl}/");
        }
        public async Task<IList<Item>> GetChickenItems()
        {
            var httpResponseMessage = await client.GetAsync("api/meat/GetChickenMenu");
            var chickenItemsContent = await httpResponseMessage.Content.ReadAsStringAsync();
            var chickenItems = JsonSerializer.Deserialize<IList<Item>>(chickenItemsContent);
            return chickenItems;
        }
    }
}
