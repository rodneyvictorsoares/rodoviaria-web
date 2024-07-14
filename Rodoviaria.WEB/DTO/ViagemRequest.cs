namespace Rodoviaria.WEB.DTO
{
    public class ViagemRequest
    {
        public string origem { get; set; } = string.Empty;
        public string destino { get; set; } = string.Empty;
        public DateTime dataPartida { get; set; }
        public DateTime dataChegada { get; set; }
        public decimal preco { get; set; }
    }
}
