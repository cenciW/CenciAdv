using CenciAdv.App.Base;
using CenciAdv.App.Models;
using CenciAdv.Domain.Base;
using CenciAdv.Domain.Entities;
using CenciAdv.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenciAdv.App.Cadastros
{
    public partial class CadastroConsulta : CadastroBase
    {

        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Usuario> _userService;
        private readonly IBaseService<Consulta> _consultaService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<ClienteModel>? clientes;
        private List<ConsultaModel>? consultas;
        private List<UsuarioModel>? advogados;

        public CadastroConsulta(IBaseService<Cliente> clienteService, IBaseService<Usuario> userService
            , IBaseService<Consulta> consultaService, IBaseService<Cidade> cidadeService)
        {
            _cidadeService = cidadeService;
            _clienteService = clienteService;
            _userService = userService;
            _consultaService = consultaService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboAdvogado.ValueMember = "Id";
            cboAdvogado.DisplayMember = "Nome";
            cboAdvogado.DataSource = _userService.Get<UsuarioModel>().ToList();

            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "NomeFone";
            cboCliente.DataSource = _clienteService.Get<ClienteModel>().ToList();


            dateTimePicker1.Value = DateTime.UtcNow.ToLocalTime();
        }

        private void PreencheObjeto(Consulta consulta)
        {

            if (int.TryParse(cboAdvogado.SelectedValue.ToString(), out var idAdvogado))
            {
                var adv = _userService.GetById<Usuario>(idAdvogado);
                consulta.Advogado = adv;
            }

            if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
            {
                var cli = _clienteService.GetById<Cliente>(idCliente);
                consulta.Cliente = cli;
            }

            consulta.Data = dateTimePicker1.Value;

            //consulta.Data = DateTime.UtcNow.ToLocalTime();

        }

        private bool existeConsulta()
        {
            var x = _consultaService.Get<Consulta>().Where(x => x.Data == dateTimePicker1.Value).FirstOrDefault();
            if(x != null)
            {
                return true;
            }
            else
            {
                return false;
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
                        var consulta = _consultaService.GetById<Consulta>(id);
                        PreencheObjeto(consulta);
                        _consultaService.Update<Consulta, Consulta, ConsultaValidator>(consulta);
                    }
                }
                else
                {
                    if (existeConsulta())
                    {
                        MessageBox.Show("Não há como cadastrar duas consultas no mesmo horário.", @"Cenci Adv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var consulta = new Consulta();
                        PreencheObjeto(consulta);
                        _consultaService.Add<Consulta, Consulta, ConsultaValidator>(consulta);
                    }

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
                _consultaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Cenci Adv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {

            consultas = _consultaService.Get<ConsultaModel>(new List<string> { "Advogado", "Cliente" }).ToList();
            dataGridViewConsulta.DataSource = consultas;
            dataGridViewConsulta.Columns["Data"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["NomeAdvogado"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["NomeCliente"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["IdAdvogado"]!.Visible = false;
            dataGridViewConsulta.Columns["IdCliente"]!.Visible = false;

            dataGridViewConsulta.Columns["NomeAdvogado"].HeaderText = "Nome do Advogado";
            dataGridViewConsulta.Columns["NomeCliente"].HeaderText = "Nome do Cliente";
            dataGridViewConsulta.Columns["Data"].HeaderText = "Data da Consulta";
        }
    }
}
