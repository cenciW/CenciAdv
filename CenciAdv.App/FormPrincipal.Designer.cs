namespace CenciAdv.App
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            adicionarGrupoDeTransaçõesToolStripMenuItem = new ToolStripMenuItem();
            transacaoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cidadesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            agendarHorarioToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            filtrarToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, relatóriosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(815, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, toolStripMenuItem1, adicionarGrupoDeTransaçõesToolStripMenuItem, transacaoToolStripMenuItem, toolStripMenuItem2, cidadesToolStripMenuItem, clientesToolStripMenuItem, toolStripMenuItem3, agendarHorarioToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(237, 22);
            usuariosToolStripMenuItem.Text = "&Usuários";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(234, 6);
            // 
            // adicionarGrupoDeTransaçõesToolStripMenuItem
            // 
            adicionarGrupoDeTransaçõesToolStripMenuItem.Name = "adicionarGrupoDeTransaçõesToolStripMenuItem";
            adicionarGrupoDeTransaçõesToolStripMenuItem.Size = new Size(237, 22);
            adicionarGrupoDeTransaçõesToolStripMenuItem.Text = "Adicionar Grupo de Transações";
            adicionarGrupoDeTransaçõesToolStripMenuItem.Click += adicionarGrupoDeTransaçõesToolStripMenuItem_Click;
            // 
            // transacaoToolStripMenuItem
            // 
            transacaoToolStripMenuItem.Name = "transacaoToolStripMenuItem";
            transacaoToolStripMenuItem.Size = new Size(237, 22);
            transacaoToolStripMenuItem.Text = "&Adicionar Transação (R$)";
            transacaoToolStripMenuItem.Click += transacaoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(234, 6);
            // 
            // cidadesToolStripMenuItem
            // 
            cidadesToolStripMenuItem.Name = "cidadesToolStripMenuItem";
            cidadesToolStripMenuItem.Size = new Size(237, 22);
            cidadesToolStripMenuItem.Text = "&Cidades";
            cidadesToolStripMenuItem.Click += cidadesToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(237, 22);
            clientesToolStripMenuItem.Text = "&Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(234, 6);
            // 
            // agendarHorarioToolStripMenuItem
            // 
            agendarHorarioToolStripMenuItem.Name = "agendarHorarioToolStripMenuItem";
            agendarHorarioToolStripMenuItem.Size = new Size(237, 22);
            agendarHorarioToolStripMenuItem.Text = "&Agendar Horario";
            agendarHorarioToolStripMenuItem.Click += agendarHorarioToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filtrarToolStripMenuItem1 });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // filtrarToolStripMenuItem1
            // 
            filtrarToolStripMenuItem1.Name = "filtrarToolStripMenuItem1";
            filtrarToolStripMenuItem1.Size = new Size(164, 22);
            filtrarToolStripMenuItem1.Text = "&Filtrar Transações";
            filtrarToolStripMenuItem1.Click += filtrarToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuario });
            statusStrip1.Location = new Point(3, 467);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(815, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 17);
            lblUsuario.Text = "Usuário:";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(821, 492);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FormPrincipal";
            Text = "Cenci Advocacia - Sistema de Gerenciamento";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem transacaoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem cidadesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem agendarHorarioToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem filtrarToolStripMenuItem1;
        private ToolStripMenuItem adicionarGrupoDeTransaçõesToolStripMenuItem;
    }
}