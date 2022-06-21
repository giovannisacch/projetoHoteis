namespace ProjetoHoteis.web.DTOs
{
    public class QuartoDTO
    {
        public virtual int IdTipo { get; set; }
        public virtual int IdHotel { get; set; }
        public int Numero { get; set; }
        public int Andar { get; set; }
    }
}