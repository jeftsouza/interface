using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc09
{
    public class BancoDadosVendas : IFonteDados
    {
        public List<string> ObterVendas() => new List<string> { "Venda #101 - R$ 150,00", "Venda #102 - R$ 320,00" };
    }

    public class ApiExternaVendas : IFonteDados
    {
        public List<string> ObterVendas() => new List<string> { "Venda #201 (API) - R$ 99,00" };
    }
}
