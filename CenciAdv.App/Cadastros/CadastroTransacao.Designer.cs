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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescricaoTransacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboTiposTransacao = new ReaLTaiizor.Controls.MaterialComboBox();
            txtValorTransacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            radDespesa = new ReaLTaiizor.Controls.MaterialRadioButton();
            radReceita = new ReaLTaiizor.Controls.MaterialRadioButton();
            txtNomeAdvogado = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dateTimePicker1 = new DateTimePicker();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
        
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 371);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(materialLabel1);
            tabPageCadastro.Controls.Add(dateTimePicker1);
            tabPageCadastro.Controls.Add(txtNomeAdvogado);
            tabPageCadastro.Controls.Add(radReceita);
            tabPageCadastro.Controls.Add(radDespesa);
            tabPageCadastro.Controls.Add(txtValorTransacao);
            tabPageCadastro.Controls.Add(cboTiposTransacao);
            tabPageCadastro.Controls.Add(txtDescricaoTransacao);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(786, 336);
            tabPageCadastro.Enter += tabPageCadastro_Enter;
            
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricaoTransacao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTiposTransacao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtValorTransacao, 0);
            tabPageCadastro.Controls.SetChildIndex(radDespesa, 0);
            tabPageCadastro.Controls.SetChildIndex(radReceita, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNomeAdvogado, 0);
            tabPageCadastro.Controls.SetChildIndex(dateTimePicker1, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel1, 0);
            // 
           
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
          
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(598, 11);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(89, 48);
            txtId.TabIndex = 19;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtDescricaoTransacao
            // 
            txtDescricaoTransacao.AnimateReadOnly = false;
            txtDescricaoTransacao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricaoTransacao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricaoTransacao.BackgroundImageLayout = ImageLayout.None;
            txtDescricaoTransacao.CharacterCasing = CharacterCasing.Normal;
            txtDescricaoTransacao.Depth = 0;
            txtDescricaoTransacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricaoTransacao.HideSelection = true;
            txtDescricaoTransacao.Hint = "Descrição Transação";
            txtDescricaoTransacao.LeadingIcon = null;
            txtDescricaoTransacao.Location = new Point(6, 126);
            txtDescricaoTransacao.MaxLength = 32767;
            txtDescricaoTransacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricaoTransacao.Name = "txtDescricaoTransacao";
            txtDescricaoTransacao.PasswordChar = '\0';
            txtDescricaoTransacao.PrefixSuffixText = null;
            txtDescricaoTransacao.ReadOnly = false;
            txtDescricaoTransacao.RightToLeft = RightToLeft.No;
            txtDescricaoTransacao.SelectedText = "";
            txtDescricaoTransacao.SelectionLength = 0;
            txtDescricaoTransacao.SelectionStart = 0;
            txtDescricaoTransacao.ShortcutsEnabled = true;
            txtDescricaoTransacao.Size = new Size(548, 48);
            txtDescricaoTransacao.TabIndex = 20;
            txtDescricaoTransacao.TabStop = false;
            txtDescricaoTransacao.TextAlign = HorizontalAlignment.Left;
            txtDescricaoTransacao.TrailingIcon = null;
            txtDescricaoTransacao.UseSystemPasswordChar = false;
            // 
            // cboTiposTransacao
            // 
            cboTiposTransacao.AutoResize = false;
            cboTiposTransacao.BackColor = Color.FromArgb(255, 255, 255);
            cboTiposTransacao.Depth = 0;
            cboTiposTransacao.DrawMode = DrawMode.OwnerDrawVariable;
            cboTiposTransacao.DropDownHeight = 174;
            cboTiposTransacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTiposTransacao.DropDownWidth = 121;
            cboTiposTransacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTiposTransacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTiposTransacao.FormattingEnabled = true;
            cboTiposTransacao.Hint = "Tipo Transacao";
            cboTiposTransacao.IntegralHeight = false;
            cboTiposTransacao.ItemHeight = 43;
            cboTiposTransacao.Location = new Point(456, 218);
            cboTiposTransacao.MaxDropDownItems = 4;
            cboTiposTransacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTiposTransacao.Name = "cboTiposTransacao";
            cboTiposTransacao.Size = new Size(234, 49);
            cboTiposTransacao.StartIndex = 0;
            cboTiposTransacao.TabIndex = 24;
            // 
            // txtValorTransacao
            // 
            txtValorTransacao.AnimateReadOnly = false;
            txtValorTransacao.AutoCompleteMode = AutoCompleteMode.None;
            txtValorTransacao.AutoCompleteSource = AutoCompleteSource.None;
            txtValorTransacao.BackgroundImageLayout = ImageLayout.None;
            txtValorTransacao.CharacterCasing = CharacterCasing.Normal;
            txtValorTransacao.Depth = 0;
            txtValorTransacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorTransacao.HideSelection = true;
            txtValorTransacao.Hint = "Valor Transação";
            txtValorTransacao.LeadingIcon = null;
            txtValorTransacao.Location = new Point(6, 72);
            txtValorTransacao.MaxLength = 32767;
            txtValorTransacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorTransacao.Name = "txtValorTransacao";
            txtValorTransacao.PasswordChar = '\0';
            txtValorTransacao.PrefixSuffixText = null;
            txtValorTransacao.ReadOnly = false;
            txtValorTransacao.RightToLeft = RightToLeft.No;
            txtValorTransacao.SelectedText = "";
            txtValorTransacao.SelectionLength = 0;
            txtValorTransacao.SelectionStart = 0;
            txtValorTransacao.ShortcutsEnabled = true;
            txtValorTransacao.Size = new Size(548, 48);
            txtValorTransacao.TabIndex = 25;
            txtValorTransacao.TabStop = false;
            txtValorTransacao.TextAlign = HorizontalAlignment.Left;
            txtValorTransacao.TrailingIcon = null;
            txtValorTransacao.UseSystemPasswordChar = false;
            // 
            // radDespesa
            // 
            radDespesa.AutoSize = true;
            radDespesa.Depth = 0;
            radDespesa.Location = new Point(594, 89);
            radDespesa.Margin = new Padding(0);
            radDespesa.MouseLocation = new Point(-1, -1);
            radDespesa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            radDespesa.Name = "radDespesa";
            radDespesa.Ripple = true;
            radDespesa.Size = new Size(96, 37);
            radDespesa.TabIndex = 26;
            radDespesa.TabStop = true;
            radDespesa.Text = "Despesa";
            radDespesa.UseAccentColor = false;
            radDespesa.UseVisualStyleBackColor = true;
            // 
            // radReceita
            // 
            radReceita.AutoSize = true;
            radReceita.Depth = 0;
            radReceita.Location = new Point(596, 132);
            radReceita.Margin = new Padding(0);
            radReceita.MouseLocation = new Point(-1, -1);
            radReceita.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            radReceita.Name = "radReceita";
            radReceita.Ripple = true;
            radReceita.Size = new Size(91, 37);
            radReceita.TabIndex = 27;
            radReceita.TabStop = true;
            radReceita.Text = "Receita ";
            radReceita.UseAccentColor = false;
            radReceita.UseVisualStyleBackColor = true;
            // 
            // txtNomeAdvogado
            // 
            txtNomeAdvogado.AnimateReadOnly = false;
            txtNomeAdvogado.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeAdvogado.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeAdvogado.BackgroundImageLayout = ImageLayout.None;
            txtNomeAdvogado.CharacterCasing = CharacterCasing.Normal;
            txtNomeAdvogado.Depth = 0;
            txtNomeAdvogado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeAdvogado.HideSelection = true;
            txtNomeAdvogado.Hint = "Advogado";
            txtNomeAdvogado.LeadingIcon = null;
            txtNomeAdvogado.Location = new Point(6, 18);
            txtNomeAdvogado.MaxLength = 32767;
            txtNomeAdvogado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeAdvogado.Name = "txtNomeAdvogado";
            txtNomeAdvogado.PasswordChar = '\0';
            txtNomeAdvogado.PrefixSuffixText = null;
            txtNomeAdvogado.ReadOnly = true;
            txtNomeAdvogado.RightToLeft = RightToLeft.No;
            txtNomeAdvogado.SelectedText = "";
            txtNomeAdvogado.SelectionLength = 0;
            txtNomeAdvogado.SelectionStart = 0;
            txtNomeAdvogado.ShortcutsEnabled = true;
            txtNomeAdvogado.Size = new Size(548, 48);
            txtNomeAdvogado.TabIndex = 28;
            txtNomeAdvogado.TabStop = false;
            txtNomeAdvogado.TextAlign = HorizontalAlignment.Left;
            txtNomeAdvogado.TrailingIcon = null;
            txtNomeAdvogado.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(6, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(427, 43);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 200);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(141, 19);
            materialLabel1.TabIndex = 30;
            materialLabel1.Text = "Data da Transação:";
            // 
            // CadastroTransacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 438);
            Location = new Point(0, 0);
            Name = "CadastroTransacao";
            Text = "Cadastro de Transações";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
          
            tabPageConsulta.ResumeLayout(false);
            ResumeLayout(false);
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