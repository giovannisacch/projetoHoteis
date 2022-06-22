using Xunit;
using ProjetoHoteis.lib.Models;
namespace ProjetoHoteis.Test;

public class TesteEstadia
{
    private Hospede CriaHospedePadrao()
    {
        return new Hospede(1,"01/01/2000", "01/01/2000", "rafael", "12345678978", "rafael@email.com", "119456312584", "19/11/2001");
    }
    private TipoDeQuarto CriaTipoDeQuartoPadrao()
    {
        return new TipoDeQuarto(1, "01/01/2000", "01/01/2000", "Quarto foda", "Quarto muito bom", 2, 1, 1, 300 );
    }
    private Estadia CriaEstadiaPadrão()
    {
        return new Estadia();
    }
    [Fact]
    public void DataEntradaDeveSerAnteriorASaida()
    {

    }
}