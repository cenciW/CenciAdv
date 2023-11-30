using CenciAdv.App.Base;
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
    public partial class CadastroTiposTransacao : CadastroBase
    {

        private readonly IBaseService<ClassificacaoTransacao> _clasTransService;
        private List<ClassificacaoTransacao>? tipos;

        public CadastroTiposTransacao(IBaseService<ClassificacaoTransacao> clasTransService)
        {
            _clasTransService= clasTransService;
            InitializeComponent();
        }

        private void PreencheObjeto(ClassificacaoTransacao ct)
        {
            ct.CodAgrupamento = txtCodAgrup.Text;
            ct.NomeAgrupamento = txtNomeAgrup.Text;
            if (radReceita.Checked == true)
                ct.Tipo = true;
            if (radReceita.Checked == true)
                ct.Tipo = false;

        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var ct = _clasTransService.GetById<ClassificacaoTransacao>(id);
                        PreencheObjeto(ct);
                        ct = _clasTransService.Update<ClassificacaoTransacao, ClassificacaoTransacao, ClassificacaoTransacaoValidator>(ct);
                    }
                }
                else
                {
                    var ct = new ClassificacaoTransacao();
                    PreencheObjeto(ct);
                    _clasTransService.Add<ClassificacaoTransacao, ClassificacaoTransacao, ClassificacaoTransacaoValidator>(ct);

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
                _clasTransService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Cenci Adv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            /*            CodAgrupamento= codTransacao;
            NomeAgrupamento= nomeAgrupamento;
            Tipo = tipo;*/
            tipos = _clasTransService.Get<ClassificacaoTransacao>().ToList();
            dataGridViewConsulta.DataSource = tipos;
            dataGridViewConsulta.Columns["CodAgrupamento"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["NomeAgrupamento"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Receita"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Despesa"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtCodAgrup.Text = linha?.Cells["CodAgrupamento"].Value.ToString();
            txtNomeAgrup.Text = linha?.Cells["NomeAgrupamento"].Value.ToString();
            if(radReceita.Checked)
            {

            }

            if(radDespesa.Checked)
            {

            }

        }

        private void radDespesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radReceita_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
