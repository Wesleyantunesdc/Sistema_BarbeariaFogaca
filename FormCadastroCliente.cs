using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaFogaca
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
            tb_nome.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text != "" && cb_categoria.Text != "" && mtb_telefone.Text != "")
            {
                Cliente cliente = new Cliente();
                cliente.nome = tb_nome.Text;
                cliente.email = tb_email.Text;
                cliente.telefone = mtb_telefone.Text;
                cliente.categoria = cb_categoria.Text;
                
                Cadastrar(cliente);
                MessageBox.Show("Cliente Cadastrado com suceeso!","Sucesso!");
                LimparCampos();
            }
            else
            {
                DialogResult res = MessageBox.Show("Valos preenchidos de forma incorreta!", "Erro (Cadastro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        public void Cadastrar(Cliente cliente)
        {
            try
            {
                string vquery = String.Format(@"INSERT INTO tb_clientes(T_NOMECLIENTE,T_EMAIL,T_TELEFONE,T_CATEGORIA) 
                    values ('{0}','{1}','{2}','{3}')", cliente.nome, cliente.email, cliente.telefone, cliente.categoria);
                Banco.dml(vquery);
            }catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao cadastrar cliente!", "Erro (Cadastro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //Metodos comuns
        public void LimparCampos()
        {
            tb_nome.Text = "";
            tb_email.Text = "";
            cb_categoria.Text = "";
            mtb_telefone.Text = "";
            tb_nome.Focus();
        }
        //Metódos sql

    }
}
