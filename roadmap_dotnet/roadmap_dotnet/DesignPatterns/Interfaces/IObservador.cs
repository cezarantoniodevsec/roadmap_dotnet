using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace roadmap_dotnet.DesignPatterns.Interfaces
{
    public interface IObservador
    {        
        void Update(IPublicacao subject);
    }
}
