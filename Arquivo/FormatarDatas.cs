using System;
using System.IO;

namespace Arquivo
{
    class FormatarDatas
    {
        public void Gerar3Arquivos()
        {
            string arquivo1 = @"C:\temp\arquivo1.txt";
            string arquivo2 = @"C:\temp\arquivo2.txt";
            string arquivo3 = @"C:\temp\arquivo3.txt";
            string arquivo4 = @"C:\temp\arquivo4.txt";
            FileStream file = null;
            StreamReader stream = null;

            try
            {
                file = new FileStream(arquivo1, FileMode.Open);
                stream = new StreamReader(file);
                string[] lines = stream.ReadLine().Split('/');
                string dia = lines[0];
                string mes = lines[1];
                string ano = lines[2];
                using (StreamWriter sw = File.AppendText(arquivo2))
                {
                    sw.Write(mes + "/");
                    sw.Write(dia + "/");
                    sw.WriteLine(ano);
                }
                using (StreamWriter sw = File.AppendText(arquivo3))
                {
                    sw.Write(ano + "/");
                    sw.Write(mes + "/");
                    sw.WriteLine(dia);
                }
                using (StreamWriter sw = File.AppendText(arquivo4))
                {
                    sw.Write(dia + "-");
                    sw.Write(mes + "-");
                    sw.Write(ano);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu" + e.Message);
            } 
        } 
    }
}
