namespace CenciAdv.App.Cadastros
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.chkAtivo = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDataCadastro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDataLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(794, 383);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.chkAtivo);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtEmail);
            this.tabPageCadastro.Controls.Add(this.txtDataCadastro);
            this.tabPageCadastro.Controls.Add(this.txtDataLogin);
            this.tabPageCadastro.Controls.Add(this.txtSenha);
            this.tabPageCadastro.Controls.Add(this.txtLogin);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Size = new System.Drawing.Size(786, 348);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtLogin, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtSenha, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDataLogin, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtEmail, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.chkAtivo, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(504, 6);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(628, 6);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 297);
            this.panel1.Size = new System.Drawing.Size(780, 48);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "form.png");
            this.imageList1.Images.SetKeyName(1, "search.png");
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Depth = 0;
            this.chkAtivo.Location = new System.Drawing.Point(450, 127);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.chkAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAtivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.ReadOnly = false;
            this.chkAtivo.Ripple = true;
            this.chkAtivo.Size = new System.Drawing.Size(129, 37);
            this.chkAtivo.TabIndex = 20;
            this.chkAtivo.Text = "Usuário Ativo";
            this.chkAtivo.UseAccentColor = false;
            this.chkAtivo.UseVisualStyleBackColor = true;
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
            this.txtId.Location = new System.Drawing.Point(507, 19);
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
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(17, 127);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(380, 48);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.AnimateReadOnly = false;
            this.txtDataCadastro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDataCadastro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDataCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDataCadastro.Depth = 0;
            this.txtDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataCadastro.HideSelection = true;
            this.txtDataCadastro.Hint = "Data de Cadastro";
            this.txtDataCadastro.LeadingIcon = null;
            this.txtDataCadastro.Location = new System.Drawing.Point(17, 181);
            this.txtDataCadastro.MaxLength = 32767;
            this.txtDataCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.PasswordChar = '\0';
            this.txtDataCadastro.PrefixSuffixText = null;
            this.txtDataCadastro.ReadOnly = true;
            this.txtDataCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataCadastro.SelectedText = "";
            this.txtDataCadastro.SelectionLength = 0;
            this.txtDataCadastro.SelectionStart = 0;
            this.txtDataCadastro.ShortcutsEnabled = true;
            this.txtDataCadastro.Size = new System.Drawing.Size(268, 48);
            this.txtDataCadastro.TabIndex = 17;
            this.txtDataCadastro.TabStop = false;
            this.txtDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataCadastro.TrailingIcon = null;
            this.txtDataCadastro.UseSystemPasswordChar = false;
            // 
            // txtDataLogin
            // 
            this.txtDataLogin.AnimateReadOnly = false;
            this.txtDataLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDataLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDataLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDataLogin.Depth = 0;
            this.txtDataLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataLogin.HideSelection = true;
            this.txtDataLogin.Hint = "Data de Último Login";
            this.txtDataLogin.LeadingIcon = null;
            this.txtDataLogin.Location = new System.Drawing.Point(328, 181);
            this.txtDataLogin.MaxLength = 32767;
            this.txtDataLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataLogin.Name = "txtDataLogin";
            this.txtDataLogin.PasswordChar = '\0';
            this.txtDataLogin.PrefixSuffixText = null;
            this.txtDataLogin.ReadOnly = true;
            this.txtDataLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataLogin.SelectedText = "";
            this.txtDataLogin.SelectionLength = 0;
            this.txtDataLogin.SelectionStart = 0;
            this.txtDataLogin.ShortcutsEnabled = true;
            this.txtDataLogin.Size = new System.Drawing.Size(268, 48);
            this.txtDataLogin.TabIndex = 18;
            this.txtDataLogin.TabStop = false;
            this.txtDataLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataLogin.TrailingIcon = null;
            this.txtDataLogin.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.AnimateReadOnly = false;
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.HideSelection = true;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.LeadingIcon = null;
            this.txtSenha.Location = new System.Drawing.Point(419, 73);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PrefixSuffixText = null;
            this.txtSenha.ReadOnly = false;
            this.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(177, 48);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.TabStop = false;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.TrailingIcon = null;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            this.txtLogin.AnimateReadOnly = false;
            this.txtLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLogin.Depth = 0;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogin.HideSelection = true;
            this.txtLogin.Hint = "Login";
            this.txtLogin.LeadingIcon = null;
            this.txtLogin.Location = new System.Drawing.Point(17, 73);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PrefixSuffixText = null;
            this.txtLogin.ReadOnly = false;
            this.txtLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(380, 48);
            this.txtLogin.TabIndex = 14;
            this.txtLogin.TabStop = false;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogin.TrailingIcon = null;
            this.txtLogin.UseSystemPasswordChar = false;
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
            this.txtNome.Location = new System.Drawing.Point(17, 19);
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
            this.txtNome.Size = new System.Drawing.Size(484, 48);
            this.txtNome.TabIndex = 13;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroUsuario";
            this.Text = "Cadastro de Usuarios";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCheckBox chkAtivo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDataCadastro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDataLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}