using roadmap_dotnet.DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadmap_dotnet.DesignPatterns.Implementacoes
{
    public class AssinanteConcretoB : IObservador
    {
        public void Update(IPublicacao notificacao)
        {
            if ((notificacao as Publicacao).Status < 3)
            {
                Console.WriteLine("Sou o Assinante B: Recebi a notificação, porque o status é menor que 3");
            }
        }
    }
}
