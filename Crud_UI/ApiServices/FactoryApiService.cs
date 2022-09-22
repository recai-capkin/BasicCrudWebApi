using Crud_UI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Crud_UI.ApiServices
{
    public class FactoryApiService
    {
        HttpClient _client;
        public FactoryApiService(HttpClient client)
        {
            _client = client;
        }
        //add-factory
        //get-factory?factoryId=1
        //get-all-factory
        public async Task<List<Factory>> GetAllFactory()
        {
            var response = await _client.GetAsync(ApiEndpointName.getAllFactory);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Factory>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

    }
}