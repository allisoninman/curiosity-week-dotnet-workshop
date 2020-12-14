using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace JeopardyGame
{
    /// <summary>
    /// Client for interacting with http://jservice.io/
    /// </summary>
    public class JeopardyApiClient
    {
        public async Task<Clue> GetRandomClueAsync()
        {
            var httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"http://jservice.io/api/random");
            var result = await httpResponseMessage.Content.ReadAsStringAsync();
            Clue clue = JsonConvert.DeserializeObject<Clue[]>(result)[0];
            return clue;
        }
    }
}
