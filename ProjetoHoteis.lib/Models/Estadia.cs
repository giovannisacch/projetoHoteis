namespace ProjetoHoteis.lib.Models
{
    public class Estadia
    {
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Hospede Responsavel { get; set; }

        public Estadia(string dataEntrada, string dataSaida, Hospede responsavel)
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
            DataSaida = DateTime.Parse(dataSaida);
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