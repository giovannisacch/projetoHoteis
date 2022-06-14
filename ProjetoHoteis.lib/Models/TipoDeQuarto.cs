namespace ProjetoHoteis.lib.Models
{
    public class TipoDeQuarto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int OcupacaoMaxima { get; set; }
        public int CamasCasal { get; set; }
        public int CamasSolteiro { get; set; }
        public double Valor { get; set; }

        public TipoDeQuarto(string nome, string descricao, int ocupacaoMaxima, int camasCasal, int camasSolteiro, double valor)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetOcupacaoMaxima(ocupacaoMaxima);
            SetCamasCasal(camasCasal);
            SetCamasSolteiro(camasSolteiro);
            SetValor(valor);
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
            OcupacaoMaxima = ocupacaoMaxima;
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