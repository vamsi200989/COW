using COW.Services;
using COW.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COW.ViewModels
{
    public class MeatViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IDataStore dataStore;
        public Command LoadChickenItemsCommand { get; set; }
        public MeatViewModel()
        {
            Task.Run(async () => { ChickenItems = await GetChickenItems(); });
        }
        public MeatViewModel(IDataStore dataStore)
        {
            this.dataStore = dataStore;
            LoadChickenItemsCommand = new Command(async () =>
            {
                ChickenItems = await GetChickenItems();
            });
            LoadChickenItemsCommand.Execute(null);
        }
        public IList<Item> ChickenItems { get; set; }

        public async Task<IList<Item>> GetChickenItems()
        {
            dataStore = new DataStore();
            var chickenItems = await dataStore.GetChickenItems();
            return chickenItems;
        }
    }
}
