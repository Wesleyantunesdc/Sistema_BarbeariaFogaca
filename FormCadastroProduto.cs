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
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
            tb_nome.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text != "" && n_quantidade.Value.ToString() != "" && tb_valorProduto.Text != "")
            {
                Produto p = new Produto();
                p.nome = tb_nome.Text;
                p.marca = tb_marca.Text;
                p.descricao = tb_descricao.Text;
                p.quantidade = int.Parse(n_quantidade.Value.ToString());
                p.valor = Util.formatarValor(tb_valorProduto.Text);
                CadastrarProduto(p);
                Limpar();
            }
            else
            {
                DialogResult res = MessageBox.Show("Valores preenchidos de forma incorreta!", "Erro (Cadastro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        //Funções uteis
        public void Limpar()
        {
            tb_nome.Text = "";
            tb_marca.Text = "";
            tb_descricao.Text = "";
            tb_valorProduto.Text = "";
            n_quantidade.Value = 0;
            tb_nome.Focus();
        }

        //Funções sql
        private void CadastrarProduto(Produto p)
        {
            try
            {
                string sql = String.Format(@"INSERT INTO tb_produtos(T_NOMEPRODUTO,T_MARCA,T_DESCRICAO,N_QUANTIDADE,D_VALOR)
                                VALUES ('{0}','{1}','{2}',{3},{4})", p.nome, p.marca,p.descricao,p.quantidade,p.valor) ;
                Banco.dml(sql);
                MessageBox.Show("Cadastro realizado com sucesso!","Sucesso");
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Não foi possivel cadastrar o produto!", "Erro (Cadastro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
