using System;
using System.Collections.Generic;

namespace PowerCure.Data
{
    public static class Logger
    {
        private static List<string> logs = new List<string>();

        public static void Log(string msg)
        {
            string entrada = $"[{DateTime.Now}] {msg}";
            logs.Add(entrada);
            Console.WriteLine(entrada);
        }

        public static void Listar()
        {
            Console.WriteLine("\n== LOGS ==");
            foreach (string l in logs)
                Console.WriteLine(l);
        }
    }
}
