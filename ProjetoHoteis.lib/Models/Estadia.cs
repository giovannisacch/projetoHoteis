namespace ProjetoHoteis.lib.Models
{
    public class Estadia : ModelBase
    {
        public int IdResponsavel { get; set; }
        public int IdQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public virtual Hospede Responsavel { get; set; }
        public virtual Quarto Quarto { get; set; }
        public virtual List<EstadiasXHospedes> EstadiasXHospedes { get; set; }

        public Estadia(int id, string dataCriacao, string ultimaVez, string dataEntrada, string dataSaida, Hospede responsavel, TipoDeQuarto tipoDeQuarto, int idResponsavel, int idQuarto) : base(id, dataCriacao, ultimaVez)
        {
            SetDataEntrada(dataEntrada);
            SetDataSaida(dataSaida);
            SetResponsavel(responsavel);
            SetIdQuarto(idQuarto);
            SetIdResponsavel(idResponsavel);
        }

        public void SetIdResponsavel(int idResponsavel)
        {
            IdResponsavel = idResponsavel;
        }

        public int GetIdResponsavel()
        {
            return IdResponsavel;
        }

        public void SetIdQuarto(int idQuarto)
        {
            IdQuarto = idQuarto;
        }

        public int GetIdQuarto()
        {
            return IdQuarto;
        }

        public DateTime GetDataEntrada()
        {
            return DataEntrada;
        }
        public void SetDataEntrada(string dataEntrada)
        {
            DataEntrada = DateTime.Parse(dataEntrada);
        }

        public DateTime GetDataSaida()
        {
            return DataSaida;
        }
        public void SetDataSaida(string dataSaida)
        {
            if (DateTime.Parse(dataSaida) > DataEntrada)
            {
                DataSaida = DateTime.Parse(dataSaida);
            }
            else
            {
                throw new Exception("A data de saída deve ser maior que a data de entrada");
            }
        }

        public Hospede GetResponsavel()
        {
            return Responsavel;
        }

        public void SetResponsavel(Hospede responsavel)
        {
            Responsavel = responsavel;
        }
    }
}