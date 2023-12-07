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
        private readonly IBaseService<ClassificacaoTransacao> _clasTransService;

        private List<TransacaoModel>? transacoes;

        public ListarTransacoes(IBaseService<Transacao> transacaoService, IBaseService<Cidade> cidadeService,
            IBaseService<Usuario> userService, IBaseService<ClassificacaoTransacao> clasTransService)
        {



            _transacaoService = transacaoService;
            _cidadeService = cidadeService;
            _userService = userService;
            _clasTransService = clasTransService;
            InitializeComponent();
            rdbTudo.Checked = true;

            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboAdvogado.ValueMember = "Id";
            cboAdvogado.DisplayMember = "Nome";
            cboAdvogado.DataSource = _userService.Get<UsuarioModel>().ToList();

            cboTiposTransacao.ValueMember = "Id";
            cboTiposTransacao.DisplayMember = "NomeAgrupamento";
            cboTiposTransacao.DataSource = _clasTransService.Get<ClassificacaoTransacao>().ToList();

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
            dataGridView1.Columns["TipoTransacaoTxt"].HeaderText = "Tipo da Transação";
            dataGridView1.Columns["TipoAgrupamento"].Visible = false;
            dataGridView1.Columns["TipoTransacao"].Visible = false;
            dataGridView1.Columns["IdAgrupamento"].Visible = false;




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

            //pegando a lista completa de transacoes
            transacoes = _transacaoService.Get<TransacaoModel>(new List<string> { "Advogado", "ClassificacaoTransacao" }).ToList();

            //Filtro para incluir data
            if (checkBoxIncluirData.Checked)
            {
                var dataInicio = dateTimePickerInicial.Value;
                var dataFinal = dateTimePickerFinal.Value;
                transacoes = transacoes
                    .Where(x => x.DataTransacao >= dataInicio && x.DataTransacao <= dataFinal)
                    .ToList();
            }

            //Filtro para incluir advogado
            if (checkBoxIncluirAdvogado.Checked)
            {

                if (int.TryParse(cboAdvogado.SelectedValue.ToString(), out var idAdvogado))
                {
                    var adv = _userService.GetById<Usuario>(idAdvogado);
                    transacoes = transacoes.Where(x => x.IdAdvogado == adv.Id).ToList();

                }

            }

            if (checkBoxIncluirTipoTransacao.Checked)
            {
                if (int.TryParse(cboTiposTransacao.SelectedValue.ToString(), out var idTipoTransacao))
                {
                    var classificacaoTransacao = _clasTransService.GetById<ClassificacaoTransacao>(idTipoTransacao);
                    transacoes = transacoes.Where(x => x.IdAgrupamento == classificacaoTransacao.Id).ToList();

                }

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
                lblTotalDespesas.Text = "Total Despesas: R$" + sumDespesas;
                lblTotalReceitas.Text = "Total Receitas: R$" + sumReceitas;

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

        private void ListarTransacoes_Enter(object sender, EventArgs e)
        {
            dateTimePickerFinal.Format = DateTimePickerFormat.Custom;
            dateTimePickerFinal.CustomFormat = "dd/MM/yyyy";
            dateTimePickerInicial.Format = DateTimePickerFormat.Custom;
            dateTimePickerInicial.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFinal.Value = DateTime.UtcNow.ToLocalTime();
            dateTimePickerInicial.Value = DateTime.UtcNow.ToLocalTime();
        }
    }
}
