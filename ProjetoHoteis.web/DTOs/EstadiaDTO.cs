using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.web.DTOs
{
    public class EstadiaDTO
    {
        public virtual int IdResponsavel { get; set; }
        public virtual int IdQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Hospede Responsavel { get; set; }
    }
}