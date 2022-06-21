namespace ProjetoHoteis.lib.Models
{
    public class ServicosXHoteis : ModelBase
    {
        public virtual int IdHotel { get; set; }
        public virtual int IdEstadia { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Servico Servico { get; set; }
        public ServicosXHoteis(int id, string dataCriacao, string ultimaVez, int idEstadia, int idHotel) : base(id, dataCriacao, ultimaVez)
        {
            SetIdEstadia(idEstadia);
            SetIdHotel(idHotel);
        }

        public void SetIdEstadia(int idEstadia)
        {
            IdEstadia = idEstadia;
        }

        public int GetIdEstadia()
        {
            return IdEstadia;
        }

        public void SetIdHotel(int idHotel)
        {
            IdHotel = idHotel;
        }

        public int GetIdHotel()
        {
            return IdHotel;
        }
    }
}