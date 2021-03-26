namespace BarbeariaFogaca
{
    partial class FormFinanceiro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.mtb_final = new System.Windows.Forms.MaskedTextBox();
            this.mtb_inicial = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_lucro = new System.Windows.Forms.Label();
            this.lb_saida = new System.Windows.Forms.Label();
            this.dgv_financeiro = new System.Windows.Forms.DataGridView();
            this.btn_Despesa = new System.Windows.Forms.Button();
            this.btn_adcionarServico = new System.Windows.Forms.Button();
            this.btn_adicionarvenda = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_addEntrada = new System.Windows.Forms.Button();
            this.btn_alterarSelecionado = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_financeiro)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(341, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 35);
            this.label8.TabIndex = 31;
            this.label8.Text = "Painel Administrativo";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Selecione o periodo a ser exibido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_verificar);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.mtb_final);
            this.panel1.Controls.Add(this.mtb_inicial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(606, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 240);
            this.panel1.TabIndex = 41;
            // 
            // btn_verificar
            // 
            this.btn_verificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_verificar.Location = new System.Drawing.Point(160, 214);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(227, 23);
            this.btn_verificar.TabIndex = 42;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(160, 45);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 41;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected_1);
            // 
            // mtb_final
            // 
            this.mtb_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_final.Location = new System.Drawing.Point(3, 167);
            this.mtb_final.Mask = "00/00/0000";
            this.mtb_final.Name = "mtb_final";
            this.mtb_final.Size = new System.Drawing.Size(151, 26);
            this.mtb_final.TabIndex = 39;
            this.mtb_final.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_inicial
            // 
            this.mtb_inicial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtb_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_inicial.Location = new System.Drawing.Point(3, 87);
            this.mtb_inicial.Mask = "00/00/0000";
            this.mtb_inicial.Name = "mtb_inicial";
            this.mtb_inicial.Size = new System.Drawing.Size(151, 26);
            this.mtb_inicial.TabIndex = 38;
            this.mtb_inicial.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Data Final";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Data Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(603, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Valor total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BarbeariaFogaca.Properties.Resources.TotalDinheiro;
            this.pictureBox1.Location = new System.Drawing.Point(608, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(601, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "Lucro total";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BarbeariaFogaca.Properties.Resources.lucroDinheiro;
            this.pictureBox2.Location = new System.Drawing.Point(608, 433);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(603, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "Saida total";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BarbeariaFogaca.Properties.Resources.saidaDinheiro;
            this.pictureBox3.Location = new System.Drawing.Point(608, 516);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_total.Location = new System.Drawing.Point(692, 368);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(94, 31);
            this.lb_total.TabIndex = 51;
            this.lb_total.Text = "R$ 0,0";
            // 
            // lb_lucro
            // 
            this.lb_lucro.AutoSize = true;
            this.lb_lucro.BackColor = System.Drawing.Color.Transparent;
            this.lb_lucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lucro.ForeColor = System.Drawing.Color.LightGreen;
            this.lb_lucro.Location = new System.Drawing.Point(692, 436);
            this.lb_lucro.Name = "lb_lucro";
            this.lb_lucro.Size = new System.Drawing.Size(94, 31);
            this.lb_lucro.TabIndex = 52;
            this.lb_lucro.Text = "R$ 0,0";
            // 
            // lb_saida
            // 
            this.lb_saida.AutoSize = true;
            this.lb_saida.BackColor = System.Drawing.Color.Transparent;
            this.lb_saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saida.ForeColor = System.Drawing.Color.Red;
            this.lb_saida.Location = new System.Drawing.Point(692, 516);
            this.lb_saida.Name = "lb_saida";
            this.lb_saida.Size = new System.Drawing.Size(94, 31);
            this.lb_saida.TabIndex = 53;
            this.lb_saida.Text = "R$ 0,0";
            // 
            // dgv_financeiro
            // 
            this.dgv_financeiro.AllowUserToAddRows = false;
            this.dgv_financeiro.AllowUserToDeleteRows = false;
            this.dgv_financeiro.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_financeiro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_financeiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_financeiro.EnableHeadersVisualStyles = false;
            this.dgv_financeiro.Location = new System.Drawing.Point(3, 89);
            this.dgv_financeiro.MultiSelect = false;
            this.dgv_financeiro.Name = "dgv_financeiro";
            this.dgv_financeiro.ReadOnly = true;
            this.dgv_financeiro.RowHeadersVisible = false;
            this.dgv_financeiro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_financeiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_financeiro.Size = new System.Drawing.Size(597, 517);
            this.dgv_financeiro.TabIndex = 1;
            // 
            // btn_Despesa
            // 
            this.btn_Despesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Despesa.Location = new System.Drawing.Point(856, 350);
            this.btn_Despesa.Name = "btn_Despesa";
            this.btn_Despesa.Size = new System.Drawing.Size(140, 37);
            this.btn_Despesa.TabIndex = 2;
            this.btn_Despesa.Text = "Adicionar Despesa";
            this.btn_Despesa.UseVisualStyleBackColor = true;
            this.btn_Despesa.Click += new System.EventHandler(this.btn_Despesa_Click);
            // 
            // btn_adcionarServico
            // 
            this.btn_adcionarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adcionarServico.Location = new System.Drawing.Point(856, 393);
            this.btn_adcionarServico.Name = "btn_adcionarServico";
            this.btn_adcionarServico.Size = new System.Drawing.Size(140, 37);
            this.btn_adcionarServico.TabIndex = 3;
            this.btn_adcionarServico.Text = "Adicionar Serviço";
            this.btn_adcionarServico.UseVisualStyleBackColor = true;
            this.btn_adcionarServico.Click += new System.EventHandler(this.btn_adcionarServico_Click);
            // 
            // btn_adicionarvenda
            // 
            this.btn_adicionarvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionarvenda.Location = new System.Drawing.Point(856, 436);
            this.btn_adicionarvenda.Name = "btn_adicionarvenda";
            this.btn_adicionarvenda.Size = new System.Drawing.Size(140, 37);
            this.btn_adicionarvenda.TabIndex = 4;
            this.btn_adicionarvenda.Text = "Adicionar Venda";
            this.btn_adicionarvenda.UseVisualStyleBackColor = true;
            this.btn_adicionarvenda.Click += new System.EventHandler(this.btn_adicionarvenda_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(856, 524);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(140, 37);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir Selecionado";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_addEntrada
            // 
            this.btn_addEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEntrada.Location = new System.Drawing.Point(856, 307);
            this.btn_addEntrada.Name = "btn_addEntrada";
            this.btn_addEntrada.Size = new System.Drawing.Size(140, 37);
            this.btn_addEntrada.TabIndex = 54;
            this.btn_addEntrada.Text = "Adicionar Entrada";
            this.btn_addEntrada.UseVisualStyleBackColor = true;
            this.btn_addEntrada.Click += new System.EventHandler(this.btn_addEntrada_Click);
            // 
            // btn_alterarSelecionado
            // 
            this.btn_alterarSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarSelecionado.Location = new System.Drawing.Point(856, 481);
            this.btn_alterarSelecionado.Name = "btn_alterarSelecionado";
            this.btn_alterarSelecionado.Size = new System.Drawing.Size(140, 37);
            this.btn_alterarSelecionado.TabIndex = 55;
            this.btn_alterarSelecionado.Text = "Alterar Selecionado";
            this.btn_alterarSelecionado.UseVisualStyleBackColor = true;
            this.btn_alterarSelecionado.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(2, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 29);
            this.label13.TabIndex = 77;
            this.label13.Text = "Buscar registros..";
            // 
            // tb_filtro
            // 
            this.tb_filtro.Location = new System.Drawing.Point(3, 68);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(597, 20);
            this.tb_filtro.TabIndex = 76;
            this.tb_filtro.TextChanged += new System.EventHandler(this.tb_filtro_TextChanged);
            // 
            // FormFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::BarbeariaFogaca.Properties.Resources.fundoTelas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 618);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_filtro);
            this.Controls.Add(this.btn_alterarSelecionado);
            this.Controls.Add(this.btn_addEntrada);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_adicionarvenda);
            this.Controls.Add(this.btn_adcionarServico);
            this.Controls.Add(this.btn_Despesa);
            this.Controls.Add(this.dgv_financeiro);
            this.Controls.Add(this.lb_saida);
            this.Controls.Add(this.lb_lucro);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel do administrador";
            this.Load += new System.EventHandler(this.FormFinanceiro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_financeiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_lucro;
        private System.Windows.Forms.Label lb_saida;
        private System.Windows.Forms.MaskedTextBox mtb_final;
        private System.Windows.Forms.MaskedTextBox mtb_inicial;
        private System.Windows.Forms.DataGridView dgv_financeiro;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Button btn_Despesa;
        private System.Windows.Forms.Button btn_adcionarServico;
        private System.Windows.Forms.Button btn_adicionarvenda;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_addEntrada;
        private System.Windows.Forms.Button btn_alterarSelecionado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_filtro;
    }
}