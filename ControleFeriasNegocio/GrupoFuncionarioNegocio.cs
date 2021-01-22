using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFeriasNegocio.Extensoes;

namespace ControleFeriasNegocio
{
    public class GrupoFuncionarioNegocio
    {
        public void CriarGrupo(string nomeGrupo)
        {
            ControleFeriasDados.GrupoFuncionarioDados grupoRepositorio = new ControleFeriasDados.GrupoFuncionarioDados();
            grupoRepositorio.CriarNovoGrupo(nomeGrupo);
        }

        public List<Dominio.GrupoFuncionario> BuscarGrupos()
        {
            ControleFeriasDados.GrupoFuncionarioDados grupoRepositorio = new ControleFeriasDados.GrupoFuncionarioDados();
            List<ControleFeriasDados.Entidades.GrupoFuncionario> gruposDados = grupoRepositorio.GetGrupos();

            return gruposDados.Select(g => g.ToGrupoFuncionarioDomain()).ToList();
        }
    }
}
