namespace ProjetoHoteis.web.DTOs
{
    public class TipoDeQuartoDTO
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int OcupacaoMaxima { get; set; }
        public int CamasCasal { get; set; }
        public int CamasSolteiro { get; set; }
        public double Valor { get; set; }
    }
}