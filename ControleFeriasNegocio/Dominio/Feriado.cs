using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasNegocio.Dominio
{
    public class Feriado
    {
        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public bool Anual { get; set; }
        
        public Feriado() { }

        public Feriado(ControleFeriasDados.Entidades.Feriado feriadoDados)
        {
            Data = feriadoDados.Data;
            Descricao = feriadoDados.Descricao;
            Anual = feriadoDados.Anual;
        }
    }



}
