﻿using CenciAdv.App.Base;
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

        private List<ClienteModel>? clientes;
        private List<UsuarioModel>? advogados;

        public CadastroConsulta(IBaseService<Cliente> clienteService, IBaseService<Usuario> userService, IBaseService<Consulta> consultaService)
        {
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
        }

        private void PreencheObjeto(Consulta consulta)
        {
            consulta.Data = dateTimePicker1.Value;

            if (cboAdvogado.SelectedItem != null && cboAdvogado.SelectedValue != null)
            {
                if (int.TryParse(cboAdvogado.SelectedValue.ToString(), out var idAdvogado))
                {
                    var advogado = _userService.GetById<Usuario>(idAdvogado);
                    consulta.Advogado = advogado;
                }
            }

            if (cboCliente.SelectedItem != null && cboCliente.SelectedValue != null)
            {
                if (int.TryParse(cboCliente.SelectedValue.ToString(), out var idCliente))
                {
                    var cliente = _clienteService.GetById<Cliente>(idCliente);
                    consulta.Cliente = cliente;
                }
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
                    var consulta = new Consulta();
                    PreencheObjeto(consulta);
                    _consultaService.Add<Consulta, Consulta, ConsultaValidator>(consulta);

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
            advogados = _userService.Get<UsuarioModel>(new[] { "Advogado" }).ToList();
            dataGridViewConsulta.DataSource = advogados;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdAdvogado"]!.Visible = false;

            clientes = _clienteService.Get<ClienteModel>(new[] { "Cliente" }).ToList();
            dataGridViewConsulta.DataSource = clientes;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdCliente"]!.Visible = false;
        }

    }
}
