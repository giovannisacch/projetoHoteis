using ProjetoHoteis.lib.Exceptions;

namespace ProjetoHoteis.lib.Models
{
    public class Hotel : ModelBase
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public virtual List<Quarto> Quartos { get; set; }
        public virtual List<ServicosXHoteis> ServicosXHoteis { get; set; }

        public Hotel(int id, string dataCriacao, string ultimaVez, string nome, string endereco, string cep, string descricao, string telefone, string email, string checkin, string checkout) : base (id, dataCriacao, ultimaVez)
        {
            SetNome(nome);
            SetEndereco(endereco);
            SetCep(cep);
            SetDescricao(descricao);
            SetTelefone(telefone);
            SetEmail(email);
            SetCheckin(checkin);
            SetCheckout(checkout);
        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public string GetCep()
        {
            return Cep;
        }
        public void SetCep(string cep)
        {
            Cep = cep;
        }

        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public string GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone(string telefone)
        {
            if (telefone.Length <= 14)
            {
                Telefone = telefone;
            }
            else
            {
                throw new InputInvalidoException("O telefone deve ter no máximo 14 dígitos");
            }
        }

        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            if (email.Contains("@"))
            {
                Email = email;
            }
            else
            {
                throw new InputInvalidoException("O email deve conter @");
            }
        }

        public DateTime GetCheckin()
        {
            return Checkin;
        }
        public void SetCheckin(string checkin)
        {
            Checkin = DateTime.Parse(checkin);
        }

        public DateTime GetCheckout()
        {
            return Checkin;
        }
        public void SetCheckout(string checkout)
        {
            Checkin = DateTime.Parse(checkout);
        }
    }
}