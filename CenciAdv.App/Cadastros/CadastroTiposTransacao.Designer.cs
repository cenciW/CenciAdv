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
            txtCodAgrup = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNomeAgrup = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            radReceita = new ReaLTaiizor.Controls.MaterialRadioButton();
            radDespesa = new ReaLTaiizor.Controls.MaterialRadioButton();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
         
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(846, 238);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(radReceita);
            tabPageCadastro.Controls.Add(radDespesa);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNomeAgrup);
            tabPageCadastro.Controls.Add(txtCodAgrup);
            tabPageCadastro.Size = new Size(838, 203);
         
            tabPageCadastro.Controls.SetChildIndex(txtCodAgrup, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNomeAgrup, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(radDespesa, 0);
            tabPageCadastro.Controls.SetChildIndex(radReceita, 0);
         
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // txtCodAgrup
            // 
            txtCodAgrup.AnimateReadOnly = false;
            txtCodAgrup.AutoCompleteMode = AutoCompleteMode.None;
            txtCodAgrup.AutoCompleteSource = AutoCompleteSource.None;
            txtCodAgrup.BackgroundImageLayout = ImageLayout.None;
            txtCodAgrup.CharacterCasing = CharacterCasing.Normal;
            txtCodAgrup.Depth = 0;
            txtCodAgrup.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodAgrup.HideSelection = true;
            txtCodAgrup.Hint = "Código do Agrupamento";
            txtCodAgrup.LeadingIcon = null;
            txtCodAgrup.Location = new Point(6, 18);
            txtCodAgrup.MaxLength = 32767;
            txtCodAgrup.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodAgrup.Name = "txtCodAgrup";
            txtCodAgrup.PasswordChar = '\0';
            txtCodAgrup.PrefixSuffixText = null;
            txtCodAgrup.ReadOnly = false;
            txtCodAgrup.RightToLeft = RightToLeft.No;
            txtCodAgrup.SelectedText = "";
            txtCodAgrup.SelectionLength = 0;
            txtCodAgrup.SelectionStart = 0;
            txtCodAgrup.ShortcutsEnabled = true;
            txtCodAgrup.Size = new Size(661, 48);
            txtCodAgrup.TabIndex = 5;
            txtCodAgrup.TabStop = false;
            txtCodAgrup.TextAlign = HorizontalAlignment.Left;
            txtCodAgrup.TrailingIcon = null;
            txtCodAgrup.UseSystemPasswordChar = false;
            // 
            // txtNomeAgrup
            // 
            txtNomeAgrup.AnimateReadOnly = false;
            txtNomeAgrup.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeAgrup.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeAgrup.BackgroundImageLayout = ImageLayout.None;
            txtNomeAgrup.CharacterCasing = CharacterCasing.Normal;
            txtNomeAgrup.Depth = 0;
            txtNomeAgrup.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeAgrup.HideSelection = true;
            txtNomeAgrup.Hint = "Nome do Agrupamento";
            txtNomeAgrup.LeadingIcon = null;
            txtNomeAgrup.Location = new Point(6, 72);
            txtNomeAgrup.MaxLength = 32767;
            txtNomeAgrup.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeAgrup.Name = "txtNomeAgrup";
            txtNomeAgrup.PasswordChar = '\0';
            txtNomeAgrup.PrefixSuffixText = null;
            txtNomeAgrup.ReadOnly = false;
            txtNomeAgrup.RightToLeft = RightToLeft.No;
            txtNomeAgrup.SelectedText = "";
            txtNomeAgrup.SelectionLength = 0;
            txtNomeAgrup.SelectionStart = 0;
            txtNomeAgrup.ShortcutsEnabled = true;
            txtNomeAgrup.Size = new Size(518, 48);
            txtNomeAgrup.TabIndex = 6;
            txtNomeAgrup.TabStop = false;
            txtNomeAgrup.TextAlign = HorizontalAlignment.Left;
            txtNomeAgrup.TrailingIcon = null;
            txtNomeAgrup.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(673, 18);
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
            txtId.Size = new Size(83, 48);
            txtId.TabIndex = 14;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // radReceita
            // 
            radReceita.AutoSize = true;
            radReceita.Depth = 0;
            radReceita.Location = new Point(543, 83);
            radReceita.Margin = new Padding(0);
            radReceita.MouseLocation = new Point(-1, -1);
            radReceita.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            radReceita.Name = "radReceita";
            radReceita.Ripple = true;
            radReceita.Size = new Size(91, 37);
            radReceita.TabIndex = 29;
            radReceita.TabStop = true;
            radReceita.Text = "Receita ";
            radReceita.UseAccentColor = false;
            radReceita.UseVisualStyleBackColor = true;
            radReceita.CheckedChanged += radReceita_CheckedChanged;
            // 
            // radDespesa
            // 
            radDespesa.AutoSize = true;
            radDespesa.Depth = 0;
            radDespesa.Location = new Point(658, 83);
            radDespesa.Margin = new Padding(0);
            radDespesa.MouseLocation = new Point(-1, -1);
            radDespesa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            radDespesa.Name = "radDespesa";
            radDespesa.Ripple = true;
            radDespesa.Size = new Size(96, 37);
            radDespesa.TabIndex = 28;
            radDespesa.TabStop = true;
            radDespesa.Text = "Despesa";
            radDespesa.UseAccentColor = false;
            radDespesa.UseVisualStyleBackColor = true;
            radDespesa.CheckedChanged += radDespesa_CheckedChanged;
            // 
            // CadastroTiposTransacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 305);
            Location = new Point(0, 0);
            Name = "CadastroTiposTransacao";
            Text = "Cadastro de Agrupamentos de Transacao";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
           
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeAgrup;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodAgrup;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialRadioButton radReceita;
        private ReaLTaiizor.Controls.MaterialRadioButton radDespesa;
    }
}