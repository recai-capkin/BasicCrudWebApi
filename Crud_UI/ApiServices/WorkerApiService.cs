using Crud_UI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Crud_UI.ApiServices
{
    public class WorkerApiService
    {
        HttpClient _client;
        public WorkerApiService(HttpClient client)
        {
            _client = client;
        }
        //get-all-factory
        public async Task<List<Workers>> GetAllWorkers()
        {
            var response = await _client.GetAsync(ApiEndpointName.getAllWorkers);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Workers>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<bool> UpdateWorker(Workers worker)
        {
            var data = new StringContent(JsonConvert.SerializeObject(worker));
            data.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _client.PutAsync(ApiEndpointName.updateFactory, data);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
            }
            return false;
        }
        public async Task<Workers> GetWorker(int workerId)
        {
            var response = await _client.GetAsync(ApiEndpointName.getWorker + workerId);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Workers>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
