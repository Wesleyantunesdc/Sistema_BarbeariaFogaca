namespace BarbeariaFogaca
{
    partial class FormSelecaoCliente
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_cortes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Selecionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.Location = new System.Drawing.Point(9, 115);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(444, 483);
            this.dgv_clientes.TabIndex = 1;
            this.dgv_clientes.SelectionChanged += new System.EventHandler(this.dgv_clientes_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome do Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(19, 119);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.ReadOnly = true;
            this.tb_nome.Size = new System.Drawing.Size(260, 23);
            this.tb_nome.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tb_cortes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(459, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 303);
            this.panel1.TabIndex = 30;
            // 
            // tb_cortes
            // 
            this.tb_cortes.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_cortes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cortes.Location = new System.Drawing.Point(19, 210);
            this.tb_cortes.Name = "tb_cortes";
            this.tb_cortes.ReadOnly = true;
            this.tb_cortes.Size = new System.Drawing.Size(260, 23);
            this.tb_cortes.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Quantidade de cortes";
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(19, 30);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(260, 23);
            this.tb_id.TabIndex = 31;
            this.tb_id.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(231, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(362, 35);
            this.label8.TabIndex = 32;
            this.label8.Text = "Selecione um cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(4, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Clientes cadastrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(473, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cliente Selecionado";
            // 
            // btn_Selecionar
            // 
            this.btn_Selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selecionar.Location = new System.Drawing.Point(459, 424);
            this.btn_Selecionar.Name = "btn_Selecionar";
            this.btn_Selecionar.Size = new System.Drawing.Size(322, 83);
            this.btn_Selecionar.TabIndex = 2;
            this.btn_Selecionar.Text = "Selecionar";
            this.btn_Selecionar.UseVisualStyleBackColor = true;
            this.btn_Selecionar.Click += new System.EventHandler(this.btn_Selecionar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(462, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 85);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cadastrar Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_filtro
            // 
            this.tb_filtro.Location = new System.Drawing.Point(9, 92);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(444, 20);
            this.tb_filtro.TabIndex = 39;
            this.tb_filtro.TextChanged += new System.EventHandler(this.tb_filtro_TextChanged);
            // 
            // FormSelecaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BarbeariaFogaca.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 610);
            this.Controls.Add(this.tb_filtro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Selecionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelecaoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelecaoCliente";
            this.Load += new System.EventHandler(this.FormSelecaoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Selecionar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cortes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_filtro;
    }
}