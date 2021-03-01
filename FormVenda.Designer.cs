namespace BarbeariaFogaca
{
    partial class FormVenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_quantidadeDisponivel = new System.Windows.Forms.TextBox();
            this.n_quantidadeSerVendida = new System.Windows.Forms.NumericUpDown();
            this.btn_selecionarCliente = new System.Windows.Forms.Button();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_valorVenda = new System.Windows.Forms.TextBox();
            this.cb_pagamentos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_desconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_selecionarProduto = new System.Windows.Forms.Button();
            this.tb_produtoSelecionado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeBarbeiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_incluirServico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_quantidadeSerVendida)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_quantidadeDisponivel);
            this.panel1.Controls.Add(this.n_quantidadeSerVendida);
            this.panel1.Controls.Add(this.btn_selecionarCliente);
            this.panel1.Controls.Add(this.tb_cliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_valorVenda);
            this.panel1.Controls.Add(this.cb_pagamentos);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_desconto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_valor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_selecionarProduto);
            this.panel1.Controls.Add(this.tb_produtoSelecionado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nomeBarbeiro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 340);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(344, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Quantidade a ser vendida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(162, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Quantidade disponivel";
            // 
            // tb_quantidadeDisponivel
            // 
            this.tb_quantidadeDisponivel.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_quantidadeDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantidadeDisponivel.Location = new System.Drawing.Point(166, 156);
            this.tb_quantidadeDisponivel.Name = "tb_quantidadeDisponivel";
            this.tb_quantidadeDisponivel.ReadOnly = true;
            this.tb_quantidadeDisponivel.Size = new System.Drawing.Size(113, 23);
            this.tb_quantidadeDisponivel.TabIndex = 24;
            this.tb_quantidadeDisponivel.Text = "0";
            // 
            // n_quantidadeSerVendida
            // 
            this.n_quantidadeSerVendida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_quantidadeSerVendida.Location = new System.Drawing.Point(348, 156);
            this.n_quantidadeSerVendida.Name = "n_quantidadeSerVendida";
            this.n_quantidadeSerVendida.Size = new System.Drawing.Size(120, 23);
            this.n_quantidadeSerVendida.TabIndex = 3;
            this.n_quantidadeSerVendida.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_quantidadeSerVendida.ValueChanged += new System.EventHandler(this.n_quantidadeSerVendida_ValueChanged);
            // 
            // btn_selecionarCliente
            // 
            this.btn_selecionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selecionarCliente.Location = new System.Drawing.Point(390, 214);
            this.btn_selecionarCliente.Name = "btn_selecionarCliente";
            this.btn_selecionarCliente.Size = new System.Drawing.Size(91, 23);
            this.btn_selecionarCliente.TabIndex = 4;
            this.btn_selecionarCliente.Text = "Selecionar";
            this.btn_selecionarCliente.UseVisualStyleBackColor = true;
            this.btn_selecionarCliente.Click += new System.EventHandler(this.btn_selecionarCliente_Click);
            // 
            // tb_cliente
            // 
            this.tb_cliente.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cliente.Location = new System.Drawing.Point(18, 214);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.ReadOnly = true;
            this.tb_cliente.Size = new System.Drawing.Size(375, 23);
            this.tb_cliente.TabIndex = 21;
            this.tb_cliente.Text = "Escolha o cliente...";
            this.tb_cliente.TextChanged += new System.EventHandler(this.tb_cliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.Location = new System.Drawing.Point(539, 35);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(576, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Definir data da venda";
            // 
            // tb_valorVenda
            // 
            this.tb_valorVenda.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_valorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valorVenda.Location = new System.Drawing.Point(628, 258);
            this.tb_valorVenda.Name = "tb_valorVenda";
            this.tb_valorVenda.ReadOnly = true;
            this.tb_valorVenda.Size = new System.Drawing.Size(143, 29);
            this.tb_valorVenda.TabIndex = 17;
            this.tb_valorVenda.Text = "R$ 0";
            // 
            // cb_pagamentos
            // 
            this.cb_pagamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_pagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pagamentos.FormattingEnabled = true;
            this.cb_pagamentos.Items.AddRange(new object[] {
            "Dinheiro",
            "Debito",
            "Credito",
            "Troca de Serviço",
            "Outros"});
            this.cb_pagamentos.Location = new System.Drawing.Point(305, 36);
            this.cb_pagamentos.MaxDropDownItems = 4;
            this.cb_pagamentos.Name = "cb_pagamentos";
            this.cb_pagamentos.Size = new System.Drawing.Size(175, 24);
            this.cb_pagamentos.TabIndex = 1;
            this.cb_pagamentos.Text = "Dinheiro";
            this.cb_pagamentos.SelectedIndexChanged += new System.EventHandler(this.cb_pagamentos_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(301, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo de pagamento";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tb_desconto
            // 
            this.tb_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desconto.Location = new System.Drawing.Point(628, 293);
            this.tb_desconto.MaxLength = 5;
            this.tb_desconto.Name = "tb_desconto";
            this.tb_desconto.Size = new System.Drawing.Size(144, 29);
            this.tb_desconto.TabIndex = 5;
            this.tb_desconto.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(527, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Desconto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(480, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor da venda:";
            // 
            // tb_valor
            // 
            this.tb_valor.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(19, 156);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.ReadOnly = true;
            this.tb_valor.Size = new System.Drawing.Size(108, 23);
            this.tb_valor.TabIndex = 8;
            this.tb_valor.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor do produto";
            // 
            // btn_selecionarProduto
            // 
            this.btn_selecionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selecionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selecionarProduto.Location = new System.Drawing.Point(389, 93);
            this.btn_selecionarProduto.Name = "btn_selecionarProduto";
            this.btn_selecionarProduto.Size = new System.Drawing.Size(91, 23);
            this.btn_selecionarProduto.TabIndex = 2;
            this.btn_selecionarProduto.Text = "Selecionar";
            this.btn_selecionarProduto.UseVisualStyleBackColor = true;
            this.btn_selecionarProduto.Click += new System.EventHandler(this.btn_selecionarProduto_Click);
            // 
            // tb_produtoSelecionado
            // 
            this.tb_produtoSelecionado.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_produtoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_produtoSelecionado.Location = new System.Drawing.Point(18, 93);
            this.tb_produtoSelecionado.Name = "tb_produtoSelecionado";
            this.tb_produtoSelecionado.ReadOnly = true;
            this.tb_produtoSelecionado.Size = new System.Drawing.Size(374, 23);
            this.tb_produtoSelecionado.TabIndex = 5;
            this.tb_produtoSelecionado.Text = "Escolha o produto...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto";
            // 
            // tb_nomeBarbeiro
            // 
            this.tb_nomeBarbeiro.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nomeBarbeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomeBarbeiro.Location = new System.Drawing.Point(18, 37);
            this.tb_nomeBarbeiro.Name = "tb_nomeBarbeiro";
            this.tb_nomeBarbeiro.ReadOnly = true;
            this.tb_nomeBarbeiro.Size = new System.Drawing.Size(281, 23);
            this.tb_nomeBarbeiro.TabIndex = 1;
            this.tb_nomeBarbeiro.Text = "Este texto não deve aparecer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barbeiro Responsavel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_incluirServico);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 60);
            this.panel2.TabIndex = 5;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cancelar.Location = new System.Drawing.Point(3, 20);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(203, 37);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_incluirServico
            // 
            this.btn_incluirServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluirServico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_incluirServico.Location = new System.Drawing.Point(598, 20);
            this.btn_incluirServico.Name = "btn_incluirServico";
            this.btn_incluirServico.Size = new System.Drawing.Size(203, 37);
            this.btn_incluirServico.TabIndex = 6;
            this.btn_incluirServico.Text = "Incluir Venda";
            this.btn_incluirServico.UseVisualStyleBackColor = true;
            this.btn_incluirServico.Click += new System.EventHandler(this.btn_incluirServico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(238, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adicionando Vendas";
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BarbeariaFogaca.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de inclusão de vendas";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_quantidadeSerVendida)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_valorVenda;
        private System.Windows.Forms.ComboBox cb_pagamentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_desconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_selecionarProduto;
        private System.Windows.Forms.TextBox tb_produtoSelecionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeBarbeiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_selecionarCliente;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_incluirServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_quantidadeDisponivel;
        private System.Windows.Forms.NumericUpDown n_quantidadeSerVendida;
    }
}