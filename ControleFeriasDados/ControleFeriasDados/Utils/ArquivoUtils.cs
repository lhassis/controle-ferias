using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasDados
{
    public static class ArquivoUtils
    {
        public static string LerArquivo(string nomeArquivo)
        {
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(nomeArquivo))
                {
                    // Read the stream as a string, and write the string to the console.
                    return sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                return string.Empty;
            }
        }

        public static string[] LerLinhasArquivo(string nomeArquivo)
        {
            try
            {
                return File.ReadAllLines(nomeArquivo);
            }
            catch (IOException e)
            {
                return null;
            }
        }
    }
}
