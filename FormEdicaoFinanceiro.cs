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
        public FormEdicaoFinanceiro(Financeiro f)
        {
            InitializeComponent();
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
            FormSelecaoCliente formSelecaoCliente = new FormSelecaoCliente();
            formSelecaoCliente.ShowDialog();
            tb_cliente.Text = VariaveisServico.nomeCliente;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            tb_data.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
    }
}
