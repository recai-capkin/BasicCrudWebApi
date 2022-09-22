using System.Net.Http;

namespace Crud_UI.ApiServices
{
    public class WorkerApiService
    {
        HttpClient _client;
        public WorkerApiService(HttpClient client)
        {
            _client = client;
        }
    }
}
