namespace CenciAdv.App.Base
{
    partial class CadastroBase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            materialTabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            panel1 = new Panel();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            tabPageConsulta = new TabPage();
            panel2 = new Panel();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewConsulta = new DataGridView();
            imageList1 = new ImageList(components);
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel1.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Controls.Add(tabPageCadastro);
            materialTabControl.Controls.Add(tabPageConsulta);
            materialTabControl.Depth = 0;
            materialTabControl.Dock = DockStyle.Fill;
            materialTabControl.ImageList = imageList1;
            materialTabControl.Location = new Point(3, 64);
            materialTabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl.Multiline = true;
            materialTabControl.Name = "materialTabControl";
            materialTabControl.SelectedIndex = 0;
            materialTabControl.Size = new Size(741, 417);
            materialTabControl.TabIndex = 1;
            materialTabControl.Enter += materialTabControl_Enter;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(panel1);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(733, 382);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            tabPageCadastro.Click += tabPageCadastro_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 48);
            panel1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(503, 6);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(105, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(627, 6);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(85, 36);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "&Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(panel2);
            tabPageConsulta.Controls.Add(dataGridViewConsulta);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(733, 382);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnNovo);
            panel2.Location = new Point(6, 331);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 48);
            panel2.TabIndex = 5;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(625, 6);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(89, 36);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "&Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(537, 6);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(81, 36);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "&Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom;
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(456, 6);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(71, 36);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "&Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.AllowUserToAddRows = false;
            dataGridViewConsulta.AllowUserToDeleteRows = false;
            dataGridViewConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Location = new Point(6, 6);
            dataGridViewConsulta.MultiSelect = false;
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.ReadOnly = true;
            dataGridViewConsulta.RowHeadersWidth = 51;
            dataGridViewConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewConsulta.Size = new Size(721, 319);
            dataGridViewConsulta.TabIndex = 4;
            dataGridViewConsulta.CellContentClick += dataGridViewConsulta_CellContentClick;
            dataGridViewConsulta.CellDoubleClick += dataGridViewConsulta_CellDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 484);
            Controls.Add(materialTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroBase";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        protected ReaLTaiizor.Controls.MaterialTabControl materialTabControl;
        protected TabPage tabPageCadastro;
        protected ReaLTaiizor.Controls.MaterialButton btnCancelar;
        protected ReaLTaiizor.Controls.MaterialButton btnSalvar;
        protected Panel panel1;
        protected ImageList imageList1;
        public ReaLTaiizor.Controls.MaterialButton btnExcluir;
        public ReaLTaiizor.Controls.MaterialButton btnEditar;
        public ReaLTaiizor.Controls.MaterialButton btnNovo;
        protected Panel panel2;
        protected TabPage tabPageConsulta;
        protected DataGridView dataGridViewConsulta;
    }
}