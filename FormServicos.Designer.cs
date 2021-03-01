namespace BarbeariaFogaca
{
    partial class FormServicos
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_valorEscrito = new System.Windows.Forms.TextBox();
            this.cb_pagamentos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_desconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_cortes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nomeBarbeiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_incluirServico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_valorEscrito);
            this.panel1.Controls.Add(this.cb_pagamentos);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_desconto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_valor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_selecionar);
            this.panel1.Controls.Add(this.tb_cliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_cortes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_nomeBarbeiro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.Location = new System.Drawing.Point(539, 36);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(567, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Definir data do serviço";
            // 
            // tb_valorEscrito
            // 
            this.tb_valorEscrito.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_valorEscrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valorEscrito.Location = new System.Drawing.Point(628, 258);
            this.tb_valorEscrito.Name = "tb_valorEscrito";
            this.tb_valorEscrito.ReadOnly = true;
            this.tb_valorEscrito.Size = new System.Drawing.Size(143, 29);
            this.tb_valorEscrito.TabIndex = 17;
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
            this.cb_pagamentos.Location = new System.Drawing.Point(217, 104);
            this.cb_pagamentos.MaxDropDownItems = 4;
            this.cb_pagamentos.Name = "cb_pagamentos";
            this.cb_pagamentos.Size = new System.Drawing.Size(175, 24);
            this.cb_pagamentos.TabIndex = 3;
            this.cb_pagamentos.Text = "Dinheiro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(214, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo de pagamento";
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(501, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Desconto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(448, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor do Corte:";
            // 
            // tb_valor
            // 
            this.tb_valor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(20, 105);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(175, 23);
            this.tb_valor.TabIndex = 2;
            this.tb_valor.TextChanged += new System.EventHandler(this.tb_valor_TextChanged);
            this.tb_valor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_valor_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor";
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selecionar.Location = new System.Drawing.Point(304, 172);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(88, 22);
            this.btn_selecionar.TabIndex = 4;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // tb_cliente
            // 
            this.tb_cliente.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cliente.Location = new System.Drawing.Point(19, 171);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.ReadOnly = true;
            this.tb_cliente.Size = new System.Drawing.Size(287, 23);
            this.tb_cliente.TabIndex = 5;
            this.tb_cliente.Text = "Escolha o cliente...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // cb_cortes
            // 
            this.cb_cortes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_cortes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cortes.FormattingEnabled = true;
            this.cb_cortes.Location = new System.Drawing.Point(217, 36);
            this.cb_cortes.MaxDropDownItems = 20;
            this.cb_cortes.Name = "cb_cortes";
            this.cb_cortes.Size = new System.Drawing.Size(175, 24);
            this.cb_cortes.TabIndex = 1;
            this.cb_cortes.SelectionChangeCommitted += new System.EventHandler(this.cb_cortes_SelectionChangeCommitted);
            this.cb_cortes.Click += new System.EventHandler(this.cb_cortes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(214, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Corte";
            // 
            // tb_nomeBarbeiro
            // 
            this.tb_nomeBarbeiro.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nomeBarbeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomeBarbeiro.Location = new System.Drawing.Point(19, 36);
            this.tb_nomeBarbeiro.Name = "tb_nomeBarbeiro";
            this.tb_nomeBarbeiro.ReadOnly = true;
            this.tb_nomeBarbeiro.Size = new System.Drawing.Size(192, 23);
            this.tb_nomeBarbeiro.TabIndex = 1;
            this.tb_nomeBarbeiro.Text = "Este texto não deve aparecer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 13);
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
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 54);
            this.panel2.TabIndex = 4;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(3, 14);
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
            this.btn_incluirServico.Location = new System.Drawing.Point(598, 14);
            this.btn_incluirServico.Name = "btn_incluirServico";
            this.btn_incluirServico.Size = new System.Drawing.Size(203, 37);
            this.btn_incluirServico.TabIndex = 6;
            this.btn_incluirServico.Text = "Incluir Serviço";
            this.btn_incluirServico.UseVisualStyleBackColor = true;
            this.btn_incluirServico.Click += new System.EventHandler(this.btn_incluirServico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(237, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adicionando Serviços";
            // 
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BarbeariaFogaca.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Serviço";
            this.Load += new System.EventHandler(this.FormServicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_incluirServico;
        private System.Windows.Forms.ComboBox cb_pagamentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_desconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_cortes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nomeBarbeiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_valorEscrito;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancelar;
    }
}