using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;


namespace CenciAdv.App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        public CadastroBase()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void tabPageConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"Cenci Adv", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                LimpaCampos();
                materialTabControl.SelectedIndex = 1;
            }
        }

        #region CRUD Methods
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
        protected virtual void CarregaGrid()
        {

        }

        protected virtual void Novo()
        {
            LimpaCampos();
            materialTabControl.SelectedIndex = 0;
            tabPageCadastro.Focus();
        }

        protected virtual void Salvar()
        {

        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                materialTabControl.SelectedIndex = 0;
                tabPageCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Cenci Adv", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente deletar?", @"Cenci Adv", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Cenci Adv", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void materialTabControl_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridViewConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }


    }
}
