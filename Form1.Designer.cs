namespace BarbeariaFogaca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosDoBarbeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelAdministrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelContadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelDeNiveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.lb_nomeUsuario = new System.Windows.Forms.Label();
            this.pb_logado = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p_nivelAcesso = new System.Windows.Forms.Label();
            this.lb_aceso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dgv_agendamentos = new System.Windows.Forms.DataGridView();
            this.lb_horario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.corteToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(984, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.cadastrarNovoToolStripMenuItem,
            this.dadosDoBarbeiroToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.fecharProgramaToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click);
            // 
            // cadastrarNovoToolStripMenuItem
            // 
            this.cadastrarNovoToolStripMenuItem.Name = "cadastrarNovoToolStripMenuItem";
            this.cadastrarNovoToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.cadastrarNovoToolStripMenuItem.Text = "Cadastrar Novo Barbeiro";
            this.cadastrarNovoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem_Click);
            // 
            // dadosDoBarbeiroToolStripMenuItem
            // 
            this.dadosDoBarbeiroToolStripMenuItem.Name = "dadosDoBarbeiroToolStripMenuItem";
            this.dadosDoBarbeiroToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.dadosDoBarbeiroToolStripMenuItem.Text = "Dados do Barbeiro";
            this.dadosDoBarbeiroToolStripMenuItem.Click += new System.EventHandler(this.dadosDoBarbeiroToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar Programa";
            this.fecharProgramaToolStripMenuItem.Click += new System.EventHandler(this.fecharProgramaToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarServiçoToolStripMenuItem,
            this.adicionarVendaToolStripMenuItem1});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // adicionarServiçoToolStripMenuItem
            // 
            this.adicionarServiçoToolStripMenuItem.Name = "adicionarServiçoToolStripMenuItem";
            this.adicionarServiçoToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.adicionarServiçoToolStripMenuItem.Text = "Adicionar Serviço";
            this.adicionarServiçoToolStripMenuItem.Click += new System.EventHandler(this.adicionarServiçoToolStripMenuItem_Click);
            // 
            // adicionarVendaToolStripMenuItem1
            // 
            this.adicionarVendaToolStripMenuItem1.Name = "adicionarVendaToolStripMenuItem1";
            this.adicionarVendaToolStripMenuItem1.Size = new System.Drawing.Size(208, 24);
            this.adicionarVendaToolStripMenuItem1.Text = "Adicionar Venda";
            this.adicionarVendaToolStripMenuItem1.Click += new System.EventHandler(this.adicionarVendaToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.alterarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.novoClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // alterarClienteToolStripMenuItem
            // 
            this.alterarClienteToolStripMenuItem.Name = "alterarClienteToolStripMenuItem";
            this.alterarClienteToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.alterarClienteToolStripMenuItem.Text = "Dados dos Clientes";
            this.alterarClienteToolStripMenuItem.Click += new System.EventHandler(this.alterarClienteToolStripMenuItem_Click);
            // 
            // corteToolStripMenuItem
            // 
            this.corteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCorteToolStripMenuItem,
            this.alterarCorteToolStripMenuItem});
            this.corteToolStripMenuItem.Name = "corteToolStripMenuItem";
            this.corteToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.corteToolStripMenuItem.Text = "Cortes";
            this.corteToolStripMenuItem.Click += new System.EventHandler(this.corteToolStripMenuItem_Click);
            // 
            // novoCorteToolStripMenuItem
            // 
            this.novoCorteToolStripMenuItem.Name = "novoCorteToolStripMenuItem";
            this.novoCorteToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.novoCorteToolStripMenuItem.Text = "Novo Corte";
            this.novoCorteToolStripMenuItem.Click += new System.EventHandler(this.novoCorteToolStripMenuItem_Click);
            // 
            // alterarCorteToolStripMenuItem
            // 
            this.alterarCorteToolStripMenuItem.Name = "alterarCorteToolStripMenuItem";
            this.alterarCorteToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.alterarCorteToolStripMenuItem.Text = "Dados Cortes";
            this.alterarCorteToolStripMenuItem.Click += new System.EventHandler(this.alterarCorteToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVendaToolStripMenuItem,
            this.alterarProdutoToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.vendasToolStripMenuItem.Text = "Produtos";
            // 
            // adicionarVendaToolStripMenuItem
            // 
            this.adicionarVendaToolStripMenuItem.Name = "adicionarVendaToolStripMenuItem";
            this.adicionarVendaToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.adicionarVendaToolStripMenuItem.Text = "Adicionar Produto";
            this.adicionarVendaToolStripMenuItem.Click += new System.EventHandler(this.adicionarVendaToolStripMenuItem_Click);
            // 
            // alterarProdutoToolStripMenuItem
            // 
            this.alterarProdutoToolStripMenuItem.Name = "alterarProdutoToolStripMenuItem";
            this.alterarProdutoToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.alterarProdutoToolStripMenuItem.Text = "Alterar Produtos";
            this.alterarProdutoToolStripMenuItem.Click += new System.EventHandler(this.alterarProdutoToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.painelAdministrativoToolStripMenuItem,
            this.painelContadorToolStripMenuItem,
            this.painelDeNiveisToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(128, 23);
            this.financeiroToolStripMenuItem.Text = "Administrativo";
            this.financeiroToolStripMenuItem.Click += new System.EventHandler(this.financeiroToolStripMenuItem_Click);
            // 
            // painelAdministrativoToolStripMenuItem
            // 
            this.painelAdministrativoToolStripMenuItem.Name = "painelAdministrativoToolStripMenuItem";
            this.painelAdministrativoToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.painelAdministrativoToolStripMenuItem.Text = "Painel Financeiro";
            this.painelAdministrativoToolStripMenuItem.Click += new System.EventHandler(this.painelAdministrativoToolStripMenuItem_Click);
            // 
            // painelContadorToolStripMenuItem
            // 
            this.painelContadorToolStripMenuItem.Name = "painelContadorToolStripMenuItem";
            this.painelContadorToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.painelContadorToolStripMenuItem.Text = "Painel Contador";
            this.painelContadorToolStripMenuItem.Click += new System.EventHandler(this.painelContadorToolStripMenuItem_Click);
            // 
            // painelDeNiveisToolStripMenuItem
            // 
            this.painelDeNiveisToolStripMenuItem.Name = "painelDeNiveisToolStripMenuItem";
            this.painelDeNiveisToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.painelDeNiveisToolStripMenuItem.Text = "Painel de nivel de acesso";
            this.painelDeNiveisToolStripMenuItem.Click += new System.EventHandler(this.painelDeNiveisToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.lb_nomeUsuario);
            this.panel1.Controls.Add(this.pb_logado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.p_nivelAcesso);
            this.panel1.Controls.Add(this.lb_aceso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 35);
            this.panel1.TabIndex = 1;
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(149, 9);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(23, 17);
            this.lb_acesso.TabIndex = 10;
            this.lb_acesso.Text = "---";
            // 
            // lb_nomeUsuario
            // 
            this.lb_nomeUsuario.AutoSize = true;
            this.lb_nomeUsuario.Location = new System.Drawing.Point(263, 9);
            this.lb_nomeUsuario.Name = "lb_nomeUsuario";
            this.lb_nomeUsuario.Size = new System.Drawing.Size(23, 17);
            this.lb_nomeUsuario.TabIndex = 8;
            this.lb_nomeUsuario.Text = "---";
            // 
            // pb_logado
            // 
            this.pb_logado.Image = global::BarbeariaFogaca.Properties.Resources.AcessoNegadoImg;
            this.pb_logado.Location = new System.Drawing.Point(3, 2);
            this.pb_logado.Name = "pb_logado";
            this.pb_logado.Size = new System.Drawing.Size(30, 30);
            this.pb_logado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logado.TabIndex = 9;
            this.pb_logado.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario: ";
            // 
            // p_nivelAcesso
            // 
            this.p_nivelAcesso.AutoSize = true;
            this.p_nivelAcesso.Location = new System.Drawing.Point(39, 9);
            this.p_nivelAcesso.Name = "p_nivelAcesso";
            this.p_nivelAcesso.Size = new System.Drawing.Size(116, 17);
            this.p_nivelAcesso.TabIndex = 5;
            this.p_nivelAcesso.Text = "Nivel de acesso: ";
            // 
            // lb_aceso
            // 
            this.lb_aceso.AutoSize = true;
            this.lb_aceso.Location = new System.Drawing.Point(134, 9);
            this.lb_aceso.Name = "lb_aceso";
            this.lb_aceso.Size = new System.Drawing.Size(18, 17);
            this.lb_aceso.TabIndex = 6;
            this.lb_aceso.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(941, 119);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema Barbearia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-2, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proximos horarios marcados..";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BarbeariaFogaca.Properties.Resources.adicionar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(581, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::BarbeariaFogaca.Properties.Resources.subtrair;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(580, 322);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::BarbeariaFogaca.Properties.Resources.alterar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(581, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 50);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dgv_agendamentos
            // 
            this.dgv_agendamentos.AllowUserToAddRows = false;
            this.dgv_agendamentos.AllowUserToDeleteRows = false;
            this.dgv_agendamentos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_agendamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_agendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agendamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_agendamentos.EnableHeadersVisualStyles = false;
            this.dgv_agendamentos.Location = new System.Drawing.Point(3, 210);
            this.dgv_agendamentos.MultiSelect = false;
            this.dgv_agendamentos.Name = "dgv_agendamentos";
            this.dgv_agendamentos.ReadOnly = true;
            this.dgv_agendamentos.RowHeadersVisible = false;
            this.dgv_agendamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_agendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_agendamentos.Size = new System.Drawing.Size(572, 323);
            this.dgv_agendamentos.TabIndex = 9;
            // 
            // lb_horario
            // 
            this.lb_horario.AutoSize = true;
            this.lb_horario.BackColor = System.Drawing.Color.Transparent;
            this.lb_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_horario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_horario.Location = new System.Drawing.Point(772, 478);
            this.lb_horario.Name = "lb_horario";
            this.lb_horario.Size = new System.Drawing.Size(212, 55);
            this.lb_horario.TabIndex = 10;
            this.lb_horario.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BarbeariaFogaca.Properties.Resources.fundoTelas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 574);
            this.Controls.Add(this.lb_horario);
            this.Controls.Add(this.dgv_agendamentos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barbearia Fogaça";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lb_nomeUsuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_aceso;
        private System.Windows.Forms.Label p_nivelAcesso;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosDoBarbeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarCorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem painelAdministrativoToolStripMenuItem;
        public System.Windows.Forms.PictureBox pb_logado;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_acesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem painelContadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem painelDeNiveisToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgv_agendamentos;
        private System.Windows.Forms.Label lb_horario;
        private System.Windows.Forms.Timer timer1;
    }
}

