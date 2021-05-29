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
            PopularComboBoxCortes();
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
            PopularComboBoxCortes();
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
            if (tb_cliente.Text == "")
            {
                return false;
            }
            return true;
        }

        public void PopularTextBoxValores()
        {
            string id = cb_corte.SelectedValue.ToString();
            DataTable dt = ObterValores(id);
            tb_valor.Text = dt.Rows[0].Field<double>("D_VALOR").ToString();
        }

        private DataTable ObterValores(string id)
        {
            DataTable dt = new DataTable();
            string sql = "select D_VALOR FROM tb_cortes WHERE N_IDCORTE = " + id;
            return dt = Banco.dql(sql);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_data.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atualzarAgendamento();
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            FormSelecaoCliente formSelecao = new FormSelecaoCliente();
            formSelecao.ShowDialog();
            tb_cliente.Text = VariaveisServico.nomeCliente;
        }

        public void PopularComboBoxCortes()
        {
            DataTable dt = ObterCortes();
            cb_corte.DataSource = dt;
            cb_corte.DisplayMember = "T_NOMECORTE";
            cb_corte.ValueMember = "N_IDCORTE";

        }

        public DataTable ObterCortes()
        {
            DataTable dt = new DataTable();
            string sql = "Select N_IDCORTE,T_NOMECORTE from tb_cortes ORDER BY T_NOMECORTE";
            dt = Banco.dql(sql);
            return dt;
        }
    }
}
