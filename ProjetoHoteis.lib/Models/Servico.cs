namespace ProjetoHoteis.lib.Models
{
    public class Servico : ModelBase
    {
        public string Nome { get; set; }
        public virtual List<ServicosXHoteis> ServicosXHoteis { get; set; }

        public Servico(int id, string dataCriacao, string ultimaVez, string nome) : base (id, dataCriacao, ultimaVez)
        {
            SetNome(nome);
        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
    }
}