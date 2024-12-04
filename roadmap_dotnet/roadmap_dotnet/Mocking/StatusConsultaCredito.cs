using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadmap_dotnet.Mocking
{
    public enum StatusConsultaCredito
    {
        Indefinido = -9,
        ParametroEnvioInvalido = -2,
        ErroComunicacao = -1,
        SemPendencias = 0,
        Inadimplente = 1
    }
}
