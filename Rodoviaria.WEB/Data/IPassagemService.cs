using Rodoviaria.WEB.DTO;

namespace Rodoviaria.WEB.Data
{
    public interface IPassagemService
    {
        Task<string> PostPassagem(PassagemRequest request);
    }
}
