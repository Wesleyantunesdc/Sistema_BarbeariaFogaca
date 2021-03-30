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
    public partial class FormEdicaoFinanceiro : Form
    {
        Financeiro financeiro;
        public FormEdicaoFinanceiro(Financeiro f)
        {
            InitializeComponent();
            this.financeiro = f;
            this.tb_id.Text = f.id.ToString();
            this.tb_barbeiro.Text = f.barbeiro;
            this.tb_cliente.Text = f.cliente;
            this.tb_descricao.Text = f.descricao;
            this.tb_valor.Text = f.valor.ToString();
            this.tb_data.Text = Util.formatarExibicaoData(f.data);
            this.cb_tipoPagamento.Text = f.tipoPagamento;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Não é possivel alterar o cliente, pois esse registro pertence a este cliente","Operação impossivel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            tb_data.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (validarObjeto())
            {
                this.financeiro.id = int.Parse(this.tb_id.Text);
                this.financeiro.barbeiro = this.tb_barbeiro.Text;
                this.financeiro.cliente = this.tb_cliente.Text;
                this.financeiro.descricao = this.tb_descricao.Text;
                this.financeiro.valor = Decimal.Parse(this.tb_valor.Text);
                this.financeiro.data = tb_data.Text;
                this.financeiro.tipoPagamento = cb_tipoPagamento.Text;

                string sql = String.Format("UPDATE tb_financeiro SET T_BARBEIRO = '{0}', T_DESCRICAO = '{1}'," +
                    " D_VALOR = '{2}', D_DATA = '{3}', T_TIPOPAGAMENTO = '{4}' " +
                    " WHERE N_IDFINANCEIRO = {5}",financeiro.barbeiro,financeiro.descricao,financeiro.valor,Util.FormatarInsercaoData(financeiro.data),financeiro.tipoPagamento,financeiro.id);
                alterarRegistroFinanceiro(sql);
            }
            else
            {
                DialogResult res = MessageBox.Show("Erro ao alterar agendamento no banco, verifique os campos!", "Erro(Agendamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarObjeto()
        {
            if(tb_barbeiro.Text == "" || tb_barbeiro.Text == null)
            {
                return false;
            }

            if(tb_cliente.Text == "" || tb_cliente.Text == null)
            {
                return false;
            }

            if(tb_descricao.Text == "" || tb_descricao == null)
            {
                return false;
            }

            if(cb_tipoPagamento.Text == "" || tb_descricao.Text == null)
            {
                return false;
            }

            try
            {
                Decimal.Parse(tb_valor.Text);
            }catch(Exception e)
            {
                return false;
            }

            return true;
        }

        private void alterarRegistroFinanceiro(string sql)
        {
            try
            {
                Banco.dml(sql);
                DialogResult res = MessageBox.Show("Alteração realizada com sucesso!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception e)
            {
                DialogResult res = MessageBox.Show("Erro ao alterar agendamento no banco!", "Erro(Agendamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
