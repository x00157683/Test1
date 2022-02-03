using Client.Static;
using Shared.Models;
using System.Net.Http.Json;

namespace Client.Services
{
    internal sealed class InMemoryDatabaseCache
    {
        private HttpClient _httpClient;

        public InMemoryDatabaseCache(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private List<Category> _categories = null;

        internal List<Category> Categories
        {
            get { return _categories; }

            set { 
                _categories = value;

                NotifyChange();
            }

        }

        private bool _GetCatCache = false;   //to allow only one get req



        internal async Task GetCatCache()
        {
            if (_GetCatCache)
            {
                _GetCatCache = true;  //lock
                _categories = await _httpClient.GetFromJsonAsync<List<Category>>(APIEndpoints.s_categories);
                _GetCatCache = false;  //unlock
            }

            
        }



        internal event Action onCatChange;
        private void NotifyChange()
        {
            onCatChange?.Invoke();
        }
    }
}
