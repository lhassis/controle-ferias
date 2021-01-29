using ControleFeriasDados.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasDados
{
    public class GrupoFuncionarioDados
    {
        public List<GrupoFuncionario> GetGrupos()
        {
            var linhasGrupos = ArquivoUtils.LerLinhasArquivo(Settings1.Default.ArquivoGrupos);

            List<GrupoFuncionario> grupos = new List<GrupoFuncionario>();
            if (linhasGrupos != null)
            {
                foreach (var linha in linhasGrupos)
                {
                    grupos.Add(InstanciarGrupoFuncionarioDeLinhaArquivo(linha));
                }
            }

            return grupos;
        }

        public GrupoFuncionario GetGrupo(string nome)
        {
            return GetGrupos().FirstOrDefault(g => g.Nome == nome);
        }

        public bool CriarNovoGrupo(string nomeGrupo)
        {
            if (!File.Exists(Settings1.Default.ArquivoGrupos))
            {
                using (StreamWriter sw = File.CreateText(Settings1.Default.ArquivoGrupos))
                {
                    
                };
            }

            string[] linhas = File.ReadAllLines(Settings1.Default.ArquivoGrupos);
            int id = Utils.DefinirId(linhas);
            File.AppendAllText(Settings1.Default.ArquivoGrupos, string.Format("{0}\t{1}", id, nomeGrupo) + Environment.NewLine);
            return true;
        }

        private GrupoFuncionario InstanciarGrupoFuncionarioDeLinhaArquivo(string linha)
        {
            var dadosLinha = linha.Split('\t');
            return new GrupoFuncionario()
            {
                Id = Convert.ToInt32(dadosLinha[0]),
                Nome = dadosLinha[1]
            };
        }
    }
}
