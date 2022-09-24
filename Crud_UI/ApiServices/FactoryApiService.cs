using Crud_UI.Models;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<bool> AddFactory(Factory factory)
        {
            var data = new StringContent(JsonConvert.SerializeObject(factory));
            data.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _client.PostAsync(ApiEndpointName.addFactory, data);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
            }
            return false;
        }
        public async Task<bool> UpdateFactory(Factory factory)
        {
            var data = new StringContent(JsonConvert.SerializeObject(factory));
            data.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _client.PutAsync(ApiEndpointName.updateFactory, data);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
            }
            return false;
        }

    }
}