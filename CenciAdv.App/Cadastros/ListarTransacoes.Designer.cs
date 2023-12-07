namespace CenciAdv.App.Cadastros
{
    partial class ListarTransacoes
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
            dataGridView1 = new DataGridView();
            btnFiltrar = new ReaLTaiizor.Controls.MaterialButton();
            dateTimePickerInicial = new DateTimePicker();
            dateTimePickerFinal = new DateTimePicker();
            rdbReceita = new ReaLTaiizor.Controls.MaterialRadioButton();
            rdbDespesa = new ReaLTaiizor.Controls.MaterialRadioButton();
            rdbTudo = new ReaLTaiizor.Controls.MaterialRadioButton();
            checkBoxIncluirData = new CheckBox();
            lblTotalReceitas = new ReaLTaiizor.Controls.MaterialLabel();
            lblTotalDespesas = new ReaLTaiizor.Controls.MaterialLabel();
            lblSubTotal = new ReaLTaiizor.Controls.MaterialLabel();
            checkBoxIncluirAdvogado = new CheckBox();
            cboAdvogado = new ReaLTaiizor.Controls.MaterialComboBox();
            cboTiposTransacao = new ReaLTaiizor.Controls.MaterialComboBox();
            checkBoxIncluirTipoTransacao = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 417);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(788, 312);
            dataGridView1.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            btnFiltrar.AutoSize = false;
            btnFiltrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFiltrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFiltrar.Depth = 0;
            btnFiltrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltrar.HighEmphasis = true;
            btnFiltrar.Icon = null;
            btnFiltrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnFiltrar.Location = new Point(526, 319);
            btnFiltrar.Margin = new Padding(4, 6, 4, 6);
            btnFiltrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.NoAccentTextColor = Color.Empty;
            btnFiltrar.Size = new Size(267, 51);
            btnFiltrar.TabIndex = 1;
            btnFiltrar.Text = "&Filtrar";
            btnFiltrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFiltrar.UseAccentColor = false;
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dateTimePickerInicial
            // 
            dateTimePickerInicial.CustomFormat = "dd/MM/yyyy";
            dateTimePickerInicial.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerInicial.Format = DateTimePickerFormat.Custom;
            dateTimePickerInicial.Location = new Point(6, 77);
            dateTimePickerInicial.Name = "dateTimePickerInicial";
            dateTimePickerInicial.Size = new Size(788, 43);
            dateTimePickerInicial.TabIndex = 15;
            // 
            // dateTimePickerFinal
            // 
            dateTimePickerFinal.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFinal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFinal.Format = DateTimePickerFormat.Custom;
            dateTimePickerFinal.Location = new Point(6, 140);
            dateTimePickerFinal.Name = "dateTimePickerFinal";
            dateTimePickerFinal.Size = new Size(788, 43);
            dateTimePickerFinal.TabIndex = 16;
            // 
            // rdbReceita
            // 
            rdbReceita.AutoSize = true;
            rdbReceita.Depth = 0;
            rdbReceita.Location = new Point(107, 344);
            rdbReceita.Margin = new Padding(0);
            rdbReceita.MouseLocation = new Point(-1, -1);
            rdbReceita.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbReceita.Name = "rdbReceita";
            rdbReceita.Ripple = true;
            rdbReceita.Size = new Size(87, 37);
            rdbReceita.TabIndex = 17;
            rdbReceita.TabStop = true;
            rdbReceita.Text = "Receita";
            rdbReceita.UseAccentColor = false;
            rdbReceita.UseVisualStyleBackColor = true;
            // 
            // rdbDespesa
            // 
            rdbDespesa.AutoSize = true;
            rdbDespesa.Depth = 0;
            rdbDespesa.Location = new Point(6, 344);
            rdbDespesa.Margin = new Padding(0);
            rdbDespesa.MouseLocation = new Point(-1, -1);
            rdbDespesa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbDespesa.Name = "rdbDespesa";
            rdbDespesa.Ripple = true;
            rdbDespesa.Size = new Size(96, 37);
            rdbDespesa.TabIndex = 18;
            rdbDespesa.TabStop = true;
            rdbDespesa.Text = "Despesa";
            rdbDespesa.UseAccentColor = false;
            rdbDespesa.UseVisualStyleBackColor = true;
            // 
            // rdbTudo
            // 
            rdbTudo.AutoSize = true;
            rdbTudo.Depth = 0;
            rdbTudo.Location = new Point(6, 307);
            rdbTudo.Margin = new Padding(0);
            rdbTudo.MouseLocation = new Point(-1, -1);
            rdbTudo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdbTudo.Name = "rdbTudo";
            rdbTudo.Ripple = true;
            rdbTudo.Size = new Size(188, 37);
            rdbTudo.TabIndex = 19;
            rdbTudo.TabStop = true;
            rdbTudo.Text = "Todas as Transações";
            rdbTudo.UseAccentColor = false;
            rdbTudo.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncluirData
            // 
            checkBoxIncluirData.AutoSize = true;
            checkBoxIncluirData.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIncluirData.Location = new Point(526, 193);
            checkBoxIncluirData.Name = "checkBoxIncluirData";
            checkBoxIncluirData.Size = new Size(217, 29);
            checkBoxIncluirData.TabIndex = 20;
            checkBoxIncluirData.Text = "Incluir data na pesquisa";
            checkBoxIncluirData.UseVisualStyleBackColor = true;
            // 
            // lblTotalReceitas
            // 
            lblTotalReceitas.AutoSize = true;
            lblTotalReceitas.Depth = 0;
            lblTotalReceitas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalReceitas.Location = new Point(10, 395);
            lblTotalReceitas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTotalReceitas.Name = "lblTotalReceitas";
            lblTotalReceitas.Size = new Size(106, 19);
            lblTotalReceitas.TabIndex = 21;
            lblTotalReceitas.Text = "Total Receitas:";
            // 
            // lblTotalDespesas
            // 
            lblTotalDespesas.AutoSize = true;
            lblTotalDespesas.Depth = 0;
            lblTotalDespesas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalDespesas.Location = new Point(265, 395);
            lblTotalDespesas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTotalDespesas.Name = "lblTotalDespesas";
            lblTotalDespesas.Size = new Size(115, 19);
            lblTotalDespesas.TabIndex = 22;
            lblTotalDespesas.Text = "Total Despesas:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Depth = 0;
            lblSubTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSubTotal.Location = new Point(526, 395);
            lblSubTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(104, 19);
            lblSubTotal.TabIndex = 23;
            lblSubTotal.Text = "Balanço Total:";
            // 
            // checkBoxIncluirAdvogado
            // 
            checkBoxIncluirAdvogado.AutoSize = true;
            checkBoxIncluirAdvogado.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIncluirAdvogado.Location = new Point(526, 221);
            checkBoxIncluirAdvogado.Name = "checkBoxIncluirAdvogado";
            checkBoxIncluirAdvogado.Size = new Size(267, 29);
            checkBoxIncluirAdvogado.TabIndex = 24;
            checkBoxIncluirAdvogado.Text = "Incluir Advogado na pesquisa";
            checkBoxIncluirAdvogado.UseVisualStyleBackColor = true;
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
            cboAdvogado.Items.AddRange(new object[] { "" });
            cboAdvogado.Location = new Point(6, 196);
            cboAdvogado.MaxDropDownItems = 4;
            cboAdvogado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAdvogado.Name = "cboAdvogado";
            cboAdvogado.Size = new Size(497, 49);
            cboAdvogado.StartIndex = 0;
            cboAdvogado.TabIndex = 25;
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
            cboTiposTransacao.Hint = "Agrupamento Transações";
            cboTiposTransacao.IntegralHeight = false;
            cboTiposTransacao.ItemHeight = 43;
            cboTiposTransacao.Location = new Point(6, 255);
            cboTiposTransacao.MaxDropDownItems = 4;
            cboTiposTransacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTiposTransacao.Name = "cboTiposTransacao";
            cboTiposTransacao.Size = new Size(497, 49);
            cboTiposTransacao.StartIndex = 0;
            cboTiposTransacao.TabIndex = 26;
            // 
            // checkBoxIncluirTipoTransacao
            // 
            checkBoxIncluirTipoTransacao.AutoSize = true;
            checkBoxIncluirTipoTransacao.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIncluirTipoTransacao.Location = new Point(526, 256);
            checkBoxIncluirTipoTransacao.Name = "checkBoxIncluirTipoTransacao";
            checkBoxIncluirTipoTransacao.Size = new Size(214, 29);
            checkBoxIncluirTipoTransacao.TabIndex = 27;
            checkBoxIncluirTipoTransacao.Text = "Incluir tipo na pesquisa";
            checkBoxIncluirTipoTransacao.UseVisualStyleBackColor = true;
            // 
            // ListarTransacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 735);
            Controls.Add(checkBoxIncluirTipoTransacao);
            Controls.Add(cboTiposTransacao);
            Controls.Add(cboAdvogado);
            Controls.Add(checkBoxIncluirAdvogado);
            Controls.Add(lblSubTotal);
            Controls.Add(lblTotalDespesas);
            Controls.Add(lblTotalReceitas);
            Controls.Add(checkBoxIncluirData);
            Controls.Add(rdbTudo);
            Controls.Add(rdbDespesa);
            Controls.Add(rdbReceita);
            Controls.Add(dateTimePickerFinal);
            Controls.Add(dateTimePickerInicial);
            Controls.Add(btnFiltrar);
            Controls.Add(dataGridView1);
            Name = "ListarTransacoes";
            Text = "Agrupamento Transações";
            Enter += ListarTransacoes_Enter;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialButton btnFiltrar;
        private DateTimePicker dateTimePickerInicial;
        private DateTimePicker dateTimePickerFinal;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbReceita;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbDespesa;
        private ReaLTaiizor.Controls.MaterialRadioButton rdbTudo;
        private CheckBox checkBoxIncluirData;
        private ReaLTaiizor.Controls.MaterialLabel lblTotalReceitas;
        private ReaLTaiizor.Controls.MaterialLabel lblTotalDespesas;
        private ReaLTaiizor.Controls.MaterialLabel lblSubTotal;
        private CheckBox checkBoxIncluirAdvogado;
        private ReaLTaiizor.Controls.MaterialComboBox cboAdvogado;
        private ReaLTaiizor.Controls.MaterialComboBox cboTiposTransacao;
        private CheckBox checkBoxIncluirTipoTransacao;
    }
}