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
    public class FeriasDados
    {
        private string nomeArquivo = Settings1.Default.ArquivoFerias;

        public List<Ferias> GetAll()
        {
            string[] linhasArquivo = ArquivoUtils.LerLinhasArquivo(Settings1.Default.ArquivoFerias);

            List<Ferias> listaFerias = new List<Ferias>();
            if (linhasArquivo != null)
            {
                foreach (var linha in linhasArquivo)
                {
                   listaFerias.Add(InstanciarFeriasDeLinhaArquivo(linha));
                }
            }
            return listaFerias;
        }

        public List<Ferias> GetFeriasPorData(DateTime dataInicio, DateTime dataFim)
        {
            string[] linhasArquivo = ArquivoUtils.LerLinhasArquivo(Settings1.Default.ArquivoFerias);

            List<Ferias> listaFerias = new List<Ferias>();
            if (linhasArquivo != null)
            {
                foreach (var linha in linhasArquivo)
                {
                    var ferias = InstanciarFeriasDeLinhaArquivo(linha);
                    if ((ferias.DataInicio >= dataInicio && ferias.DataInicio <= dataInicio) ||
                        (ferias.DataFim >= dataInicio && ferias.DataFim <= dataFim))
                    {
                        listaFerias.Add(ferias);
                    }
                }
            }
            return listaFerias;
        }

        public List<Ferias> GetFeriasPorFuncionario(int idFuncionario)
        {
            string[] linhasArquivo = ArquivoUtils.LerLinhasArquivo(Settings1.Default.ArquivoFerias);

            List<Ferias> listaFerias = new List<Ferias>();
            if (linhasArquivo != null)
            {
                foreach (var linha in linhasArquivo)
                {
                    listaFerias.Add(InstanciarFeriasDeLinhaArquivo(linha));
                }
            }
            return listaFerias.Where(f => f.IdFuncionario == idFuncionario).ToList();
        }

        public List<Ferias> GetFeriasPorFuncionarios(List<int> idsFuncionarios)
        {
            string[] linhasArquivo = ArquivoUtils.LerLinhasArquivo(Settings1.Default.ArquivoFerias);

            List<Ferias> listaFerias = new List<Ferias>();
            if (linhasArquivo != null)
            {
                foreach (var linha in linhasArquivo)
                {
                    listaFerias.Add(InstanciarFeriasDeLinhaArquivo(linha));
                }
            }
            return listaFerias.Where(f => idsFuncionarios.Contains(f.IdFuncionario)).ToList();
        }

        public void InsertFerias(Ferias ferias)
        {
            if (!File.Exists(nomeArquivo))
            {
                using (StreamWriter sw = File.CreateText(nomeArquivo))
                {

                };
            }

            string[] linhas = File.ReadAllLines(nomeArquivo);
            int id = Utils.DefinirId(linhas);
            ferias.Id = id;
            File.AppendAllText(nomeArquivo, FormatarLinhaCadastro(ferias) + Environment.NewLine);
        }


        public void DeleteFerias(int idFuncionario, DateTime dataInicio, DateTime dataFim)
        {
            string[] linhasArquivo = ArquivoUtils.LerLinhasArquivo(nomeArquivo);
            List<string> linhasNovoArquivo = new List<string>();

            if (linhasArquivo != null)
            {
                foreach (var linha in linhasArquivo)
                {
                    var ferias = InstanciarFeriasDeLinhaArquivo(linha);
                    if (ferias.IdFuncionario != idFuncionario || ferias.DataInicio != dataInicio || ferias.DataFim != dataFim)
                    {
                        linhasNovoArquivo.Add(linha);
                    }
                }
                File.WriteAllLines(nomeArquivo, linhasNovoArquivo);
            }
        }
        
        private Ferias InstanciarFeriasDeLinhaArquivo(string linhaArquivo)
        {
            var dadosLinha = linhaArquivo.Split('\t');
            var culture = new CultureInfo("pt-BR");
            return new Ferias()
            {
                Id = Convert.ToInt32(dadosLinha[0]),
                IdFuncionario = Convert.ToInt32(dadosLinha[1]),
                DataInicio = DateTime.ParseExact(dadosLinha[2], Utils.FORMATO_REGISTRO_DATA, culture),
                DataFim = DateTime.ParseExact(dadosLinha[3], Utils.FORMATO_REGISTRO_DATA, culture),
            };
        }

        private string FormatarLinhaCadastro(Ferias ferias)
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", ferias.Id, ferias.IdFuncionario, ferias.DataInicio.ToDataArquivo(), ferias.DataFim.ToDataArquivo());
        }
    }

    
}
