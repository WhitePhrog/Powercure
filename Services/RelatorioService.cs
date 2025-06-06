using System;
using System.Collections.Generic;
using PowerCure.Models;

namespace PowerCure.Services
{
    public class RelatorioService
    {
        public void Gerar(List<Evento> eventos)
        {
            Console.WriteLine("\n== Relatório ==");
            Console.WriteLine($"Eventos: {eventos.Count}");
            TimeSpan total = new TimeSpan();
            foreach (var e in eventos)
                total += e.Duracao;
            Console.WriteLine($"Tempo total sem energia: {total}");
        }
    }
}
