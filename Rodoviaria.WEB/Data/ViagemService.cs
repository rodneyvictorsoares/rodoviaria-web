using RestSharp;
using Rodoviaria.WEB.DTO;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace Rodoviaria.WEB.Data
{
    public class ViagemService : IViagemService
    {
        private readonly RestClient restClient;

        public ViagemService()
        {
            //restClient = new RestClient("https://rodoviariavictor.azurewebsites.net/");
            restClient = new RestClient("https://localhost:7184/");
        }

        public async Task<int> DeleteViagem(int viagemId)
        {
            var request = new RestRequest($"api/Viagem/{viagemId}", Method.Delete);
            var response = await restClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public async Task<ViagemResponse?> GetViagem(int viagemId)
        {
            var request = new RestRequest($"api/Viagem/{viagemId}");
            var response = await restClient.ExecuteGetAsync(request);

            if (!response.IsSuccessful || response.Content == null)
            {
                return null;
            }
            else
            {
                var viagem = JsonSerializer.Deserialize<ViagemResponse>(response.Content,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return viagem;
            }

            //if (response.IsSuccessful && response.Content != null)
            //{
            //    var viagem = JsonSerializer.Deserialize<ViagemResponse>(response.Content,
            //        new JsonSerializerOptions { PropertyNameCaseInsensitive = true});
            //    return viagem;
            //}
            //else
            //{
            //    return null;
            //}

        }

        public async Task<List<ViagemResponse>?> GetViagens()
        {
            var request = new RestRequest("api/Viagem");
            var response = await restClient.ExecuteGetAsync(request);

            if (response.IsSuccessful && response.Content != null)
            {
                var viagens = JsonSerializer.Deserialize<List<ViagemResponse>>(response.Content,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return viagens;
            }
            else
            {
                return null;
            }
        }

        public async Task<int> PostViagem(ViagemRequest viagemRequest)
        {
            var jdto = JsonSerializer.Serialize<ViagemRequest>(viagemRequest);
            var request = new RestRequest("api/Viagem").AddJsonBody(jdto);
            var response = await restClient.ExecutePostAsync(request);

            if (response.IsSuccessful)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public async Task<int> PutViagem(ViagemResponse viagemResponse)
        {
            var jdto = JsonSerializer.Serialize<ViagemResponse>(viagemResponse);
            var request = new RestRequest("api/Viagem").AddJsonBody(jdto);
            var response = await restClient.ExecutePutAsync(request);

            if (response.IsSuccessful)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
