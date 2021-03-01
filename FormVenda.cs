using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaFogaca
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
            tb_nomeBarbeiro.Text = Util.nomeBarbeiro;
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            VariaveisVenda.dataVenda = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            VariaveisVenda.dataVenda = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cb_pagamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Metodos relevantes nesta classe
        private void Limpar()
        {
            tb_desconto.Text = "0";
            cb_pagamentos.Text = "Dinheiro";
            tb_produtoSelecionado.Text = "Escolha o cliente...";
        }

        private void btn_selecionarCliente_Click(object sender, EventArgs e)
        {
            FormSelecaoCliente formSelecao = new FormSelecaoCliente();
            formSelecao.ShowDialog();
            if (VariaveisServico.nomeCliente != "")
            {
                tb_cliente.Text = VariaveisServico.nomeCliente;
            }
        }

        private void btn_selecionarProduto_Click(object sender, EventArgs e)
        {
            FormSelecaoProduto formSelecaoProduto = new FormSelecaoProduto();
            formSelecaoProduto.ShowDialog();
            tb_quantidadeDisponivel.Text = VariaveisVenda.quantidadeDisponivel.ToString();
            tb_valor.Text = VariaveisVenda.preco.ToString();
            tb_produtoSelecionado.Text = VariaveisVenda.nomeProduto;
            tb_valorVenda.Text =  AtualizarValorVenda().ToString();
        }

        private void btn_incluirServico_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                DialogResult res = MessageBox.Show("Deseja confirmar a seguinte venda ?\n" + "Data: "+VariaveisVenda.dataVenda+
                    "\nCliente: "+tb_cliente.Text+"\n"+ "Produto: " + tb_produtoSelecionado.Text+ "\n" + "Valor da venda: R$ " + VariaveisVenda.total + "\n",
                    "Confrimação da venda", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    VariaveisVenda.pagamento = cb_pagamentos.Text;
                    InserirVenda();
                    InserirSaidaProduto();
                    Util.zerarVariaveisVenda();
                }
                ZerarCampos();
            }
        }

        private decimal AtualizarValorVenda()
        {
            decimal valorProduto = Convert.ToDecimal(tb_valor.Text);
            decimal quantidade = Convert.ToDecimal(n_quantidadeSerVendida.Value.ToString());
            decimal valorVenda = valorProduto * quantidade;
            return valorVenda;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void n_quantidadeSerVendida_ValueChanged(object sender, EventArgs e)
        {
            tb_valorVenda.Text = "R$ "+ AtualizarValorVenda().ToString();
        }

        public void ZerarCampos()
        {
            cb_pagamentos.Text = "Dinheiro";
            tb_produtoSelecionado.Text = "Escolha o produto...";
            tb_valor.Text = "0";
            tb_quantidadeDisponivel.Text = "0";
            n_quantidadeSerVendida.Value = 1;
            tb_cliente.Text = "Escolha o cliente...";
            tb_valorVenda.Text = "R$ 0";
            tb_desconto.Text = "0";
        }

        /// Validação do fomrulario
        /// </summary>
        /// <returns></returns>
        private bool ValidarFormulario()
        {
            VariaveisVenda.dataVenda = monthCalendar1.SelectionStart.ToString();
            int quantidadeSerVendida = int.Parse(n_quantidadeSerVendida.Value.ToString());
            int quantidadeDisponivel = int.Parse(tb_quantidadeDisponivel.Text);

            if (VariaveisVenda.idBarbeiro == 0)
            {
                DialogResult res = MessageBox.Show("Erro ao inserir barbeiro responsavel!", "Erro (Barbeiro)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool possui = false;
            int quantidadePagamento = cb_pagamentos.Items.Count;
            for (int i = 0; i < quantidadePagamento; i++)
            {
                if (cb_pagamentos.Text == cb_pagamentos.Items[i].ToString())
                {
                    possui = true;
                }
            }

            if (!possui)
            {
                DialogResult res = MessageBox.Show("Erro ao inserir forma de pagamento!", "Erro (Pagamento)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (tb_produtoSelecionado.Text == "Escolha o produto..."|| tb_produtoSelecionado.Text == "")
            {
                DialogResult res = MessageBox.Show("Selecione o produto de forma correta!","Erro (Produto)",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if(quantidadeDisponivel < quantidadeSerVendida)
            {
                DialogResult res = MessageBox.Show("Valores incoerentes, verifique o campo de 'quantidade a ser vendido!'", "Erro (Produto)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(tb_cliente.Text == "Escolha o cliente...")
            {
                DialogResult res = MessageBox.Show("Selecione o cliente de forma correta!", "Erro (Cliente)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(VariaveisVenda.dataVenda != "")
            {
                DateTime dataVenda = Convert.ToDateTime(VariaveisVenda.dataVenda);

                if (dataVenda.Date.CompareTo(DateTime.Today) > 0)
                {
                    DialogResult res = MessageBox.Show("A data selecionada tem que ser a atual ou passada!", "Erro (Data)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Erro ao setar data!", "Erro (Data)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!SetarValorFinal())
            {
                return false;
            }
            return true;

        }

        private bool SetarValorFinal()
        {
            try
            {
                Decimal valorPorduto = Convert.ToDecimal(tb_valor.Text.ToString());
                Decimal quantidadeVendida = Convert.ToDecimal(n_quantidadeSerVendida.Value.ToString()); 
                Decimal ValorDesconto = Convert.ToDecimal(tb_desconto.Text.Replace('.',',')); 
               
                VariaveisVenda.total = (valorPorduto * quantidadeVendida) - ValorDesconto;
                return true;
            }catch(Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao converter Valor!", "Erro (Valor)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void InserirVenda()
        {
            try
            {
                string sql = String.Format(@"INSERT INTO tb_financeiro(T_BARBEIRO,T_CATEGORIA,T_CLIENTE,D_VALOR,T_TIPOPAGAMENTO,D_DATA,T_DESCRICAO, N_QUANTIDADEVENDIDA) VALUES
                            ( '{0}','Venda','{1}','{2}','{3}','{4}','{5}', '{6}')", tb_nomeBarbeiro.Text,tb_cliente.Text, VariaveisVenda.total, VariaveisVenda.pagamento, Util.FormatarInsercaoData(VariaveisVenda.dataVenda), tb_produtoSelecionado.Text, n_quantidadeSerVendida.Value);
                Banco.dml(sql);
                //MessageBox.Show(VariaveisVenda.idBarbeiro.ToString()+"/"+ VariaveisVenda.idCliente.ToString()+ "/" + VariaveisVenda.idProduto.ToString()+ "/" + VariaveisVenda.total.ToString()+ "/" + VariaveisVenda.pagamento.ToString()+ "/" + VariaveisVenda.dataVenda.ToString());
            }catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao inserir venda!", "Erro(Finalizar Venda)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void InserirSaidaProduto()
        {
            Decimal quantEsto = Convert.ToDecimal(tb_quantidadeDisponivel.Text);
            Decimal quantVend = Convert.ToDecimal(n_quantidadeSerVendida.Value);
            try
            {
                string sql = "UPDATE tb_produtos SET N_QUANTIDADE = " + (quantEsto-quantVend) + " WHERE N_IDPRODUTO = "+VariaveisVenda.idProduto;
                Banco.dml(sql);
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao dar saida no estoque!", "Erro (Saida de estoque)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
