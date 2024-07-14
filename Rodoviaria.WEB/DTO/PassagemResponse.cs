namespace Rodoviaria.WEB.DTO
{
    public class PassagemResponse
    {
        public int passagemId { get; set; }
        public string passageiro { get; set; } = string.Empty;
        public string cpf { get; set; } = string.Empty;
        public string rg { get; set; } = string.Empty;
        public decimal valor { get; set; }
        public int cadeira { get; set; }
        public bool ehMeia { get; set; }
        public string destino { get; set; } = string.Empty;
        public DateTime dataPartida { get; set; }
        public decimal preco { get; set; }
    }
}
