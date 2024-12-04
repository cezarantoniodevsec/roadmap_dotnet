using roadmap_dotnet.DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadmap_dotnet.DesignPatterns.Implementacoes
{
    public class Publicacao: IPublicacao
    {
        public int Status { get; set; } = -0;
                
        private List<IObservador> _observadores = new List<IObservador>();
                
        public void adicionaAssinatura(IObservador observador)
        {            
            this._observadores.Add(observador);
        }

        public void removeDaAssintura(IObservador observador)
        {
            this._observadores.Remove(observador);            
        }
                
        public void Notifica()
        {
            foreach (var observador in _observadores)
            {
                observador.Update(this);
            }
        }
                
        public void geraNotificacao()
        {
            Console.WriteLine("\nProcessando o novo status.");
            this.Status = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Notificação: O status mudou para : " + this.Status);
            this.Notifica();
        }
    }
}
