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
    public partial class FormCorte : Form
    {
        public FormCorte()
        {
            InitializeComponent();
        }

        private void FormCorte_Load(object sender, EventArgs e)
        {
            atualizarDgv();
        }
        private void dgv_cortes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_cortes.SelectedRows.Count > 0)
            {
                string id = dgv_cortes.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = BuscarCorteSelecionado(id);
                tb_novo.Text = dt.Rows[0].Field<string>("T_NOMECORTE");
                tb_valor.Text = dt.Rows[0].Field<double>("D_VALOR").ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_novo_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if(dgv_cortes.SelectedRows.Count > 0)
            {
                string id = dgv_cortes.SelectedRows[0].Cells[0].Value.ToString();
                string nome = tb_novo.Text;
                string valor = Util.formatarValor(tb_valor.Text);
                Corte corte = new Corte(nome, valor);
                AlterarCorte(corte, id);

                atualizarDgv();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void atualizarDgv()
        {
            dgv_cortes.DataSource = BuscarCortes();
            dgv_cortes.Columns[0].Width = 60;
            dgv_cortes.Columns[1].Width = 150;
            dgv_cortes.Columns[2].Width = 112;
        }
        private void btn_exluir_Click(object sender, EventArgs e)
        {
            if(dgv_cortes.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Deseja excluir este corte?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    string id = dgv_cortes.SelectedRows[0].Cells[0].Value.ToString();
                    ExcluirCorteSelecionado(id);
                    atualizarDgv();
                }
            }
        }

        //Metodos SQL

        private DataTable BuscarCortes()
        {
            DataTable dt = new DataTable();
            try
            {
                string vquery = String.Format("Select N_IDCORTE as 'ID',T_NOMECORTE as 'Nome do corte', D_VALOR as 'Valor do corte (R$)' FROM tb_cortes");
                return dt = Banco.dql(vquery);
            }
            catch(Exception e)
            {
                DialogResult res = MessageBox.Show("Erro ao obter cortes!", "Erro (Corte)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataTable BuscarCorteSelecionado(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                string vquery = String.Format(@"Select * FROM tb_cortes WHERE N_IDCORTE = {0}",id);
                return dt = Banco.dql(vquery);
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao obter corte!", "Erro (Corte)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void AlterarCorte(Corte c,string id)
        {
            try
            {
                string vquery = String.Format("UPDATE tb_cortes set T_NOMECORTE = '{0}', D_VALOR = {1} WHERE N_IDCORTE = {2}",c.nome,c.valor,id);
                Banco.dml(vquery);
                MessageBox.Show("Corte atualizado!","Sucesso");
            }
            catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao alterar corte, verifique o formato do valor!", "Erro (Corte)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirCorteSelecionado(string id)
        {
            try
            {
                string vquery = "DELETE FROM tb_cortes WHERE N_IDCORTE = " + id;
                Banco.dml(vquery);
            }
            catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao excluir corte!", "Erro (Corte)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
