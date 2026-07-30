using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc09
{
    public class GeradorRelatorio
    {
        private readonly IFonteDados _fonteDados;
        private readonly IExportador _exportador;

        // Recebe qualquer fonte e qualquer exportador via Construtor!
        public GeradorRelatorio(IFonteDados fonteDados, IExportador exportador)
        {
            _fonteDados = fonteDados;
            _exportador = exportador;
        }

        public void Processar()
        {
            var dados = _fonteDados.ObterVendas();
            _exportador.Exportar(dados);
        }
    }
}
