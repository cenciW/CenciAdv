namespace CenciAdv.App.Cadastros
{
    partial class CadastroTiposTransacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTiposTransacao));
            this.txtCodAgrup = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNomeAgrup = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.radReceita = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.radDespesa = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(846, 238);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.radReceita);
            this.tabPageCadastro.Controls.Add(this.radDespesa);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtNomeAgrup);
            this.tabPageCadastro.Controls.Add(this.txtCodAgrup);
            this.tabPageCadastro.Size = new System.Drawing.Size(838, 203);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtCodAgrup, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNomeAgrup, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.radDespesa, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.radReceita, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(535, 6);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(659, 6);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 152);
            this.panel1.Size = new System.Drawing.Size(832, 48);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "form.png");
            this.imageList1.Images.SetKeyName(1, "search.png");
            // 
            // txtCodAgrup
            // 
            this.txtCodAgrup.AnimateReadOnly = false;
            this.txtCodAgrup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCodAgrup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCodAgrup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodAgrup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodAgrup.Depth = 0;
            this.txtCodAgrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodAgrup.HideSelection = true;
            this.txtCodAgrup.Hint = "Código do Agrupamento";
            this.txtCodAgrup.LeadingIcon = null;
            this.txtCodAgrup.Location = new System.Drawing.Point(6, 18);
            this.txtCodAgrup.MaxLength = 32767;
            this.txtCodAgrup.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCodAgrup.Name = "txtCodAgrup";
            this.txtCodAgrup.PasswordChar = '\0';
            this.txtCodAgrup.PrefixSuffixText = null;
            this.txtCodAgrup.ReadOnly = false;
            this.txtCodAgrup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodAgrup.SelectedText = "";
            this.txtCodAgrup.SelectionLength = 0;
            this.txtCodAgrup.SelectionStart = 0;
            this.txtCodAgrup.ShortcutsEnabled = true;
            this.txtCodAgrup.Size = new System.Drawing.Size(661, 48);
            this.txtCodAgrup.TabIndex = 5;
            this.txtCodAgrup.TabStop = false;
            this.txtCodAgrup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodAgrup.TrailingIcon = null;
            this.txtCodAgrup.UseSystemPasswordChar = false;
            // 
            // txtNomeAgrup
            // 
            this.txtNomeAgrup.AnimateReadOnly = false;
            this.txtNomeAgrup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeAgrup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeAgrup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomeAgrup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeAgrup.Depth = 0;
            this.txtNomeAgrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeAgrup.HideSelection = true;
            this.txtNomeAgrup.Hint = "Nome do Agrupamento";
            this.txtNomeAgrup.LeadingIcon = null;
            this.txtNomeAgrup.Location = new System.Drawing.Point(6, 72);
            this.txtNomeAgrup.MaxLength = 32767;
            this.txtNomeAgrup.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNomeAgrup.Name = "txtNomeAgrup";
            this.txtNomeAgrup.PasswordChar = '\0';
            this.txtNomeAgrup.PrefixSuffixText = null;
            this.txtNomeAgrup.ReadOnly = false;
            this.txtNomeAgrup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomeAgrup.SelectedText = "";
            this.txtNomeAgrup.SelectionLength = 0;
            this.txtNomeAgrup.SelectionStart = 0;
            this.txtNomeAgrup.ShortcutsEnabled = true;
            this.txtNomeAgrup.Size = new System.Drawing.Size(518, 48);
            this.txtNomeAgrup.TabIndex = 6;
            this.txtNomeAgrup.TabStop = false;
            this.txtNomeAgrup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomeAgrup.TrailingIcon = null;
            this.txtNomeAgrup.UseSystemPasswordChar = false;
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
            this.txtId.Location = new System.Drawing.Point(673, 18);
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
            this.txtId.Size = new System.Drawing.Size(83, 48);
            this.txtId.TabIndex = 14;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // radReceita
            // 
            this.radReceita.AutoSize = true;
            this.radReceita.Depth = 0;
            this.radReceita.Location = new System.Drawing.Point(535, 83);
            this.radReceita.Margin = new System.Windows.Forms.Padding(0);
            this.radReceita.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radReceita.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.radReceita.Name = "radReceita";
            this.radReceita.Ripple = true;
            this.radReceita.Size = new System.Drawing.Size(91, 37);
            this.radReceita.TabIndex = 29;
            this.radReceita.TabStop = true;
            this.radReceita.Text = "Receita ";
            this.radReceita.UseAccentColor = false;
            this.radReceita.UseVisualStyleBackColor = true;
            this.radReceita.CheckedChanged += new System.EventHandler(this.radReceita_CheckedChanged);
            // 
            // radDespesa
            // 
            this.radDespesa.AutoSize = true;
            this.radDespesa.Depth = 0;
            this.radDespesa.Location = new System.Drawing.Point(645, 83);
            this.radDespesa.Margin = new System.Windows.Forms.Padding(0);
            this.radDespesa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radDespesa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.radDespesa.Name = "radDespesa";
            this.radDespesa.Ripple = true;
            this.radDespesa.Size = new System.Drawing.Size(96, 37);
            this.radDespesa.TabIndex = 28;
            this.radDespesa.TabStop = true;
            this.radDespesa.Text = "Despesa";
            this.radDespesa.UseAccentColor = false;
            this.radDespesa.UseVisualStyleBackColor = true;
            this.radDespesa.CheckedChanged += new System.EventHandler(this.radDespesa_CheckedChanged);
            // 
            // CadastroTiposTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 305);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroTiposTransacao";
            this.Text = "CadastroTiposTransacao";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeAgrup;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodAgrup;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialRadioButton radReceita;
        private ReaLTaiizor.Controls.MaterialRadioButton radDespesa;
    }
}