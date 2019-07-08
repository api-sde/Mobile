using System.Collections.Generic;
using System.Threading.Tasks;
using SwiftShopXamarin.Models;

namespace SwiftShopXamarin.Services
{
    public class LocalDataStore : IDataStore<ShoppingItem>
    {
        public Task<bool> AddItemAsync(ShoppingItem item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ShoppingItem> GetItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ShoppingItem>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(ShoppingItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}
