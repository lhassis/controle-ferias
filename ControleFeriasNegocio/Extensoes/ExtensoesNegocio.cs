using ControleFeriasNegocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasNegocio.Extensoes
{
    public static class ExtensoesNegocio
    {
        private static Dictionary<int, GrupoFuncionario> Grupos;

        private static void CarregarGrupos()
        {
            var dadosGrupos = new ControleFeriasDados.GrupoFuncionarioDados();
            var grupos = dadosGrupos.GetGrupos();

            Grupos = new Dictionary<int, GrupoFuncionario>();
            grupos.ForEach(g => Grupos.Add(g.Id, new GrupoFuncionario(g.Id, g.Nome)));

        }

        #region Funcionarios
        public static Funcionario ToFuncionarioDominio(this ControleFeriasDados.Entidades.Funcionario funcDados)
        {
            if (Grupos == null || Grupos.Count <= 0)
                CarregarGrupos();

            return new Funcionario()
            {
                Grupo = Grupos[funcDados.Grupo],
                Identificador = funcDados.Identificador,
                Nome = funcDados.Nome,
                Servidor = funcDados.Servidor,
            };

        }
        #endregion

        #region GrupoFuncionarios
        public static GrupoFuncionario ToGrupoFuncionarioDomain(this ControleFeriasDados.Entidades.GrupoFuncionario grupoDados)
        {
            return new GrupoFuncionario(grupoDados.Id, grupoDados.Nome);
        }
        #endregion

        #region Ferias
        public static Ferias ToFeriasDominio(this ControleFeriasDados.Entidades.Ferias feriasDados)
        {
            return new Ferias(feriasDados);
        }
        #endregion

        #region Feriados
        public static Feriado ToFeriadoDomain(this ControleFeriasDados.Entidades.Feriado feriadoDados)
        {
            return new Feriado(feriadoDados);
        }
        #endregion

        #region List
        public static void AddOrReplace<T>(this List<T> lista, T novoObjeto, Predicate<T> predicate)
        {
            int index = lista.FindIndex(predicate);
            if (index >= 0)
            {
                lista[index] = novoObjeto;
            }
            else
            {
                lista.Add(novoObjeto);
            }
        }

        public static bool IsNullOrEmpty<T>(this List<T> lista)
        {
            return lista == null || lista.Count <= 0;
        }
        #endregion
    }
}
