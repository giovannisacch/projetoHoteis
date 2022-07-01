namespace ProjetoHoteis.web.DTOs
{
    public class HotelDTO
    {
        public int Id { get; set; }
         public string Nome { get; set; }
        public string Cep { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
    }
}