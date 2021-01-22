using ControleFeriasDados.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasDados
{
    public class FeriadosDados
    {
        private string nomeArquivo = Settings1.Default.ArquivoFeriados;
        
        public List<Feriado> GetAll()
        {
            string[] linhasArquivo = ArquivoUtils.LerLinhasArquivo(nomeArquivo);

            List<Feriado> listaFeriados = new List<Feriado>();
            if (linhasArquivo != null)
            {
                foreach (var linha in linhasArquivo)
                {
                    listaFeriados.Add(InstanciarFeriadoDeLinhaArquivo(linha));
                }
            }
            return listaFeriados;
        }

        public List<Feriado> GetFeriadoPorData(DateTime data)
        {
            var feriados = GetAll();
            return feriados.Where(f => data.Date.CompareTo(f.Data.Date) == 0).ToList();
        }

        public void InsertFeriado(DateTime data, string feriado, bool anual)
        {
            if (!File.Exists(nomeArquivo))
            {
                using (StreamWriter sw = File.CreateText(nomeArquivo))
                {

                };
            }
            Feriado objFeriado = new Feriado()
            {
                Data = data,
                Descricao = feriado,
                Anual = anual,
            };
            File.AppendAllText(nomeArquivo, FormatarLinhaCadastro(objFeriado) + Environment.NewLine);
        }

        
        private Feriado InstanciarFeriadoDeLinhaArquivo(string linhaArquivo)
        {
            var dadosLinha = linhaArquivo.Split('\t');
            var culture = new CultureInfo("pt-BR");
            return new Feriado()
            {
                Data = DateTime.ParseExact(dadosLinha[0], Utils.FORMATO_REGISTRO_DATA, culture),
                Descricao = dadosLinha[1],
                Anual = bool.Parse(dadosLinha[2]),
            };
        }

        private string FormatarLinhaCadastro(Feriado feriado)
        {
            return string.Format("{0}\t{1}\t{2}", feriado.Data.ToDataArquivo(), feriado.Descricao, feriado.Anual.ToString());
        }
    }

    
}
