namespace Contatos.Domain.Models
{
    public class Contato : BaseEntity
    {
        public string Nome { get; private set; }
        public string Email { get; private set;}

        public Contato(string nome, string email)
        {
            ValidaCategoria(nome, email);
            Nome= nome;
            Email= email;
        }

        public void Update(string nome, string email)
        {
            ValidaCategoria(nome, email);
        }

        private void ValidaCategoria(string nome, string email)
        {
            if (string.IsNullOrEmpty(nome))
                throw new InvalidOperationException("O nome é invalido");

            if (string.IsNullOrEmpty(email))
                throw new InvalidOperationException("O email é invalido");
        }
    }
}
