using System;
using System.IO;
using System.Collections.Generic;

namespace Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ValoresDeDatas = new FormatarDatas(@$"c:\temp\arquivo1.txt");
            ValoresDeDatas.Conversao();
            ValoresDeDatas.SaidaDeDados(new GerarArquivo());
            ValoresDeDatas.SaidaDeDados(new GerarConsole());
        }
    }
}