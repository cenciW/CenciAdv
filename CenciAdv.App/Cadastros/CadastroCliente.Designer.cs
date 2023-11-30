namespace CenciAdv.App.Cadastros
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboCidade = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtCpf = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(876, 508);
            this.materialTabControl.SelectedIndexChanged += new System.EventHandler(this.materialTabControl_SelectedIndexChanged);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtTelefone);
            this.tabPageCadastro.Controls.Add(this.txtCpf);
            this.tabPageCadastro.Controls.Add(this.txtBairro);
            this.tabPageCadastro.Controls.Add(this.cboCidade);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtEndereco);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Size = new System.Drawing.Size(868, 473);
            this.tabPageCadastro.Click += new System.EventHandler(this.tabPageCadastro_Click);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtEndereco, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboCidade, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtBairro, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtCpf, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtTelefone, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.Location = new System.Drawing.Point(560, 6);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = false;
            this.btnSalvar.Location = new System.Drawing.Point(684, 6);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 422);
            this.panel1.Size = new System.Drawing.Size(862, 48);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "form.png");
            this.imageList1.Images.SetKeyName(1, "search.png");
            // 
            // txtBairro
            // 
            this.txtBairro.AnimateReadOnly = false;
            this.txtBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBairro.Depth = 0;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBairro.HideSelection = true;
            this.txtBairro.Hint = "Bairro";
            this.txtBairro.LeadingIcon = null;
            this.txtBairro.Location = new System.Drawing.Point(6, 253);
            this.txtBairro.MaxLength = 32767;
            this.txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.PrefixSuffixText = null;
            this.txtBairro.ReadOnly = false;
            this.txtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.Size = new System.Drawing.Size(658, 48);
            this.txtBairro.TabIndex = 8;
            this.txtBairro.TabStop = false;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBairro.TrailingIcon = null;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // cboCidade
            // 
            this.cboCidade.AutoResize = false;
            this.cboCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCidade.Depth = 0;
            this.cboCidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCidade.DropDownHeight = 174;
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.DropDownWidth = 121;
            this.cboCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Hint = "Cidade";
            this.cboCidade.IntegralHeight = false;
            this.cboCidade.ItemHeight = 43;
            this.cboCidade.Location = new System.Drawing.Point(6, 317);
            this.cboCidade.MaxDropDownItems = 4;
            this.cboCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(658, 49);
            this.cboCidade.StartIndex = 0;
            this.cboCidade.TabIndex = 9;
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
            this.txtId.Location = new System.Drawing.Point(683, 6);
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
            this.txtId.TabIndex = 6;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.AnimateReadOnly = false;
            this.txtEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndereco.HideSelection = true;
            this.txtEndereco.Hint = "Endereço";
            this.txtEndereco.LeadingIcon = null;
            this.txtEndereco.Location = new System.Drawing.Point(6, 188);
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PrefixSuffixText = null;
            this.txtEndereco.ReadOnly = false;
            this.txtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.ShortcutsEnabled = true;
            this.txtEndereco.Size = new System.Drawing.Size(658, 48);
            this.txtEndereco.TabIndex = 7;
            this.txtEndereco.TabStop = false;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEndereco.TrailingIcon = null;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(6, 6);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(658, 48);
            this.txtNome.TabIndex = 5;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtCpf
            // 
            this.txtCpf.AllowPromptAsInput = true;
            this.txtCpf.AnimateReadOnly = false;
            this.txtCpf.AsciiOnly = false;
            this.txtCpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCpf.BeepOnError = false;
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCpf.Depth = 0;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCpf.HidePromptOnLeave = false;
            this.txtCpf.HideSelection = true;
            this.txtCpf.Hint = "CPF";
            this.txtCpf.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCpf.LeadingIcon = null;
            this.txtCpf.Location = new System.Drawing.Point(6, 66);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.MaxLength = 32767;
            this.txtCpf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.PrefixSuffixText = null;
            this.txtCpf.PromptChar = '_';
            this.txtCpf.ReadOnly = false;
            this.txtCpf.RejectInputOnFirstFailure = false;
            this.txtCpf.ResetOnPrompt = true;
            this.txtCpf.ResetOnSpace = true;
            this.txtCpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.ShortcutsEnabled = true;
            this.txtCpf.Size = new System.Drawing.Size(658, 48);
            this.txtCpf.SkipLiterals = true;
            this.txtCpf.TabIndex = 10;
            this.txtCpf.TabStop = false;
            this.txtCpf.Text = "   ,   ,   -";
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCpf.TrailingIcon = null;
            this.txtCpf.UseSystemPasswordChar = false;
            this.txtCpf.ValidatingType = null;
            // 
            // txtTelefone
            // 
            this.txtTelefone.AllowPromptAsInput = true;
            this.txtTelefone.AnimateReadOnly = false;
            this.txtTelefone.AsciiOnly = false;
            this.txtTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefone.BeepOnError = false;
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefone.HidePromptOnLeave = false;
            this.txtTelefone.HideSelection = true;
            this.txtTelefone.Hint = "Telefone";
            this.txtTelefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTelefone.LeadingIcon = null;
            this.txtTelefone.Location = new System.Drawing.Point(6, 120);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PrefixSuffixText = null;
            this.txtTelefone.PromptChar = '_';
            this.txtTelefone.ReadOnly = false;
            this.txtTelefone.RejectInputOnFirstFailure = false;
            this.txtTelefone.ResetOnPrompt = true;
            this.txtTelefone.ResetOnSpace = true;
            this.txtTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(658, 48);
            this.txtTelefone.SkipLiterals = true;
            this.txtTelefone.TabIndex = 11;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.Text = "(  )      -";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTelefone.TrailingIcon = null;
            this.txtTelefone.UseSystemPasswordChar = false;
            this.txtTelefone.ValidatingType = null;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 575);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCpf;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialComboBox cboCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}