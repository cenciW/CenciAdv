namespace CenciAdv.App.Cadastros
{
    partial class CadastroTransacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTransacao));
            this.txtDataTransacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDescricaoTransacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboAdvogado = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboTiposTransacao = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtValorTransacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.radDespesa = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.radReceita = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(982, 371);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.radReceita);
            this.tabPageCadastro.Controls.Add(this.radDespesa);
            this.tabPageCadastro.Controls.Add(this.txtValorTransacao);
            this.tabPageCadastro.Controls.Add(this.cboTiposTransacao);
            this.tabPageCadastro.Controls.Add(this.cboAdvogado);
            this.tabPageCadastro.Controls.Add(this.txtDescricaoTransacao);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtDataTransacao);
            this.tabPageCadastro.Size = new System.Drawing.Size(974, 336);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDataTransacao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDescricaoTransacao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboAdvogado, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboTiposTransacao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtValorTransacao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.radDespesa, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.radReceita, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(685, 6);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(809, 6);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 285);
            this.panel1.Size = new System.Drawing.Size(968, 48);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "form.png");
            this.imageList1.Images.SetKeyName(1, "search.png");
            // 
            // txtDataTransacao
            // 
            this.txtDataTransacao.AnimateReadOnly = false;
            this.txtDataTransacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDataTransacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDataTransacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataTransacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDataTransacao.Depth = 0;
            this.txtDataTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataTransacao.HideSelection = true;
            this.txtDataTransacao.Hint = "Data da Transacao";
            this.txtDataTransacao.LeadingIcon = null;
            this.txtDataTransacao.Location = new System.Drawing.Point(6, 197);
            this.txtDataTransacao.MaxLength = 32767;
            this.txtDataTransacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataTransacao.Name = "txtDataTransacao";
            this.txtDataTransacao.PasswordChar = '\0';
            this.txtDataTransacao.PrefixSuffixText = null;
            this.txtDataTransacao.ReadOnly = true;
            this.txtDataTransacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataTransacao.SelectedText = "";
            this.txtDataTransacao.SelectionLength = 0;
            this.txtDataTransacao.SelectionStart = 0;
            this.txtDataTransacao.ShortcutsEnabled = true;
            this.txtDataTransacao.Size = new System.Drawing.Size(434, 48);
            this.txtDataTransacao.TabIndex = 18;
            this.txtDataTransacao.TabStop = false;
            this.txtDataTransacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataTransacao.TrailingIcon = null;
            this.txtDataTransacao.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "Id";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(688, 8);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(89, 48);
            this.txtId.TabIndex = 19;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // txtDescricaoTransacao
            // 
            this.txtDescricaoTransacao.AnimateReadOnly = false;
            this.txtDescricaoTransacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescricaoTransacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescricaoTransacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescricaoTransacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescricaoTransacao.Depth = 0;
            this.txtDescricaoTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricaoTransacao.HideSelection = true;
            this.txtDescricaoTransacao.Hint = "Descrição Transação";
            this.txtDescricaoTransacao.LeadingIcon = null;
            this.txtDescricaoTransacao.Location = new System.Drawing.Point(6, 126);
            this.txtDescricaoTransacao.MaxLength = 32767;
            this.txtDescricaoTransacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDescricaoTransacao.Name = "txtDescricaoTransacao";
            this.txtDescricaoTransacao.PasswordChar = '\0';
            this.txtDescricaoTransacao.PrefixSuffixText = null;
            this.txtDescricaoTransacao.ReadOnly = false;
            this.txtDescricaoTransacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescricaoTransacao.SelectedText = "";
            this.txtDescricaoTransacao.SelectionLength = 0;
            this.txtDescricaoTransacao.SelectionStart = 0;
            this.txtDescricaoTransacao.ShortcutsEnabled = true;
            this.txtDescricaoTransacao.Size = new System.Drawing.Size(548, 48);
            this.txtDescricaoTransacao.TabIndex = 20;
            this.txtDescricaoTransacao.TabStop = false;
            this.txtDescricaoTransacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricaoTransacao.TrailingIcon = null;
            this.txtDescricaoTransacao.UseSystemPasswordChar = false;
            // 
            // cboAdvogado
            // 
            this.cboAdvogado.AutoResize = false;
            this.cboAdvogado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboAdvogado.Depth = 0;
            this.cboAdvogado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAdvogado.DropDownHeight = 174;
            this.cboAdvogado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdvogado.DropDownWidth = 121;
            this.cboAdvogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboAdvogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboAdvogado.FormattingEnabled = true;
            this.cboAdvogado.Hint = "Advogado";
            this.cboAdvogado.IntegralHeight = false;
            this.cboAdvogado.ItemHeight = 43;
            this.cboAdvogado.Location = new System.Drawing.Point(6, 8);
            this.cboAdvogado.MaxDropDownItems = 4;
            this.cboAdvogado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboAdvogado.Name = "cboAdvogado";
            this.cboAdvogado.Size = new System.Drawing.Size(658, 49);
            this.cboAdvogado.StartIndex = 0;
            this.cboAdvogado.TabIndex = 22;
            // 
            // cboTiposTransacao
            // 
            this.cboTiposTransacao.AutoResize = false;
            this.cboTiposTransacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTiposTransacao.Depth = 0;
            this.cboTiposTransacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTiposTransacao.DropDownHeight = 174;
            this.cboTiposTransacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiposTransacao.DropDownWidth = 121;
            this.cboTiposTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTiposTransacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTiposTransacao.FormattingEnabled = true;
            this.cboTiposTransacao.Hint = "Tipo Transacao";
            this.cboTiposTransacao.IntegralHeight = false;
            this.cboTiposTransacao.ItemHeight = 43;
            this.cboTiposTransacao.Location = new System.Drawing.Point(446, 196);
            this.cboTiposTransacao.MaxDropDownItems = 4;
            this.cboTiposTransacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTiposTransacao.Name = "cboTiposTransacao";
            this.cboTiposTransacao.Size = new System.Drawing.Size(334, 49);
            this.cboTiposTransacao.StartIndex = 0;
            this.cboTiposTransacao.TabIndex = 24;
            // 
            // txtValorTransacao
            // 
            this.txtValorTransacao.AnimateReadOnly = false;
            this.txtValorTransacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtValorTransacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtValorTransacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtValorTransacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValorTransacao.Depth = 0;
            this.txtValorTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorTransacao.HideSelection = true;
            this.txtValorTransacao.Hint = "Valor Transação";
            this.txtValorTransacao.LeadingIcon = null;
            this.txtValorTransacao.Location = new System.Drawing.Point(6, 72);
            this.txtValorTransacao.MaxLength = 32767;
            this.txtValorTransacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtValorTransacao.Name = "txtValorTransacao";
            this.txtValorTransacao.PasswordChar = '\0';
            this.txtValorTransacao.PrefixSuffixText = null;
            this.txtValorTransacao.ReadOnly = false;
            this.txtValorTransacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValorTransacao.SelectedText = "";
            this.txtValorTransacao.SelectionLength = 0;
            this.txtValorTransacao.SelectionStart = 0;
            this.txtValorTransacao.ShortcutsEnabled = true;
            this.txtValorTransacao.Size = new System.Drawing.Size(548, 48);
            this.txtValorTransacao.TabIndex = 25;
            this.txtValorTransacao.TabStop = false;
            this.txtValorTransacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValorTransacao.TrailingIcon = null;
            this.txtValorTransacao.UseSystemPasswordChar = false;
            // 
            // radDespesa
            // 
            this.radDespesa.AutoSize = true;
            this.radDespesa.Depth = 0;
            this.radDespesa.Location = new System.Drawing.Point(648, 86);
            this.radDespesa.Margin = new System.Windows.Forms.Padding(0);
            this.radDespesa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radDespesa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.radDespesa.Name = "radDespesa";
            this.radDespesa.Ripple = true;
            this.radDespesa.Size = new System.Drawing.Size(96, 37);
            this.radDespesa.TabIndex = 26;
            this.radDespesa.TabStop = true;
            this.radDespesa.Text = "Despesa";
            this.radDespesa.UseAccentColor = false;
            this.radDespesa.UseVisualStyleBackColor = true;
            // 
            // radReceita
            // 
            this.radReceita.AutoSize = true;
            this.radReceita.Depth = 0;
            this.radReceita.Location = new System.Drawing.Point(648, 129);
            this.radReceita.Margin = new System.Windows.Forms.Padding(0);
            this.radReceita.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radReceita.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.radReceita.Name = "radReceita";
            this.radReceita.Ripple = true;
            this.radReceita.Size = new System.Drawing.Size(91, 37);
            this.radReceita.TabIndex = 27;
            this.radReceita.TabStop = true;
            this.radReceita.Text = "Receita ";
            this.radReceita.UseAccentColor = false;
            this.radReceita.UseVisualStyleBackColor = true;
            // 
            // CadastroTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 438);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroTransacao";
            this.Text = "Cadastro de Transações";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDataTransacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricaoTransacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboTiposTransacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboAdvogado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorTransacao;
        private ReaLTaiizor.Controls.MaterialRadioButton radReceita;
        private ReaLTaiizor.Controls.MaterialRadioButton radDespesa;
    }
}