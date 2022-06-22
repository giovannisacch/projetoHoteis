using ProjetoHoteis.lib.Exceptions;

namespace ProjetoHoteis.lib.Models
{
    public class TipoDeQuarto : ModelBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int OcupacaoMaxima { get; set; }
        public int CamasCasal { get; set; }
        public int CamasSolteiro { get; set; }
        public double Valor { get; set; }
        public virtual List<Quarto> Quartos { get; set; }

        public TipoDeQuarto(int id, string dataCriacao, string ultimaVez, string nome, string descricao, int ocupacaoMaxima, int camasCasal, int camasSolteiro, double valor) : base (id, dataCriacao, ultimaVez)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetOcupacaoMaxima(ocupacaoMaxima);
            SetCamasCasal(camasCasal);
            SetCamasSolteiro(camasSolteiro);
            SetValor(valor);
        }
        public TipoDeQuarto()
        {
            
        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public int GetOcupacaoMaxima()
        {
            return OcupacaoMaxima;
        }
        public void SetOcupacaoMaxima(int ocupacaoMaxima)
        {
            if (ocupacaoMaxima <= (CamasSolteiro + (2 * CamasCasal)))
            {
                OcupacaoMaxima = ocupacaoMaxima;
            }
            else
            {
                throw new InputInvalidoException("A ocupação mámixa não pode ser maior que a capacidade do quarto");
            }
        }

        public int GetCamasCasal()
        {
            return CamasCasal;
        }
        public void SetCamasCasal(int camasCasal)
        {
            CamasCasal = camasCasal;
        }

        public int GetCamasSolteiro()
        {
            return CamasSolteiro;
        }
        public void SetCamasSolteiro(int camasSolteiro)
        {
            CamasSolteiro = camasSolteiro;
        }

        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
    }
}