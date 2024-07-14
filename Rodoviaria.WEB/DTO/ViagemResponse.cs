namespace Rodoviaria.WEB.DTO
{
    public class ViagemResponse
    {
        public int viagemId { get; set; }
        public string destino { get; set; } = string.Empty;
        public DateTime dataPartida { get; set; }
        public decimal preco { get; set; }
        public int lugaresLivres { get; set; }
        public int gratuidades { get; set; }
    }
}
