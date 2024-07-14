using RestSharp;
using Rodoviaria.WEB.DTO;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace Rodoviaria.WEB.Data
{
    public class PassagemService : IPassagemService
    {
        private readonly RestClient restClient;

        public PassagemService()
        {
            //restClient = new RestClient("https://rodoviariavictor.azurewebsites.net/"); //Usar para acesso para a api publicada no Azure
            restClient = new RestClient("https://localhost:7184/");
        }

        public async Task<string> PostPassagem(PassagemRequest request)
        {
            var jdto = JsonSerializer.Serialize<PassagemRequest>(request);
            var requisicao = new RestRequest("api/Passagem").AddJsonBody(jdto);
            var response = await restClient.ExecutePostAsync(requisicao);

            var res = JsonSerializer.Deserialize<string>(response.Content,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return res;
        }
    }
}
