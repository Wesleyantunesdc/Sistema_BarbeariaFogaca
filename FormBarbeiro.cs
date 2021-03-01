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
    public partial class FormBarbeiro : Form
    {
        public FormBarbeiro()
        {
            InitializeComponent();
        }

        private void FormBarbeiro_Load(object sender, EventArgs e)
        {
            AtualizarDgv();
        }

        private void dgv_barbeiros_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgv_barbeiros.SelectedRows.Count > 0)
            {
                string id = dgv_barbeiros.SelectedRows[0].Cells[0].Value.ToString();
                dt = ObterBarbeiroSelecionado(id);
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEBARBEIRO");
                tb_usuario.Text = dt.Rows[0].Field<string>("T_USUARIO");
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHA");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                mtb_cpf.Text = dt.Rows[0].Field<string>("T_CPF");
                n_acesso.Value = dt.Rows[0].Field<Int64>("N_NIVEL");
                
            }
        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string id = dgv_barbeiros.SelectedRows[0].Cells[0].Value.ToString();
            Barbeiro barb = new Barbeiro();
            barb.nome = tb_nome.Text;
            barb.username = tb_usuario.Text;
            barb.senha = tb_senha.Text;
            barb.telefone = mtb_telefone.Text;
            barb.CPF = mtb_cpf.Text;
            barb.nivel = int.Parse(n_acesso.Value.ToString());
            AlterarBarbeiro(barb,id);
            AtualizarDgv();
        }
        private void btn_exluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja exluir o barbeiro selecionado ?", "Exluir", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                string id = dgv_barbeiros.SelectedRows[0].Cells[0].Value.ToString();
                excluir(id);
                AtualizarDgv();
            }
            
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Metodo que formata o datagredview
        private void AtualizarDgv()
        {
            dgv_barbeiros.DataSource = ObterBarbeiros();
            dgv_barbeiros.Columns[0].Width = 50;
            dgv_barbeiros.Columns[1].Width = 180;
            dgv_barbeiros.Columns[2].Width = 150;
            dgv_barbeiros.Focus();
        }

        ///Metodos que possuem comando sql
        ///
        ////
        ////
        ///

        private DataTable ObterBarbeiros()
        {
            DataTable dt = new DataTable();
            try
            {
                string vquery = "SELECT N_IDBARBEIRO as 'ID',T_NOMEBARBEIRO as 'Nome',T_USUARIO as 'Usuario' FROM " +
                    "tb_barbeiros";
                return dt = Banco.dql(vquery);
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter barbeiro!", "Erro (Barbeiro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataTable ObterBarbeiroSelecionado(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                string vquery = String.Format(@"SELECT * FROM tb_barbeiros WHERE N_IDBARBEIRO = {0}", id);
                dt = Banco.dql(vquery);
                return dt;
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter barbeiros", "Erro (Barbeiro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void AlterarBarbeiro(Barbeiro barb,string id)
        {
            try
            {
                string vquery = String.Format(@"
                UPDATE tb_barbeiros SET T_NOMEBARBEIRO = '{0}',
                T_USUARIO = '{1}', T_SENHA = '{2}', N_NIVEL = {3}, T_TELEFONE = '{4}', T_CPF = '{5}'
                WHERE N_IDBARBEIRO = {6}", barb.nome, barb.username, barb.senha, barb.nivel, barb.telefone, barb.CPF, id);
                Banco.dml(vquery);
            }
            catch(Exception e)
            {
                DialogResult res = MessageBox.Show("Erro ao alterar barbeiro!", "Erro (Barbeiro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excluir(string id)
        {
            try
            {
                string vquery =String.Format(@"Delete from tb_barbeiros WHERE N_IDBARBEIRO = {0}", id);
                Banco.dml(vquery);
            }
            catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao excluir barbeiro!", "Erro (Barbeiro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
