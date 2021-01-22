using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFeriasApp
{
    public partial class Form1
    {
        #region CadastroFeriados
        private void GerarTabelasFeriados(List<ControleFeriasNegocio.Dominio.Feriado> feriados)
        {
            string[] colunas = { "Data", "Descrição" };
            DataTable dataTableFixos = new DataTable();
            DataTable dataTableMoveis = new DataTable();
            foreach (var coluna in colunas)
            {
                dataTableFixos.Columns.Add(coluna);
                dataTableMoveis.Columns.Add(coluna);
            }

            foreach (var feriado in feriados)
            {
                if (feriado.Anual)
                    dataTableFixos.Rows.Add(ConverterParaLinhaTabela(feriado));
                else
                    dataTableMoveis.Rows.Add(ConverterParaLinhaTabela(feriado, false));
            }

            gridFeriados.DataSource = dataTableFixos;
            gridFeriados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridFeriados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridFeriadosMoveis.DataSource = dataTableMoveis;
            gridFeriadosMoveis.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridFeriadosMoveis.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private object[] ConverterParaLinhaTabela(ControleFeriasNegocio.Dominio.Feriado feriado, bool fixo = true)
        {
            object[] resultado = new object[2];

            resultado[0] = fixo ? feriado.Data.ToDiaMes() : feriado.Data.ToDataFormatadaExibicao();
            resultado[1] = feriado.Descricao;

            return resultado;
        }

        private void CarregarFeriados()
        {
            ControleFeriasNegocio.FeriadosNegocio managerFeriados = new ControleFeriasNegocio.FeriadosNegocio();
            List<ControleFeriasNegocio.Dominio.Feriado> feriados = managerFeriados.BuscarFeriados();
            GerarTabelasFeriados(feriados);
        }

        private void btnRegistrarFeriado_Click(object sender, EventArgs e)
        {
            ControleFeriasNegocio.FeriadosNegocio managerFeriados = new ControleFeriasNegocio.FeriadosNegocio();
            DateTime data = datePickerFeriado.Value;
            string descricao = textFeriado.Text;
            bool anual = anualCheck.Checked;
            ControleFeriasNegocio.Dominio.Resposta<ControleFeriasNegocio.Dominio.Feriado> resposta = managerFeriados.CriarFeriado(data, descricao, anual);
            if (resposta.Sucesso)
            {
                CarregarFeriados();
            }
            else
            {
                MessageBox.Show(resposta.MensagemErro);
            }
        }
        #endregion
    }
}
