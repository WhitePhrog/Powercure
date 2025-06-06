using PowerCure.Services;
using PowerCure.Utils;
using PowerCure.Data;

namespace PowerCure
{
    class Program
    {
        static void Main(string[] args)
        {
            var login = new LoginService();

            // Loop de acesso (login/cadastro)
            while (true)
            {
                Console.WriteLine("\n== Acesso ==");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Cadastrar novo usuário");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha: ");
                string escolha = Console.ReadLine();

                if (escolha == "1" && login.Login()) break;
                else if (escolha == "2") login.CadastrarNovoUsuario();
                else if (escolha == "0") return;
                else Console.WriteLine("Opção inválida ou falha no login.");
            }

            var eventos = new EventoService();
            var relatorios = new RelatorioService();
            var simulador = new SimuladorAtaqueService();

            // Menu principal
            while (true)
            {
                Console.WriteLine("\n== MENU ==");
                Console.WriteLine("1. Registrar evento");
                Console.WriteLine("2. Listar eventos");
                Console.WriteLine("3. Relatório");
                Console.WriteLine("4. Logs");
                Console.WriteLine("5. Simular ataque");
                Console.WriteLine("0. Sair");

                try
                {
                    Console.Write("Opção: ");
                    int op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1: eventos.RegistrarEvento(); break;
                        case 2: eventos.ListarEventos(); break;
                        case 3: relatorios.Gerar(eventos.GetEventos()); break;
                        case 4: Logger.Listar(); break;
                        case 5: simulador.Simular(); break;
                        case 0: return;
                        default: Console.WriteLine("Inválido."); break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }
            }
        }
    }
}
