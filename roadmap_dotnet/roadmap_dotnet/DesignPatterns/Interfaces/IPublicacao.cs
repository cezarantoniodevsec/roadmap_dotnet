using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadmap_dotnet.DesignPatterns.Interfaces
{
    public interface IPublicacao
    {
        void adicionaAssinatura(IObservador observador);

        void removeDaAssintura(IObservador observador);

        void Notifica();
    }
}
