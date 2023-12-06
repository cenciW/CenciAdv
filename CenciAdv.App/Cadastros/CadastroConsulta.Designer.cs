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
            cboAdvogado = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dateTimePicker1 = new DateTimePicker();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(846, 331);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(dateTimePicker1);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(cboAdvogado);
            tabPageCadastro.Size = new Size(838, 296);
            tabPageCadastro.Controls.SetChildIndex(cboAdvogado, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(panel1, 0);
            tabPageCadastro.Controls.SetChildIndex(dateTimePicker1, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(513, 6);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(637, 6);
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 245);
            panel1.Size = new Size(832, 48);
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // panel2
            // 
            panel2.Location = new Point(59, 227);
            // 
            // cboAdvogado
            // 
            cboAdvogado.AutoResize = false;
            cboAdvogado.BackColor = Color.FromArgb(255, 255, 255);
            cboAdvogado.Depth = 0;
            cboAdvogado.DrawMode = DrawMode.OwnerDrawVariable;
            cboAdvogado.DropDownHeight = 174;
            cboAdvogado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAdvogado.DropDownWidth = 121;
            cboAdvogado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAdvogado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAdvogado.FormattingEnabled = true;
            cboAdvogado.Hint = "Advogado";
            cboAdvogado.IntegralHeight = false;
            cboAdvogado.ItemHeight = 43;
            cboAdvogado.Location = new Point(15, 71);
            cboAdvogado.MaxDropDownItems = 4;
            cboAdvogado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAdvogado.Name = "cboAdvogado";
            cboAdvogado.Size = new Size(658, 49);
            cboAdvogado.StartIndex = 0;
            cboAdvogado.TabIndex = 10;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(15, 142);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(658, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 11;
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
            txtId.Location = new Point(702, 6);
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
            txtId.TabIndex = 13;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(15, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(658, 47);
            dateTimePicker1.TabIndex = 14;
            // 
            // CadastroConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 398);
            Location = new Point(0, 0);
            Name = "CadastroConsulta";
            Text = "Cadastro de Consultas";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialComboBox cboAdvogado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private DateTimePicker dateTimePicker1;
    }
}