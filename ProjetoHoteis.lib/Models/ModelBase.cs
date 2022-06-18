using ProjetoHoteis.lib.Exceptions;

namespace ProjetoHoteis.lib.Models
{
    public class ModelBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataCriacao { get; set; }
        public virtual DateTime UltimaVez { get; set; }

        public ModelBase(int id, string dataCriacao, string ultimaVez)
        {
            SetId(id);
            SetDataCriacao(dataCriacao);
            SetUltimaVez(ultimaVez);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetDataCriacao(string dataCriacao)
        {
            DataCriacao = DateTime.Parse(dataCriacao);
        }

        public DateTime GetDataCriacao()
        {
            return DataCriacao;
        }

        public void SetUltimaVez(string ultimaVez)
        {
            if(DateTime.Parse(ultimaVez) <= DataCriacao)
            {
                UltimaVez = DateTime.Parse(ultimaVez);
            }
            else 
            {
                throw new InputInvalidoException("A ultima vez não pode ser anterior a data de criação");
            }
        }
    }
}