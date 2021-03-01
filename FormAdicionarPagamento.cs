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
    public partial class FormAdicionarPagamento : Form
    {
        private string data = "";
        public FormAdicionarPagamento()
        {
            InitializeComponent();
        }

        private void FormAdicionarPagamento_Load(object sender, EventArgs e)
        {
            tb_nomeBarbeiro.Text = Util.nomeBarbeiro;
            VariaveisEntrada.data = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpar()
        {
            tb_valor.Text = "";
            tb_descricao.Text = "";
            cb_pagamentos.Text = "Dinheiro";
            tb_cliente.Text = "Escolha o cliente...";
        }

        private bool ValidarFormulario()
        {
            //validação se o nome do barbeiro esta preenchido!
            if (tb_nomeBarbeiro.Text == "")
            {
                DialogResult res = MessageBox.Show("Erro ao validar barbeiro, este erro não deveria acontecer!", "Erro (Barbeiro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Validação do valor
            try
            {
                if (tb_valor.Text == "")
                {
                    DialogResult res = MessageBox.Show("Erro ao validar valor, valor não foi preenchido!", "Erro (Valor)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    VariaveisEntrada.valor = Convert.ToDecimal(tb_valor.Text.Replace('.', ','));
                }
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao validar valor, preencha de forma correta!", "Erro (Valor)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Validação do pagamento
            bool validacao = false;
            for (int i = 0; i < cb_pagamentos.Items.Count; i++)
            {
                if (cb_pagamentos.Text == cb_pagamentos.Items[i].ToString())
                {
                    validacao = true;
                }
            }
            if (!validacao)
            {
                DialogResult res = MessageBox.Show("Erro ao validar pagamento, selecione um valor!", "Erro (Pagamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if(tb_cliente.Text == "Escolha o cliente...")
            {
                DialogResult res = MessageBox.Show("Erro ao validar cliente, se faz necessario escolher um cliente!", "Erro (Cliente)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tb_descricao.Text == "")
            {
                DialogResult res = MessageBox.Show("Erro ao validar descrição, se faz necessario uma descrição!", "Erro (Descrição)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Termino da validacao  de pagamento
            return true;
        }

        private void InserirEntradaBanco()
        {
            try
            {
                string sql = String.Format(@"INSERT INTO tb_financeiro(T_BARBEIRO,T_CATEGORIA,T_CLIENTE,T_DESCRICAO,D_VALOR,D_DATA,T_TIPOPAGAMENTO) 
                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", tb_nomeBarbeiro.Text, VariaveisEntrada.categoria, tb_cliente.Text, VariaveisEntrada.descricao,
                VariaveisEntrada.valor, Util.FormatarInsercaoData(VariaveisEntrada.data), VariaveisEntrada.tipoPagamento);
                Banco.dml(sql);
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao inserir entrada, este erro não deveria acontecer!", "Erro (Inserir Entrada)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            FormSelecaoCliente formSelecao = new FormSelecaoCliente();
            formSelecao.ShowDialog();
            tb_cliente.Text = VariaveisServico.nomeCliente;
        }

        private void btn_incluirServico_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                VariaveisEntrada.descricao = tb_descricao.Text;
                VariaveisEntrada.tipoPagamento = cb_pagamentos.Text;

                DialogResult res = MessageBox.Show("Deseja confirmar a seguinte entrada?\n" + "Data: " + VariaveisEntrada.data +
                    "\nCliente: " + tb_cliente.Text + "\n" + "Valor da Serviço: R$ " + VariaveisEntrada.valor + "\n" + "Pagamento no (" + VariaveisEntrada.tipoPagamento + ")\n",
                    "Confirmação do Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                   InserirEntradaBanco();
                    Util.zerarVariaveisEntrada();
                }

                Limpar();
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            VariaveisEntrada.data = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientecs formClientecs = new FormClientecs();
            formClientecs.ShowDialog();
        }
    }
}
