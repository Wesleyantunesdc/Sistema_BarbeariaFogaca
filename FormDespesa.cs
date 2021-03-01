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
    public partial class FormDespesa : Form
    {
        public FormDespesa()
        {
            InitializeComponent();
        }

        private void FormDespesa_Load(object sender, EventArgs e)
        {
            tb_nomeBarbeiro.Text = Util.nomeBarbeiro;
            tb_data.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_incluirServico_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                DialogResult res = MessageBox.Show("Deseja adicionar a seguinte despesa ?\nDespesa: " + tb_descricao.Text + "\nData: " + tb_data.Text + "\nValor: " + tb_valor.Text + " (" + cb_pagamentos.Text + ")",
                "Inserção de despesa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    VariaveisDespesa.tipoPagamento = cb_pagamentos.Text;
                    VariaveisDespesa.descricao = tb_descricao.Text;
                    VariaveisDespesa.data = Util.FormatarInsercaoData(tb_data.Text);
                    InserirDespesaBanco();
                }
                Limpar();
            }
        }



        private bool VerificarCampos()
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
                if(tb_valor.Text == "")
                {
                    DialogResult res = MessageBox.Show("Erro ao validar valor, valor não foi preenchido!", "Erro (Valor)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    VariaveisDespesa.valor = Convert.ToDecimal(tb_valor.Text.Replace('.', ','));
                }
            }catch( Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao validar valor, preencha de forma correta!", "Erro (Valor)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Validação do pagamento
            bool validacao = false;
            for(int i=0; i < cb_pagamentos.Items.Count; i++)
            {
                if (cb_pagamentos.Text == cb_pagamentos.Items[i].ToString())
                {
                    validacao = true;
                }
            }
            if (!validacao)
            {
                DialogResult res = MessageBox.Show("Erro ao validar pagamento, selecione um valo!", "Erro (Pagamento)",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;

            }

            if(tb_descricao.Text == "")
            {
                DialogResult res = MessageBox.Show("Erro ao validar descrição, se faz necessario uma descrição!", "Erro (Descrição)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Termino da validacao  de pagamento
            return true;
        }

        private void Limpar()
        {
            tb_valor.Text = "";
            tb_descricao.Text = "";
            cb_pagamentos.Text = "";
        }
        //Metódo sql

        private void InserirDespesaBanco()
        {
            try
            {
                string sql = String.Format(@"INSERT INTO tb_financeiro(T_BARBEIRO,T_CATEGORIA,T_CLIENTE,T_DESCRICAO,D_VALOR,D_DATA,T_TIPOPAGAMENTO) 
                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",tb_nomeBarbeiro.Text,VariaveisDespesa.categoria,VariaveisDespesa.cliente,VariaveisDespesa.descricao,
                VariaveisDespesa.valor,VariaveisDespesa.data,VariaveisDespesa.tipoPagamento);
                Banco.dml(sql);
            }catch (Exception ex)
            {
                DialogResult res = MessageBox.Show("Erro ao inserir despesa, este erro não deveria acontecer!", "Erro (Inserir Despesa)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            tb_data.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
    }
}
