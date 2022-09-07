using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Arquivo
{
    class GerarArquivo : IDados
    {
        public void Dado(string[] data)
        {
            var iniciador = 1;
            foreach (var Valor in data)
            {
                iniciador++;
                using (StreamWriter sw = File.AppendText(@$"c:\temp\arquivo{iniciador}.txt"))
                {
                    sw.Write(Valor);
                }
            }
        }
    }
}
