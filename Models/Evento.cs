using System;

namespace PowerCure.Models
{
    public class Evento
    {
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public TimeSpan Duracao { get; set; }

        public Evento(DateTime data, string local, string descricao, TimeSpan duracao)
        {
            Data = data;
            Local = local;
            Descricao = descricao;
            Duracao = duracao;
        }

        public override string ToString()
        {
            return $"[{Data}] Local: {Local}, Duração: {Duracao}, Descrição: {Descricao}";
        }
    }
}
