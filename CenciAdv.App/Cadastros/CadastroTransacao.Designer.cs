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
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDescricaoTransacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboTiposTransacao = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtValorTransacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.radDespesa = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.radReceita = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.txtNomeAdvogado = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
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
            this.tabPageCadastro.Controls.Add(this.materialLabel1);
            this.tabPageCadastro.Controls.Add(this.dateTimePicker1);
            this.tabPageCadastro.Controls.Add(this.txtNomeAdvogado);
            this.tabPageCadastro.Controls.Add(this.radReceita);
            this.tabPageCadastro.Controls.Add(this.radDespesa);
            this.tabPageCadastro.Controls.Add(this.txtValorTransacao);
            this.tabPageCadastro.Controls.Add(this.cboTiposTransacao);
            this.tabPageCadastro.Controls.Add(this.txtDescricaoTransacao);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Size = new System.Drawing.Size(974, 336);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDescricaoTransacao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboTiposTransacao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtValorTransacao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.radDespesa, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.radReceita, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNomeAdvogado, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.materialLabel1, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(689, 6);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(813, 6);
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
            this.cboTiposTransacao.Location = new System.Drawing.Point(463, 216);
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
            // txtNomeAdvogado
            // 
            this.txtNomeAdvogado.AnimateReadOnly = false;
            this.txtNomeAdvogado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeAdvogado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeAdvogado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomeAdvogado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeAdvogado.Depth = 0;
            this.txtNomeAdvogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeAdvogado.HideSelection = true;
            this.txtNomeAdvogado.Hint = "Advogado";
            this.txtNomeAdvogado.LeadingIcon = null;
            this.txtNomeAdvogado.Location = new System.Drawing.Point(6, 18);
            this.txtNomeAdvogado.MaxLength = 32767;
            this.txtNomeAdvogado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNomeAdvogado.Name = "txtNomeAdvogado";
            this.txtNomeAdvogado.PasswordChar = '\0';
            this.txtNomeAdvogado.PrefixSuffixText = null;
            this.txtNomeAdvogado.ReadOnly = true;
            this.txtNomeAdvogado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomeAdvogado.SelectedText = "";
            this.txtNomeAdvogado.SelectionLength = 0;
            this.txtNomeAdvogado.SelectionStart = 0;
            this.txtNomeAdvogado.ShortcutsEnabled = true;
            this.txtNomeAdvogado.Size = new System.Drawing.Size(548, 48);
            this.txtNomeAdvogado.TabIndex = 28;
            this.txtNomeAdvogado.TabStop = false;
            this.txtNomeAdvogado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomeAdvogado.TrailingIcon = null;
            this.txtNomeAdvogado.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(427, 43);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 30, 0, 0, 0, 0);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 200);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(141, 19);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Data da Transação:";
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
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricaoTransacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboTiposTransacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorTransacao;
        private ReaLTaiizor.Controls.MaterialRadioButton radReceita;
        private ReaLTaiizor.Controls.MaterialRadioButton radDespesa;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeAdvogado;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private DateTimePicker dateTimePicker1;
    }
}