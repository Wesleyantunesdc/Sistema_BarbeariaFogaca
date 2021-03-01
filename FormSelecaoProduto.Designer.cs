namespace BarbeariaFogaca
{
    partial class FormSelecaoProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Selecionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(459, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 85);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cadastrar Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(454, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Produto Selecionado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, -21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Todos os clientes cadastrados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(234, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 35);
            this.label8.TabIndex = 39;
            this.label8.Text = "Selecione um produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tb_quantidade);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_preco);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(459, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 303);
            this.panel1.TabIndex = 38;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantidade.Location = new System.Drawing.Point(17, 230);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.ReadOnly = true;
            this.tb_quantidade.Size = new System.Drawing.Size(259, 23);
            this.tb_quantidade.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(13, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quantidade disponivel";
            // 
            // tb_preco
            // 
            this.tb_preco.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preco.Location = new System.Drawing.Point(17, 164);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.ReadOnly = true;
            this.tb_preco.Size = new System.Drawing.Size(260, 23);
            this.tb_preco.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Valor do produto";
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(18, 29);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(259, 23);
            this.tb_id.TabIndex = 31;
            this.tb_id.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID";
            // 
            // tb_nome
            // 
            this.tb_nome.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(17, 98);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.ReadOnly = true;
            this.tb_nome.Size = new System.Drawing.Size(260, 23);
            this.tb_nome.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome do Produto";
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_produtos.EnableHeadersVisualStyles = false;
            this.dgv_produtos.Location = new System.Drawing.Point(9, 115);
            this.dgv_produtos.MultiSelect = false;
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(444, 483);
            this.dgv_produtos.TabIndex = 1;
            this.dgv_produtos.SelectionChanged += new System.EventHandler(this.dgv_produtos_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(4, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 26);
            this.label6.TabIndex = 44;
            this.label6.Text = "Produtos cadastrados";
            // 
            // tb_filtro
            // 
            this.tb_filtro.Location = new System.Drawing.Point(9, 92);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(444, 20);
            this.tb_filtro.TabIndex = 45;
            this.tb_filtro.TextChanged += new System.EventHandler(this.tb_filtro_TextChanged);
            // 
            // FormSelecaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BarbeariaFogaca.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 610);
            this.Controls.Add(this.tb_filtro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Selecionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelecaoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tele de seleção de produtos";
            this.Load += new System.EventHandler(this.FormSelecaoProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Selecionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_filtro;
    }
}