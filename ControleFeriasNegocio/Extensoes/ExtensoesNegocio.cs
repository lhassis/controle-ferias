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

        public static Funcionario ToFuncionarioDominio(this ControleFeriasDados.Entidades.Funcionario funcDados)
        {
            if (Grupos == null || Grupos.Count <= 0)
                CarregarGrupos();

            return new Funcionario()
            {
                Grupo = Grupos[funcDados.Grupo],
                Identificador = funcDados.Identificador,
                Nome = funcDados.Nome
            };

        }

        private static void CarregarGrupos()
        {
            var dadosGrupos = new ControleFeriasDados.GrupoFuncionarioDados();
            var grupos = dadosGrupos.BuscarTodosGrupos();

            Grupos = new Dictionary<int, GrupoFuncionario>();
            grupos.ForEach(g => Grupos.Add(g.Id, new GrupoFuncionario(g.Id, g.Nome)));

        }

        public static Dominio.GrupoFuncionario ToGrupoFuncionarioDomain(this ControleFeriasDados.Entidades.GrupoFuncionario grupoDados)
        {
            return new Dominio.GrupoFuncionario(grupoDados.Id, grupoDados.Nome);
        }

        public static Dominio.Ferias ToFeriasDomain(this ControleFeriasDados.Entidades.Ferias feriasDados)
        {
            return new Dominio.Ferias(feriasDados);
        }
    }
}
