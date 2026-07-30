using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc09
{
    public class ExportadorPDF : IExportador
    {
        public void Exportar(List<string> dados)
        {
            Console.WriteLine("--- GERANDO ARQUIVO PDF ---");
            dados.ForEach(d => Console.WriteLine($"[PDF] {d}"));
        }
    }

    public class ExportadorCSV : IExportador
    {
        public void Exportar(List<string> dados)
        {
            Console.WriteLine("--- GERANDO ARQUIVO CSV ---");
            dados.ForEach(d => Console.WriteLine($"[CSV] {d}"));
        }
    }

    public class ExportadorJSON : IExportador
    {
        public void Exportar(List<string> dados)
        {
            Console.WriteLine("--- GERANDO ARQUIVO JSON ---");
            dados.ForEach(d => Console.WriteLine($"[JSON] {d}"));
        }
    }
}
