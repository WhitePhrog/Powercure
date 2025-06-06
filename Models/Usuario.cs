namespace PowerCure.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public virtual bool Autenticar(string nome, string senha)
        {
            return Nome == nome && Senha == senha;
        }
    }
}
