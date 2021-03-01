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
    public partial class FormClientecs : Form
    {
        public FormClientecs()
        {
            InitializeComponent();
        }

        private void FormClientecs_Load(object sender, EventArgs e)
        {
            AtualizarDgv();
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgv_clientes.SelectedRows.Count > 0)
            {
                string id = dgv_clientes.SelectedRows[0].Cells[0].Value.ToString();
                dt = ObterClienteSelecionado(id);
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMECLIENTE");
                tb_email.Text = dt.Rows[0].Field<string>("T_EMAIL");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cb_cat.Text = dt.Rows[0].Field<string>("T_CATEGORIA");
                tb_creditos.Text = dt.Rows[0].Field<string>("T_CREDITOS");
                tb_devendo.Text = dt.Rows[0].Field<string>("T_DEVENDO");
                n_cortes.Value = int.Parse(dt.Rows[0].Field<Int64>("N_QUANTIDADECORTES").ToString());
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string id = dgv_clientes.SelectedRows[0].Cells[0].Value.ToString();
            Cliente cliente = new Cliente();
            cliente.nome = tb_nome.Text;
            cliente.telefone = mtb_telefone.Text;
            cliente.email = tb_email.Text;
            cliente.categoria = cb_cat.Text;
            cliente.creditos = tb_creditos.Text;
            cliente.devendo = tb_devendo.Text;
            cliente.cortes = int.Parse(n_cortes.Value.ToString());
            AlterarCliente(cliente, id);
            AtualizarDgv();

            
            
        }
        private void btn_exluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente exluir o cliente selecionado ?", "Exlusão", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                string id = dgv_clientes.SelectedRows[0].Cells[0].Value.ToString();
                ExcluirCliente(id);
                AtualizarDgv();
            }
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
        }

        //Metodos Uteis
           private void AtualizarDgv()
        {
            dgv_clientes.DataSource = ObterClientes(tb_filtro.Text);
            dgv_clientes.Columns[0].Width = 70;
            dgv_clientes.Columns[1].Width = 200;
            dgv_clientes.Columns[2].Width = 100;
            dgv_clientes.Columns[3].Width = 100;
            tb_filtro.Focus();
        }
        //Metodos sql

        public DataTable ObterClientes(string textoFiltro)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = String.Format("SELECT N_IDCLIENTE as 'ID',T_NOMECLIENTE as 'Nome do cliente',T_TELEFONE as 'Telefone'," +
                                     "T_CATEGORIA as 'Categoria' FROM tb_clientes where T_NOMECLIENTE LIKE  '{0}%';", textoFiltro);
                return dt = Banco.dql(query);
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter cliente!", "Erro (Cliente)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public DataTable ObterClienteSelecionado(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                string vquery = String.Format(@"SELECT * FROM tb_clientes WHERE N_IDCLIENTE = {0}",id);
                dt = Banco.dql(vquery);
                return dt;
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter clientes!", "Erro (Cliente)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void AlterarCliente(Cliente c,string id)
        {
            try
            {
            string vquery = String.Format(@"UPDATE tb_clientes SET T_NOMECLIENTE = '{0}',T_EMAIL = '{1}',T_TELEFONE= '{2}',T_CATEGORIA= '{3}',
                T_CREDITOS = '{4}',T_DEVENDO = '{5}',N_QUANTIDADECORTES = {6} WHERE N_IDCLIENTE = {7}", c.nome, c.email, c.telefone, c.categoria, c.creditos, c.devendo, c.cortes, id);
             Banco.dml(vquery);
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao alterar os dados!", "Erro (Cliente)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void ExcluirCliente(string id)
        {
            try
            {
                string vquery = string.Format(@"DELETE FROM tb_clientes WHERE N_IDCLIENTE = {0}", id);
                Banco.dml(vquery);
            }catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao excluir cliente!", "Erro (Cliente)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizarDgv();
        }
    }
}
