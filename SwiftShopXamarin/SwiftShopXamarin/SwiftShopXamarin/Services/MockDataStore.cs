using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwiftShopXamarin.Models;

namespace SwiftShopXamarin.Services
{
    public class MockDataStore : IDataStore<ShoppingItem>
    {
        List<ShoppingItem> items;

        public MockDataStore()
        {
            items = new List<ShoppingItem>();
            var mockItems = new List<ShoppingItem>
            {
                new ShoppingItem { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new ShoppingItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new ShoppingItem { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new ShoppingItem { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new ShoppingItem { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new ShoppingItem { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(ShoppingItem item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ShoppingItem item)
        {
            var oldItem = items.Where((ShoppingItem arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((ShoppingItem arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ShoppingItem> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ShoppingItem>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}