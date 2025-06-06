using System;
using System.Collections.Generic;
using PowerCure.Models;
using PowerCure.Utils;
using PowerCure.Data;

namespace PowerCure.Services
{
    public class EventoService
    {
        private List<Evento> eventos = new List<Evento>();
        private AlertaService alertaService = new AlertaService();

        public void RegistrarEvento()
        {
            Console.WriteLine("\n== Registro de Evento ==");

            DateTime data = Validador.LerData("Data do evento (ex: 2025-06-05): ");
            string local = Validador.LerTexto("Local do evento: ");
            TimeSpan duracao = Validador.LerDuracao("Duração (minutos): ");
            string descricao = Validador.LerTexto("Descrição do evento: ");

            Evento e = new Evento(data, local, descricao, duracao);
            eventos.Add(e);
            Logger.Log("Evento registrado.");
            alertaService.GerarAlerta(e);
        }

        public void ListarEventos()
        {
            Console.WriteLine("\n== Eventos ==");
            if (eventos.Count == 0)
            {
                Console.WriteLine("Nenhum evento registrado.");
                return;
            }

            foreach (var e in eventos)
                Console.WriteLine(e);
        }

        public List<Evento> GetEventos() => eventos;
    }
}
