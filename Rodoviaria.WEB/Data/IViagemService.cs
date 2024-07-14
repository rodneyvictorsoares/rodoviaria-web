using Rodoviaria.WEB.DTO;

namespace Rodoviaria.WEB.Data
{
    public interface IViagemService
    {
        Task<List<ViagemResponse>?> GetViagens();
        Task<int> PostViagem(ViagemRequest viagemRequest);
        Task<int> PutViagem(ViagemResponse viagemResponse);
        Task<ViagemResponse?> GetViagem(int viagemId);
        Task<int> DeleteViagem(int viagemId);
    }
}
