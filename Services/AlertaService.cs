using PowerCure.Models;
using PowerCure.Data;

namespace PowerCure.Services
{
    public class AlertaService
    {
        public void GerarAlerta(Evento e)
        {
            if (e.Duracao.TotalMinutes > 30)
                Logger.Log("ALERTA CRÍTICO: duração prolongada.");
            else
                Logger.Log("Alerta gerado para falha.");
        }
    }
}
