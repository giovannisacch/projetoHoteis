namespace ProjetoHoteis.lib.Models
{
    public class EstadiasXHospedes : ModelBase
    {
        public int IdEstadia { get; set; }
        public int IdHospede { get; set; }
        public virtual Estadia Estadia { get; set; }
        public virtual Hospede Hospede { get; set; }

        public EstadiasXHospedes(int id, string dataCriacao, string ultimaVez, int idEstadia, int idHospede) : base(id, dataCriacao, ultimaVez)
        {
            SetIdEstadia(idEstadia);
            SetIdHospede(idHospede);
        }

        public void SetIdEstadia(int idEstadia)
        {
            IdEstadia = idEstadia;
        }

        public int GetIdEstadia()
        {
            return IdEstadia;
        }

        public void SetIdHospede(int idHospede)
        {
            IdHospede = idHospede;
        }

        public int GetIdHospede()
        {
            return IdHospede;
        }
    }
}