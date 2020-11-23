using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasDados
{
    public static class Utils
    {
        public static string FORMATO_REGISTRO_DATA = "yyyyMMdd";

        public static int DefinirId(string[] dadosArquivo)
        {
            List<int> ids = new List<int>();
            if (dadosArquivo != null && dadosArquivo.Length > 0)
            {
                int idAtual;
                foreach (var linha in dadosArquivo)
                {
                    var dadosLinha = linha.Split('\t');
                    idAtual = 0;
                    if (int.TryParse(dadosLinha[0], out idAtual))
                    {
                        ids.Add(idAtual);
                    }
                }
            }
            
            if (ids.Count() > 0)
            {
                return ids.Max(i => i);
            }
            else
            {
                return 1;
            }
        }
    }
}
