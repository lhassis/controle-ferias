using ControleFeriasDados.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasDados
{
    public class FuncionariosDados
    {
        private string nomeArquivo = Settings1.Default.ArquivoFuncionarios;
        //Buscar todos os funcionários
        public List<Funcionario> GetFuncionarios()
        {
            string[] linhasArquivo = ArquivoUtils.LerLinhasArquivo(Settings1.Default.ArquivoFuncionarios);

            List<Funcionario> funcionarios = new List<Funcionario>();
            if (linhasArquivo != null)
            {
                foreach (var linha in linhasArquivo)
                {
                    funcionarios.Add(InstanciarFuncionarioDeLinhaArquivo(linha));
                }
            }
            return funcionarios;
        }

        public void InsertFuncionario(string nomeFuncionario, string nomeGrupo)
        {
            GrupoFuncionarioDados grupoRepositorio = new GrupoFuncionarioDados();
            List<GrupoFuncionario> grupos = grupoRepositorio.BuscarTodosGrupos();
            GrupoFuncionario grupo = grupos.FirstOrDefault(g => g.Nome == nomeGrupo);
            Funcionario funcionario = new Funcionario(nomeFuncionario, grupo.Id);
            SalvarNoArquivo(funcionario);
        }

        private void SalvarNoArquivo(Funcionario funcionario)
        {
            if (!File.Exists(nomeArquivo))
            {
                using (StreamWriter sw = File.CreateText(nomeArquivo))
                {

                };
            }

            string[] linhas = File.ReadAllLines(nomeArquivo);
            int id = Utils.DefinirId(linhas);
            funcionario.Identificador = id;
            File.AppendAllText(nomeArquivo, FormatarLinhaCadastro(funcionario) + Environment.NewLine);
        }
        private Funcionario InstanciarFuncionarioDeLinhaArquivo(string linhaArquivo)
        {
            var dadosLinha = linhaArquivo.Split('\t');
            return new Funcionario()
            {
                Identificador = Convert.ToInt32(dadosLinha[0]),
                Nome = dadosLinha[1],
                Grupo = Convert.ToInt32(dadosLinha[2])
            };
        }

        private string FormatarLinhaCadastro(Funcionario funcionario)
        {
            return string.Format("{0}\t{1}\t{2}", funcionario.Identificador, funcionario.Nome, funcionario.Grupo);
        }
    }

    
}
