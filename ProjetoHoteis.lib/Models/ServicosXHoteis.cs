namespace ProjetoHoteis.lib.Models
{
    public class ServicosXHoteis : ModelBase 
    {
        public virtual int IdHotel { get; set; }
        public virtual int IdEstadia { get; set; }
        public ServicosXHoteis(int id, string dataCriacao, string ultimaVez) : base (id, dataCriacao, ultimaVez)
        {
            
        }
    }
}