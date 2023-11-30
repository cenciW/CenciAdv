namespace CenciAdv.App.Cadastros
{
    partial class CadastroConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroConsulta));
            this.cboAdvogado = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(913, 332);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.dateTimePicker1);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.cboCliente);
            this.tabPageCadastro.Controls.Add(this.cboAdvogado);
            this.tabPageCadastro.Size = new System.Drawing.Size(905, 297);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboAdvogado, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboCliente, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.panel1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.dateTimePicker1, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(662, 6);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(786, 6);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 246);
            this.panel1.Size = new System.Drawing.Size(899, 48);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "form.png");
            this.imageList1.Images.SetKeyName(1, "search.png");
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
            this.cboAdvogado.Location = new System.Drawing.Point(15, 71);
            this.cboAdvogado.MaxDropDownItems = 4;
            this.cboAdvogado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboAdvogado.Name = "cboAdvogado";
            this.cboAdvogado.Size = new System.Drawing.Size(658, 49);
            this.cboAdvogado.StartIndex = 0;
            this.cboAdvogado.TabIndex = 10;
            // 
            // cboCliente
            // 
            this.cboCliente.AutoResize = false;
            this.cboCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCliente.Depth = 0;
            this.cboCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCliente.DropDownHeight = 174;
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.DropDownWidth = 121;
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Hint = "Cliente";
            this.cboCliente.IntegralHeight = false;
            this.cboCliente.ItemHeight = 43;
            this.cboCliente.Location = new System.Drawing.Point(15, 142);
            this.cboCliente.MaxDropDownItems = 4;
            this.cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(658, 49);
            this.cboCliente.StartIndex = 0;
            this.cboCliente.TabIndex = 11;
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
            this.txtId.Location = new System.Drawing.Point(697, 20);
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
            this.txtId.TabIndex = 13;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(658, 43);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // CadastroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 399);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroConsulta";
            this.Text = "Cadastro de Consultas";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialComboBox cboAdvogado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private DateTimePicker dateTimePicker1;
    }
}