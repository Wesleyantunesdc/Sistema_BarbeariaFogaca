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
    public partial class FormSelecaoCliente : Form
    {
        public FormSelecaoCliente()
        {
            InitializeComponent();
        }
        private void FormSelecaoCliente_Load(object sender, EventArgs e)
        {
            AtualizarDgv();
            VariaveisServico.idCliente = int.Parse(tb_id.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgv_clientes.SelectedRows.Count > 0)
            {
                string id = dgv_clientes.SelectedRows[0].Cells[0].Value.ToString();
                dt = ObterClienteSelecionado(id);
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMECLIENTE");
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDCLIENTE").ToString();
                tb_cortes.Text = dt.Rows[0].Field<Int64>("N_QUANTIDADECORTES").ToString();
            }
        }

        private void AtualizarDgv()
        {
            dgv_clientes.DataSource = ObterClientes(tb_filtro.Text);
            dgv_clientes.Columns[0].Width = 50;
            dgv_clientes.Columns[1].Width = 180;
            dgv_clientes.Columns[2].Width = 100;
            dgv_clientes.Columns[3].Width = 100;
            tb_filtro.Focus();
        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            VariaveisServico.idCliente = int.Parse(tb_id.Text);
            VariaveisVenda.idCliente = int.Parse(tb_id.Text);
            VariaveisServico.nomeCliente = tb_nome.Text;
            this.Close();
        }

        //Botão de cadastro
        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastro = new FormCadastroCliente();
            formCadastro.ShowDialog();
            AtualizarDgv();
        }
        //Metodos sql

        public DataTable ObterClientes(string textoFiltro)
        {
            DataTable dt = new DataTable();
            try
            {
                string vquery = String.Format("SELECT N_IDCLIENTE as 'ID',T_NOMECLIENTE as 'Nome do cliente',T_TELEFONE as 'Telefone',T_CATEGORIA as 'Categoria' FROM " +
                    "tb_clientes where T_NOMECLIENTE LIKE '{0}%'",textoFiltro);
                return dt = Banco.dql(vquery);
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter clientes!", "Erro (Cliente)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        public DataTable ObterClienteSelecionado(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                string vquery = String.Format(@"SELECT * FROM tb_clientes WHERE N_IDCLIENTE = {0}", id);
                dt = Banco.dql(vquery);
                return dt;
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter cliente selecionado!", "Erro (Cliente)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void tb_filtro_TextChanged(object sender, EventArgs e)
        {
            AtualizarDgv();
        }
    }
}
