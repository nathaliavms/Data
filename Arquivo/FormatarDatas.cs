using System;
using System.IO;
using System.Text;

namespace Arquivo
{
    class FormatarDatas
    {
        private string Origem { get; set; }
        private string[] Valor { get; set; }
        public FormatarDatas(string origem)
        {
            Origem = origem;
        }
        private DateTime LeituraArquivo()
        {
            return DateTime.Parse(File.ReadAllLines(Origem)[0]);
        }

        private string[] DatasFormatadas(DateTime valor)
        {
            return new string[]
            {
                    valor.ToString("MM/dd/yy"),
                    valor.ToString("yy/MM/dd"),
                    valor.ToString("dd-MM-yy")
            };
        }
        public void Conversao()
        {
            var valor = LeituraArquivo();
            Valor = DatasFormatadas(valor);
        }
        public void SaidaDeDados(IDados exportarDados)
        {
            exportarDados.Dado(Valor);
        }
    }
}