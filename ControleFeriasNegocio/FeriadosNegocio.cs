using System;
using System.Collections.Generic;
using System.Linq;
using ControleFeriasNegocio.Dominio;
using ControleFeriasNegocio.Extensoes;

namespace ControleFeriasNegocio
{
    public class FeriadosNegocio
    {
        private readonly ControleFeriasDados.FeriadosDados feriadosRepositorio = new ControleFeriasDados.FeriadosDados();

        public Resposta<Feriado> CriarFeriado(DateTime data, string descricao, bool anual)
        {
            if (VerificarFeriadoExistenteNaData(data))
            {
                return new Resposta<Feriado>()
                {
                    MensagemErro = "Feriado já cadastrado para a data",
                    ObjetoRetorno = null,
                    Sucesso = false,
                };
            } else
            {
                feriadosRepositorio.InsertFeriado(data, descricao, anual);
                return new Resposta<Feriado>()
                {
                    MensagemErro = null,
                    ObjetoRetorno = new Feriado()
                    {
                        Data = data,
                        Descricao = descricao,
                        Anual = anual,
                    },
                    Sucesso = true,
                };
            }
        }

        public List<Feriado> BuscarFeriados()
        {
            List<ControleFeriasDados.Entidades.Feriado> feriadosDados = feriadosRepositorio.GetAll();
            return feriadosDados.Select(g => g.ToFeriadoDomain()).ToList();
        }

        private bool VerificarFeriadoExistenteNaData(DateTime data)
        {
            var feriadosCadastrados = feriadosRepositorio.GetAll();
            //verifica feriados na mesma data
            bool jaCadastrado = feriadosCadastrados.Any(f => (f.Data.Date.CompareTo(data.Date) == 0) ||
                                                                (f.Anual && f.Data.Month == data.Month && f.Data.Day == data.Day));
            return jaCadastrado;
        }

        public bool VerificarDiaUtil(DateTime data, List<Feriado> feriadosFixos, List<Feriado> feriadosMoveis)
        {
            if (data.DayOfWeek == DayOfWeek.Sunday || data.DayOfWeek == DayOfWeek.Saturday)
                return false;
            else
            {
                if (feriadosMoveis.Any(f => f.Data.Date == data.Date))
                {
                    //feriado móvel
                    return false;
                }
                return !feriadosFixos.Any(f => f.Data.Day == data.Day && f.Data.Month == data.Month);
            }
        }
    }
}
