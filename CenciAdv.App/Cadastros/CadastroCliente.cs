using CenciAdv.App.Base;
using CenciAdv.App.Models;
using CenciAdv.Domain.Base;
using CenciAdv.Domain.Entities;
using CenciAdv.Service.Validators;
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
    public partial class CadastroCliente : CadastroBase
    {
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<ClienteModel>? clientes;

        public CadastroCliente(IBaseService<Cliente> clienteService, IBaseService<Cidade> cidadeService)
        {
            _clienteService = clienteService;
            _cidadeService = cidadeService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "NomeEstado";
            cboCidade.DataSource = _cidadeService.Get<CidadeModel>().ToList();
        }

        private void PreencheObjeto(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;

            if (int.TryParse(cboCidade.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                cliente.Cidade = cidade;
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
                        var cliente = _clienteService.GetById<Cliente>(id);
                        PreencheObjeto(cliente);
                        _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }
                }
                else
                {
                    var cliente = new Cliente();
                    PreencheObjeto(cliente);
                    _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);

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
                _clienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Cenci Adv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            clientes = _clienteService.Get<ClienteModel>(new[] { "Cidade" }).ToList();
            dataGridViewConsulta.DataSource = clientes;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["CidadeId"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeFone"]!.Visible = false;

            dataGridViewConsulta.Columns["Id"].Visible = false;
            dataGridViewConsulta.Columns["Cpf"].HeaderText = "CPF";
            dataGridViewConsulta.Columns["NomeCidade"].HeaderText = "Cidade / Estado";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtCpf.Text = linha?.Cells["Cpf"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            cboCidade.SelectedValue = linha?.Cells["IdCidade"].Value;


        }

        private void tabPageCadastro_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
