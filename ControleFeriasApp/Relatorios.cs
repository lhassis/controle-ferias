using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasApp
{
    public static class Relatorios
    {
        public static void GerarRelatorioFeriasPorSetor(string setor)
        {
            //Buscar as férias dos funcionários do setor
            var negocio = new ControleFeriasNegocio.FeriasNegocio();
            List<ControleFeriasNegocio.Dominio.Funcionario> ferias = negocio.GetFeriasSetor(setor);
            TelaRelatorio relatorio = new TelaRelatorio(ferias);
            
            //Configuração inicial dos seletores de data
            

            relatorio.Show();
        }

        
    }
}
