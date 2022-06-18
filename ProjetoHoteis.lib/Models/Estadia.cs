namespace ProjetoHoteis.lib.Models
{
    public class Estadia : ModelBase
    {
        public virtual int IdResponsavel { get; set; }
        public virtual int IdQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Hospede Responsavel { get; set; }

        public Estadia(int id, string dataCriacao, string ultimaVez, string dataEntrada, string dataSaida, Hospede responsavel, TipoDeQuarto tipoDeQuarto) : base (id, dataCriacao, ultimaVez)
        {
            SetDataEntrada(dataEntrada);
            SetDataSaida(dataSaida);
            SetResponsavel(responsavel);
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