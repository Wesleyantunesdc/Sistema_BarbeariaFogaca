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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            Atualizardgv();
        }
        private void dgv_produtos_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgv_produtos.SelectedRows.Count > 0)
            {
                string id = dgv_produtos.SelectedRows[0].Cells[0].Value.ToString();
                dt = ObterProdutoSelecionado(id);
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEPRODUTO");
                tb_marca.Text = dt.Rows[0].Field<string>("T_MARCA");
                tb_descricao.Text = dt.Rows[0].Field<string>("T_DESCRICAO");
                tb_valorProduto.Text = dt.Rows[0].Field<decimal>("D_VALOR").ToString();
                n_quantidade.Value = Decimal.Parse(dt.Rows[0].Field<Int64>("N_QUANTIDADE").ToString());
               
            }
        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if(dgv_produtos.SelectedRows.Count > 0)
            {
                string id = dgv_produtos.SelectedRows[0].Cells[0].Value.ToString();
                Produto produto = new Produto();
                produto.nome = tb_nome.Text;
                produto.marca = tb_marca.Text;
                produto.descricao = tb_descricao.Text;
                produto.quantidade = int.Parse(n_quantidade.Value.ToString());
                produto.valor = Util.formatarValor(tb_valorProduto.Text);
                AlterarProdutoSelecionado(produto, id);
                Atualizardgv();
            }

        }
        private void btn_exluir_Click(object sender, EventArgs e)
        {
            if (dgv_produtos.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Deseja relamente excluir este produto ?","Excluir",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(res == DialogResult.Yes)
                {
                    string id = dgv_produtos.SelectedRows[0].Cells[0].Value.ToString();
                    ExcluirProdutoSelecionado(id);
                    Atualizardgv();
                }
                
            }
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodos uteis
        public void Atualizardgv()
        {
            dgv_produtos.DataSource = ObterProdutos(tb_filtro.Text);
            dgv_produtos.Columns[0].Width = 60;
            dgv_produtos.Columns[1].Width = 150;
            dgv_produtos.Columns[2].Width = 140;
            dgv_produtos.Columns[3].Width = 110;
            tb_filtro.Focus();
        }

        //Metodos SQL
        public DataTable ObterProdutos(string textoFiltro)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = String.Format("SELECT N_IDPRODUTO as 'ID',T_NOMEPRODUTO as 'Nome do Produto',T_MARCA as 'Marca'," +
                    "D_VALOR as 'Valor do produto' FROM tb_produtos WHERE T_NOMEPRODUTO LIKE '{0}%'",textoFiltro);
                return dt = Banco.dql(sql);
            }
            catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter produtos!", "Erro (Produto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public DataTable ObterProdutoSelecionado(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * from tb_produtos WHERE N_IDPRODUTO = "+id;
                return dt = Banco.dql(sql);

            }catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter produto selecionado!", "Erro (Produto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void AlterarProdutoSelecionado(Produto produto,string id)
        {
            try
            {
                string sql = String.Format(@"UPDATE tb_produtos SET T_NOMEPRODUTO = '{0}', T_MARCA = '{1}',T_DESCRICAO = '{2}', N_QUANTIDADE = {3},D_VALOR = {4}
                WHERE N_IDPRODUTO = {5}",produto.nome,produto.marca,produto.descricao,produto.quantidade,produto.valor,id);
                Banco.dml(sql);
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao alterar o produto selecionado!", "Erro (Produto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExcluirProdutoSelecionado(string id)
        {
            try
            {
                string sql = "DELETE FROM tb_produtos WHERE N_IDPRODUTO = "+id;
                Banco.dml(sql);
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao excluir produto!", "Erro (Produto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tb_filtro_TextChanged(object sender, EventArgs e)
        {
            Atualizardgv();
        }
    }
}
