using CenciAdv.App.Base;
using CenciAdv.App.Models;
using CenciAdv.Domain.Base;
using CenciAdv.Domain.Entities;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenciAdv.App.Cadastros
{
    public partial class ListarTransacoes : MaterialForm
    {

        private readonly IBaseService<Usuario> _userService;
        private readonly IBaseService<Cidade> _cidadeService;
        private readonly IBaseService<Transacao> _transacaoService;

        private List<TransacaoModel>? transacoes;

        public ListarTransacoes(IBaseService<Transacao> transacaoService, IBaseService<Cidade> cidadeService, IBaseService<Usuario> userService)
        {
            _transacaoService = transacaoService;
            _cidadeService = cidadeService;
            _userService = userService;
            InitializeComponent();
            rdbTudo.Checked = true;

        }



        protected void CarregaGrid()
        {

            transacoes = _transacaoService.Get<TransacaoModel>().ToList();
            dataGridView1.DataSource = transacoes;
            dataGridView1.Columns["Id"]!.Visible = false;


            dataGridView1.Columns["DataTransacao"].HeaderText = "Data da transação";
            dataGridView1.Columns["DescricaoTransacao"].HeaderText = "Descrição";
            dataGridView1.Columns["IdAdvogado"].Visible = false;
            dataGridView1.Columns["NomeAdvogado"].HeaderText = "Advogado";
            dataGridView1.Columns["CodAgrupamento"].HeaderText = "Código do Agrupamento";
            dataGridView1.Columns["NomeAgrupamento"].HeaderText = "Nome do Agrupamento";
            dataGridView1.Columns["TipoAgrupamento"].Visible = false;
            dataGridView1.Columns["TipoTransacao"].Visible = false;



            if (!dataGridView1.Columns.Contains("TipoTransacaoTxt"))
            {
                DataGridViewTextBoxColumn colunaTipoTransacaoTexto = new DataGridViewTextBoxColumn
                {
                    Name = "TipoTransacaoTxt",
                    HeaderText = "Tipo da Transação",
                    ValueType = typeof(string), // Set the value type to string
                };

                dataGridView1.Columns.Add(colunaTipoTransacaoTexto);
            }

            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                DataGridViewCell tipoTransacaoCell = linha.Cells["TipoTransacao"];

                if (tipoTransacaoCell != null)
                {
                    if ((bool)linha.Cells["TipoTransacao"].Value == true)
                    {
                        linha.Cells["TipoTransacaoTxt"].Value = "Receita";
                    }
                    else
                        linha.Cells["TipoTransacaoTxt"].Value = "Despesa";
                }
            }

            decimal sumDespesas = 0;
            decimal sumReceitas = 0;
            decimal subtotal = 0;


            if (checkBoxIncluirData.Checked)
            {
                var dataInicio = dateTimePickerInicial.Value;
                var dataFinal = dateTimePickerFinal.Value;
                transacoes = _transacaoService.Get<TransacaoModel>(new List<string> { "Advogado", "ClassificacaoTransacao" }).ToList();
                transacoes = transacoes
                    .Where(x => x.DataTransacao >= dataInicio && x.DataTransacao <= dataFinal)
                    .ToList();
            }
            else
            {
                transacoes = _transacaoService.Get<TransacaoModel>(new List<string> { "Advogado", "ClassificacaoTransacao" }).ToList();
            }

            if (rdbDespesa.Checked)
            {
                transacoes = transacoes.Where(x => x.TipoTransacao == false).ToList();
                sumDespesas = (decimal)transacoes.Sum(x => x.Valor);
                lblTotalDespesas.Text = "Total Despesas: R$" + sumDespesas.ToString();
                lblSubTotal.Text = "Balanço Total: R$-";
                lblTotalReceitas.Text = "Total Receitas: R$-";
            }
            else if (rdbReceita.Checked)
            {
                transacoes = transacoes.Where(x => x.TipoTransacao == true).ToList();
                sumReceitas = (decimal)transacoes.Sum(x => x.Valor);
                lblTotalReceitas.Text = "Total Receitas: R$" + sumReceitas.ToString();

                lblSubTotal.Text = "Balanço Total: R$-";
                lblTotalDespesas.Text = "Total Despesas: R$-";

            }
            else if (rdbTudo.Checked)
            {             
                var despesas = transacoes.Where(x => x.TipoTransacao == false).ToList();
                sumDespesas = (decimal)despesas.Sum(x => x.Valor);

                var receitas = transacoes.Where(x => x.TipoTransacao == true).ToList();
                sumReceitas = (decimal)receitas.Sum(x => x.Valor);

                subtotal = sumReceitas - sumDespesas;
                lblSubTotal.Text = "Balanço Total: R$" + subtotal.ToString();
                lblTotalDespesas.Text = "Total Despesas: R$"+sumDespesas;
                lblTotalReceitas.Text = "Total Receitas: R$"+sumReceitas;

            }



            


            dataGridView1.DataSource = transacoes;
            dataGridView1.Columns["DataTransacao"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["NomeAdvogado"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["CodAgrupamento"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["NomeAgrupamento"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
