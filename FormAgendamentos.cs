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

    public partial class FormAgendamentos : Form
    {
        private Agendamento agendamento;
        public FormAgendamentos()
        {
            InitializeComponent();
            this.agendamento = new Agendamento();
            tb_id.Text = "";
            tb_data.Text = "";
            mtb_horario.Text = "";
            tb_cliente.Text = "";
            cb_corte.Text = "";
            tb_valor.Text = "";
        }

        public FormAgendamentos(Agendamento agendamento)
        {
            InitializeComponent();
            this.agendamento = agendamento;
            tb_id.Text = this.agendamento.id.ToString();
            tb_data.Text = this.agendamento.data.ToShortDateString();
            mtb_horario.Text = this.agendamento.data.ToShortTimeString();
            tb_cliente.Text = this.agendamento.cliente;
            cb_corte.Text = this.agendamento.corte;
            tb_valor.Text = this.agendamento.valor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inserirAgendamentoBanco()
        {
            string dataFormatada = tb_data.Text +" "+ mtb_horario.Text+":00";
            this.agendamento.data = DateTime.Parse(dataFormatada);
            try
            {
                string sql = String.Format(@"INSERT INTO tb_agendamentos(DT_DATA,T_CLIENTE,T_CORTE,T_VALOR,B_ATENDIDO) values ('{0}','{1}','{2}','{3}','{4}')",
                    agendamento.data,agendamento.cliente,agendamento.corte,agendamento.valor,false);
                Banco.dml(sql);
            }
            catch (Exception e)
            {
                DialogResult res = MessageBox.Show("Erro ao inserir agendamento no banco!", "Erro(Agendamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atualzarAgendamento()
        {
            string dataFormatada = tb_data.Text + " " + mtb_horario.Text + ":00";
            this.agendamento.data = DateTime.Parse(dataFormatada);
            this.agendamento.cliente = tb_cliente.Text;
            this.agendamento.corte = cb_corte.Text;
            this.agendamento.valor = tb_valor.Text;
            try
            {
                string sql = String.Format(@"UPDATE tb_agendamentos SET DT_DATA = '{0}',T_CLIENTE = '{1}',
                    T_CORTE = '{2}', T_VALOR= '{3}', B_ATENDIDO = {4} WHERE N_ID = {5}",
                    agendamento.data, agendamento.cliente, agendamento.corte, agendamento.valor, check_atendido.Checked, agendamento.id);
                Banco.dml(sql);
            }
            catch(Exception e)
            {
                DialogResult res = MessageBox.Show("Erro ao atualizar agendamento no banco!", "Erro(Agendamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                try
                {
                    this.agendamento = new Agendamento();
                    agendamento.data = DateTime.Parse(tb_data.Text);
                    agendamento.cliente = tb_cliente.Text;
                    agendamento.corte = cb_corte.Text;
                    agendamento.valor = tb_valor.Text;
                    inserirAgendamentoBanco();
                }catch (Exception ex)
                {
                    DialogResult res = MessageBox.Show("Erro ao inserir agendamento no banco!", "Erro(Campos do agendamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                DialogResult res = MessageBox.Show("Erro ao inserir agendamento no banco!", "Erro(Campos do agendamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private bool verificarCampos()
        {
            return true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_data.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atualzarAgendamento();
        }
    }
}
