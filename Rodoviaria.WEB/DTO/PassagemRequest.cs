namespace Rodoviaria.WEB.DTO
{
    public class PassagemRequest
    {
        public string passageiro { get; set; } = string.Empty;
        public string cpf { get; set; } = string.Empty;
        public string rg { get; set; } = string.Empty;
        public int tipoId { get; set; }
        public int viagemId { get; set; }
        public int cadeira { get; set; }
    }
}
