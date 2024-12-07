using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadmap_dotnet.DesignPatterns.FactoryMethod
{
    class PedidoPolemico : PedidoMusica
    {
        
        public override IJukeBox TocarMusica()
        {
            return new JukeBoxPolemica();
        }
    }

}
