using ProjetoHoteis.lib.Exceptions;

namespace ProjetoHoteis.lib.Models
{
    public class Hospede : ModelBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual List<Estadia> Estadias { get; set; }
        public virtual List<EstadiasXHospedes> EstadiasXHospedes { get; set; }

        public Hospede(int id, string dataCriacao, string ultimaVez, string nome, string cpf, string email, string telefone, string dataNascimento) : base (id, dataCriacao, ultimaVez)
        {
            SetNome(nome);
            SetCpf(cpf);
            SetEmail(email);
            SetTelefone(telefone);
            SetDataNascimento(dataNascimento);
        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetCpf()
        {
            return Cpf;
        }
        public void SetCpf(string cpf)
        {
            if (cpf.All(char.IsDigit))
            {
                Cpf = cpf;
            }
            else
            {
                throw new InputInvalidoException("cpf deve conter só números");
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

        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }
        public void SetDataNascimento(string dataNascimento)
        {
            DataNascimento = DateTime.Parse(dataNascimento);
        }
    }
}