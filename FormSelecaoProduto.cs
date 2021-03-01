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
    public partial class FormSelecaoProduto : Form
    {
        public FormSelecaoProduto()
        {
            InitializeComponent();
        }

        private void FormSelecaoProduto_Load(object sender, EventArgs e)
        {
            AtualizarDgv();
        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            VariaveisVenda.idProduto = int.Parse(tb_id.Text);
            VariaveisVenda.quantidadeDisponivel = int.Parse(tb_quantidade.Text);
            VariaveisVenda.preco = Convert.ToDecimal(tb_preco.Text);
            VariaveisVenda.nomeProduto = tb_nome.Text;
            this.Close();
        }

        private void dgv_produtos_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgv_produtos.SelectedRows.Count > 0)
            {
                string id = dgv_produtos.SelectedRows[0].Cells[0].Value.ToString();
                dt = ObterProdutoSelecionado(id);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDPRODUTO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEPRODUTO");
                tb_preco.Text = dt.Rows[0].Field<decimal>("D_VALOR").ToString();
                tb_quantidade.Text = dt.Rows[0].Field<Int64>("N_QUANTIDADE").ToString();
            }
        }

        private void AtualizarDgv()
        {
            dgv_produtos.DataSource = ObterProdutos(tb_filtro.Text);
            dgv_produtos.Columns[0].Width = 50;
            dgv_produtos.Columns[1].Width = 120;
            dgv_produtos.Columns[2].Width = 100;
            dgv_produtos.Columns[3].Width = 75;
            dgv_produtos.Columns[4].Width = 75;
            tb_filtro.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastro = new FormCadastroProduto();
            formCadastro.ShowDialog();
            AtualizarDgv();
        }
        //Metodos SQL
        public DataTable ObterProdutos(string textoFiltro)
        {
            DataTable dt = new DataTable();
            try
            {
                string vquery = String.Format("SELECT N_IDPRODUTO, T_NOMEPRODUTO , T_MARCA, N_QUANTIDADE, D_VALOR FROM " +
                    "tb_produtos WHERE T_NOMEPRODUTO LIKE '{0}%'",textoFiltro);
                return dt = Banco.dql(vquery);
            }
            catch (Exception ex)
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
                string vquery = String.Format(@"SELECT * FROM tb_produtos WHERE N_IDPRODUTO = {0}", id);
                dt = Banco.dql(vquery);
                return dt;
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter produto selecionado!!", "Erro (Produto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Erro ao obter produto!", "Erro do sistema");
                return null;
            }
        }

        private void tb_filtro_TextChanged(object sender, EventArgs e)
        {
            AtualizarDgv();
        }
    }
}
