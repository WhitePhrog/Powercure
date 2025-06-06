using System;

namespace PowerCure.Utils
{
    public static class Validador
    {
        public static string LerTexto(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input;
                Console.WriteLine("Campo obrigatório.");
            }
        }

        public static DateTime LerData(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
                    return data;
                Console.WriteLine("Data inválida.");
            }
        }

        public static TimeSpan LerDuracao(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                if (double.TryParse(Console.ReadLine(), out double min) && min >= 0)
                    return TimeSpan.FromMinutes(min);
                Console.WriteLine("Número inválido.");
            }
        }
    }
}
