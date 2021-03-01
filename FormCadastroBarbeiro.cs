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
    public partial class FormCadastroBarbeiro : Form
    {
        public FormCadastroBarbeiro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text != "" && tb_usuario.Text!="" && tb_senha.Text != "")
            {
                Barbeiro barbeiro = new Barbeiro();
                barbeiro.nome = tb_nome.Text;
                barbeiro.username = tb_usuario.Text;
                barbeiro.senha = tb_senha.Text;
                barbeiro.telefone = mtb_telefone.Text;
                barbeiro.nivel = Convert.ToInt32(Math.Round(n_acesso.Value,0));
                barbeiro.CPF = mtb_cpf.Text;
                CadastrarBarbeiro(barbeiro);
            }
            else
            {
                DialogResult res = MessageBox.Show("Os campos devem ser preenchidos antes do cadastro!", "Erro (Cadastro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CadastrarBarbeiro(Barbeiro b)
        {
            string vquery = String.Format(@"INSERT INTO tb_barbeiros(T_NOMEBARBEIRO,T_USUARIO,T_SENHA,N_NIVEL,T_TELEFONE,T_CPF) 
                        VALUES('{0}','{1}','{2}',{3},'{4}','{5}')",b.nome,b.username,b.senha,b.nivel,b.telefone,b.CPF);
            Banco.dml(vquery);
            MessageBox.Show("Barbeiro cadastrado com sucesso!", "Sucesso no cadastro");
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_usuario.Text = "";
            tb_senha.Text = "";
            mtb_telefone.Text = "";
            n_acesso.Value = 0;
            mtb_cpf.Text = "";

        }
    }
}
