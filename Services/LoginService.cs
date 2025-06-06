using PowerCure.Models;
using System;

namespace PowerCure.Services
{
    public class LoginService
    {
        private Usuario usuario;

        public LoginService()
        {
            // Usuário padrão de testes
            usuario = new Admin("admin", "password");
        }

        public bool Login()
        {
            Console.WriteLine("\n== Login ==");
            Console.Write("Usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (usuario.Autenticar(nome, senha))
            {
                Console.WriteLine("Login bem-sucedido.");
                return true;
            }

            Console.WriteLine("Credenciais inválidas.");
            return false;
        }

        public void CadastrarNovoUsuario()
        {
            Console.WriteLine("\n== Cadastro de Novo Usuário ==");

            Console.Write("Digite o nome de usuário: ");
            string nome = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome não pode ser vazio.");
                Console.Write("Digite o nome de usuário: ");
                nome = Console.ReadLine();
            }

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(senha))
            {
                Console.WriteLine("Senha não pode ser vazia.");
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();
            }

            usuario = new Admin(nome, senha);
            Console.WriteLine("Usuário cadastrado com sucesso. Agora você pode fazer login.");
        }
    }
}
