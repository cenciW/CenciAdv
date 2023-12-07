using CenciAdv.App.Base;
using CenciAdv.App.Models;
using CenciAdv.Domain.Base;
using CenciAdv.Domain.Entities;
using CenciAdv.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenciAdv.App.Cadastros
{
    public partial class CadastroTransacao : CadastroBase
    {
        private readonly IBaseService<Transacao> _transacaoService;

        private readonly IBaseService<Usuario> _usuarioService;

        private readonly IBaseService<ClassificacaoTransacao> _clasTransService;

        private List<TransacaoModel>? transacoes;
        public CadastroTransacao(IBaseService<Transacao> transacaoService, IBaseService<Usuario> usuarioService, IBaseService<ClassificacaoTransacao> clasTransService)
        {


            _transacaoService = transacaoService;
            _usuarioService = usuarioService;
            _clasTransService = clasTransService;
            InitializeComponent();
            txtNomeAdvogado.Text = FormPrincipal.Usuario.Nome;
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboTiposTransacao.ValueMember = "NomeAgrupamento";
            cboTiposTransacao.DataSource = _clasTransService.Get<ClassificacaoTransacao>().ToList();

        }

        private void PreencheObjeto(Transacao transacao)
        {
            //valor desc data tipo
            //nunca vai ser nulo pq estou logado no sistema
            transacao.Advogado = FormPrincipal.Usuario;
            if (float.TryParse(txtValorTransacao.Text, out var valor))
            {
                transacao.Valor = valor;
            }
            transacao.DescricaoTransacao = txtDescricaoTransacao.Text;
            transacao.DataTransacao = dateTimePicker1.Value;


            transacao.ClassificacaoTransacao = (ClassificacaoTransacao)cboTiposTransacao.SelectedItem;

            if (radReceita.Checked == true)
            {
                transacao.TipoTransacao = true;
            }
            else if (radDespesa.Checked == false)
            {
                transacao.TipoTransacao = false;
            }


        }
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var transacao = _transacaoService.GetById<Transacao>(id);
                        transacao.Advogado = FormPrincipal.Usuario;
                        PreencheObjeto(transacao);
                        transacao = _transacaoService.Update<Transacao, Transacao, TransacaoValidator>(transacao);
                    }
                }
                else
                {
                    var transacao = new Transacao();
                    PreencheObjeto(transacao);
                    _transacaoService.Add<Transacao, Transacao, TransacaoValidator>(transacao);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Cenci Adv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _transacaoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Cenci Adv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // no cliente eu tenho cidade
        // no usuaario eu tenho transacao
        protected override void CarregaGrid()
        {
            transacoes = _transacaoService.Get<TransacaoModel>().ToList();
            dataGridViewConsulta.DataSource = transacoes;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;


            dataGridViewConsulta.Columns["DataTransacao"].HeaderText = "Data da transação";
            dataGridViewConsulta.Columns["DescricaoTransacao"].HeaderText = "Descrição";
            dataGridViewConsulta.Columns["IdAdvogado"].Visible = false;
            dataGridViewConsulta.Columns["NomeAdvogado"].HeaderText = "Advogado";
            dataGridViewConsulta.Columns["CodAgrupamento"].HeaderText = "Código do Agrupamento";
            dataGridViewConsulta.Columns["NomeAgrupamento"].HeaderText = "Nome do Agrupamento";
            dataGridViewConsulta.Columns["TipoAgrupamento"].Visible = false;
            dataGridViewConsulta.Columns["TipoTransacao"].Visible = false;



            // Adicione a nova coluna ao DataGridView (se ainda não foi adicionada)
            if (!dataGridViewConsulta.Columns.Contains("TipoTransacaoTxt"))
            {
                DataGridViewTextBoxColumn colunaTipoTransacaoTexto = new DataGridViewTextBoxColumn
                {
                    Name = "TipoTransacaoTxt",
                    HeaderText = "Tipo da Transação",
                    ValueType = typeof(string), // Set the value type to string
                };

                dataGridViewConsulta.Columns.Add(colunaTipoTransacaoTexto);
            }

            foreach (DataGridViewRow linha in dataGridViewConsulta.Rows)
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



            transacoes = _transacaoService.Get<TransacaoModel>(new List<string> { "Advogado", "ClassificacaoTransacao" }).ToList();
            dataGridViewConsulta.DataSource = transacoes;
            dataGridViewConsulta.Columns["DataTransacao"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["NomeAdvogado"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewConsulta.Columns["CodAgrupamento"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["NomeAgrupamento"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dataGridViewConsulta.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtDescricaoTransacao.Text = linha?.Cells["DescricaoTransacao"].Value.ToString();
            txtNomeAdvogado.Text = linha?.Cells["NomeAdvogado"].Value.ToString();
            txtValorTransacao.Text = linha?.Cells["Valor"].Value.ToString();
        }

        private void tabPageCadastro_Enter(object sender, EventArgs e)
        {
            txtNomeAdvogado.Text = FormPrincipal.Usuario.Nome;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value = DateTime.UtcNow.ToLocalTime();
        }
    }
}
